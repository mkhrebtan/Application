using Application.Authentication;
using Application.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Models;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Events.Create;

internal sealed class CreateEventCommandHandler(
    IEventRepository eventRepository,
    IUnitOfWork unitOfWork,
    IUserContext userContext,
    ITagRepository tagRepository,
    IEventTagRepository eventTagRepository)
    : ICommandHandler<CreateEventCommand, CreateEventCommandResponse>
{
    public async Task<Result<CreateEventCommandResponse>> Handle(
        CreateEventCommand request,
        CancellationToken cancellationToken = default)
    {
        var userId = userContext.UserId;
        if (userId is null)
        {
            return Result<CreateEventCommandResponse>.Failure(Error.Problem(
                "CreateEvent.Unauthenticated",
                "User must be authenticated to create an event."));
        }

        var tagsExist = await tagRepository.TagIdsExistAsync(request.TagIds, cancellationToken);
        if (!tagsExist)
        {
            return Result<CreateEventCommandResponse>.Failure(Error.Problem(
                "CreateEvent.InvalidTags",
                "One or more provided tag IDs do not exist."));
        }

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

        var newEventResult = Event.Create(
            userId.Value,
            request.Title,
            request.Description,
            request.Date,
            request.Location,
            request.IsPublic,
            request.Capacity);
        if (newEventResult.IsFailure)
        {
            return Result<CreateEventCommandResponse>.Failure(newEventResult.Error);
        }

        eventRepository.Add(newEventResult.Value);
        eventTagRepository.AddRange(allTagIds.Select(tagId =>
            new EventTag(tagId: tagId, eventId: newEventResult.Value.Id)));

        await unitOfWork.SaveChangesAsync(cancellationToken);
        var response = new CreateEventCommandResponse(newEventResult.Value.Id);
        return Result<CreateEventCommandResponse>.Success(response);
    }
}