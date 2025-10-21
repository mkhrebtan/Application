using Application.Authentication;
using Application.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Events.Update;

internal sealed class UpdateEventCommandHandler : ICommandHandler<UpdateEventCommand>
{
    private readonly IEventRepository _eventRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserContext _userContext;

    public UpdateEventCommandHandler(IEventRepository eventRepository, IUnitOfWork unitOfWork, IUserContext userContext)
    {
        _eventRepository = eventRepository;
        _unitOfWork = unitOfWork;
        _userContext = userContext;
    }

    public async Task<Result> Handle(UpdateEventCommand request, CancellationToken cancellationToken = default)
    {
        var userId = _userContext.UserId;
        if (userId == null)
        {
            return Result.Failure(Error.Problem(
                "UpdateEvent.Unauthenticated",
                "User must be authenticated to update an event."));
        }

        var existingEvent = await _eventRepository.GetByIdAsync(request.EventId, cancellationToken);
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

        _eventRepository.Update(existingEvent);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
}