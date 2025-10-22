using Application.Authentication;
using Application.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.EventParticipants.Leave;

internal sealed class LeaveEventCommandHandler : ICommandHandler<LeaveEventCommand>
{
    private readonly IEventParticipantRepository _eventParticipantRepository;
    private readonly IEventRepository _eventRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserContext _userContext;

    public LeaveEventCommandHandler(
        IEventRepository eventRepository,
        IEventParticipantRepository eventParticipantRepository,
        IUserContext userContext,
        IUnitOfWork unitOfWork)
    {
        _eventRepository = eventRepository;
        _eventParticipantRepository = eventParticipantRepository;
        _userContext = userContext;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(LeaveEventCommand request, CancellationToken cancellationToken = default)
    {
        var userId = _userContext.UserId;
        if ((userId is null || userId == Guid.Empty) && request.VisitorId is null)
        {
            return Result.Failure(Error.Validation(
                "JoinEvent.InvalidParticipant",
                "Either a user must be authenticated or a visitor ID must be provided."));
        }

        var existingEvent = await _eventRepository.GetByIdAsync(request.EventId, cancellationToken);
        if (existingEvent is null)
        {
            return Result.Failure(Error.NotFound("Event.NotFound", $"Event with ID {request.EventId} was not found."));
        }

        var eventParticipant = !(userId is null || userId == Guid.Empty)
            ? await _eventParticipantRepository.GetByUserIdAndEventIdAsync(
                userId.Value,
                request.EventId,
                cancellationToken)
            : await _eventParticipantRepository.GetByVisitorIdAndEventIdAsync(
                request.VisitorId!.Value,
                request.EventId,
                cancellationToken);
        if (eventParticipant is null)
        {
            return Result.Failure(Error.Validation(
                "LeaveEvent.NotParticipant",
                "The participant is not registered for this event."));
        }

        _eventParticipantRepository.Delete(eventParticipant);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}