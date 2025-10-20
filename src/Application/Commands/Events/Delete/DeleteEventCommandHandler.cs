using Application.Abstraction.Mediator;
using Application.Authentication;
using Domain.Abstraction.Interfaces;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Events.Delete;

internal sealed class DeleteEventCommandHandler : ICommandHandler<DeleteEventCommand>
{
    private readonly IEventRepository _eventRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserContext _userContext;

    public DeleteEventCommandHandler(IEventRepository eventRepository, IUnitOfWork unitOfWork, IUserContext userContext)
    {
        _eventRepository = eventRepository;
        _unitOfWork = unitOfWork;
        _userContext = userContext;
    }

    public async Task<Result> Handle(DeleteEventCommand request, CancellationToken cancellationToken = default)
    {
        var userId = _userContext.UserId;
        if (userId == null)
        {
            return Result.Failure(Error.Problem(
                "DeleteEvent.Unauthenticated",
                "User must be authenticated to delete an event."));
        }

        var existingEvent = await _eventRepository.GetByIdAsync(request.EventId, cancellationToken);
        if (existingEvent is null)
        {
            return Result.Failure(Error.NotFound("Event.NotFound", $"Event with ID {request.EventId} was not found."));
        }

        if (existingEvent.OrganizerId != userId)
        {
            return Result.Failure(Error.Problem(
                "DeleteEvent.Forbidden",
                "User does not have permission to delete this event."));
        }

        _eventRepository.Delete(existingEvent);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}