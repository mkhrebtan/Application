using Application.Abstraction.Mediator;

namespace Application.Commands.EventParticipants.Leave;

public record LeaveEventCommand(Guid EventId, Guid? VisitorId) : ICommand;