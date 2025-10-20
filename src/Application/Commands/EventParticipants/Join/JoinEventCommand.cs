using Application.Abstraction.Mediator;

namespace Application.Commands.EventParticipants.Join;

public record JoinEventCommand(
    Guid EventId,
    Guid? VisitorId,
    string? VisitorFirstName,
    string? VisitorLastName,
    string? VisitorEmail) : ICommand;