using Application.Abstraction.Mediator;
using Application.Authentication;
using Domain.Abstraction.Interfaces;
using Domain.Models;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.EventParticipants.Join;

internal sealed class JoinEventCommandHandler : ICommandHandler<JoinEventCommand>
{
    private readonly IEventParticipantRepository _eventParticipantRepository;
    private readonly IEventRepository _eventRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserContext _userContext;

    public JoinEventCommandHandler(
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

    public async Task<Result> Handle(JoinEventCommand request, CancellationToken cancellationToken = default)
    {
        var userId = _userContext.UserId;
        if (userId is null && request.VisitorId is null)
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

        var isAlreadyParticipant = userId.HasValue
            ? await _eventParticipantRepository.IsUserParticipantInEventAsync(
                userId.Value,
                request.EventId,
                cancellationToken)
            : await _eventParticipantRepository.IsVisitorParticipantInEventAsync(
                request.VisitorId!.Value,
                request.EventId,
                cancellationToken);
        if (isAlreadyParticipant)
        {
            return Result.Failure(Error.Validation(
                "JoinEvent.AlreadyParticipant",
                "The participant is already registered for this event."));
        }

        if (existingEvent.Capacity is not null &&
            await _eventParticipantRepository.GetEventParticipantCountAsync(existingEvent.Id, cancellationToken) >=
            existingEvent.Capacity)
        {
            return Result.Failure(Error.Validation(
                "JoinEvent.EventFull",
                "The event has reached its maximum capacity."));
        }

        var newParticipant = new EventParticipant(
            existingEvent.Id,
            userId,
            request.VisitorId,
            request.VisitorFirstName,
            request.VisitorLastName,
            request.VisitorEmail);

        _eventParticipantRepository.Add(newParticipant);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}