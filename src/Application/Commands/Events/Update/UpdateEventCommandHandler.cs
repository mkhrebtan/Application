using Application.Authentication;
using Application.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Models;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Events.Update;

internal sealed class UpdateEventCommandHandler(
    IEventRepository eventRepository,
    IUnitOfWork unitOfWork,
    IUserContext userContext,
    IEventTagRepository eventTagRepository,
    ITagRepository tagRepository)
    : ICommandHandler<UpdateEventCommand>
{
    public async Task<Result> Handle(UpdateEventCommand request, CancellationToken cancellationToken = default)
    {
        var userId = userContext.UserId;
        if (userId == null)
        {
            return Result.Failure(Error.Problem(
                "UpdateEvent.Unauthenticated",
                "User must be authenticated to update an event."));
        }

        var existingEvent = await eventRepository.GetByIdWithTagsAsync(request.EventId, cancellationToken);
        if (existingEvent is null)
        {
            return Result.Failure(Error.NotFound("Event.NotFound", $"Event with ID {request.EventId} was not found."));
        }

        if (existingEvent.OrganizerId != userId)
        {
            return Result.Failure(Error.Problem(
                "UpdateEvent.Forbidden",
                "User does not have permission to update this event."));
        }

        var updateResults = new[]
        {
            request.Title is not null ? existingEvent.UpdateTitle(request.Title) : Result.Success(),
            request.Description is not null ? existingEvent.UpdateDescription(request.Description) : Result.Success(),
            request.Date is not null ? existingEvent.UpdateDate(request.Date.Value) : Result.Success(),
            request.Location is not null ? existingEvent.UpdateLocation(request.Location) : Result.Success(),
            request.Capacity.IsSpecified ? existingEvent.UpdateCapacity(request.Capacity.Value) : Result.Success(),
            request.IsPublic is not null ? existingEvent.UpdateVisibility(request.IsPublic.Value) : Result.Success(),
        };

        foreach (var result in updateResults)
        {
            if (result.IsFailure)
            {
                return result;
            }
        }

        eventRepository.Update(existingEvent);

        var allTagIds = new List<Guid>(request.TagIds);

        if (request.UserTagNames?.Length > 0)
        {
            var existingTags =
                await tagRepository.GetTagsByNamesAsync(
                    request.UserTagNames.Select(Tag.NormalizeName),
                    cancellationToken);
            var existingTagNames = existingTags.Select(t => t.NormalizedName).ToHashSet();

            allTagIds.AddRange(existingTags.Select(t => t.Id));

            var newTags = request.UserTagNames
                .Where(name => !existingTagNames.Contains(Tag.NormalizeName(name)))
                .Distinct()
                .Select(tagName => new Tag(tagName));

            foreach (var newTag in newTags)
            {
                tagRepository.Add(newTag);
                allTagIds.Add(newTag.Id);
            }
        }

        var currentTagIds = existingEvent.EventTags.Select(et => et.TagId).ToHashSet();
        var newTagIds = allTagIds.ToHashSet();

        foreach (var tagId in newTagIds.Except(currentTagIds))
        {
            eventTagRepository.Add(new EventTag(existingEvent.Id, tagId));
        }

        foreach (var tag in existingEvent.EventTags.Where(et => !newTagIds.Contains(et.TagId)))
        {
            eventTagRepository.Delete(tag);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
}