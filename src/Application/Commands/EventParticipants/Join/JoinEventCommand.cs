using System.Text.Json.Serialization;
using Application.Mediator;

namespace Application.Commands.EventParticipants.Join;

public record JoinEventCommand(
    [property: JsonIgnore] Guid EventId,
    [property: JsonIgnore] Guid? VisitorId,
    string? VisitorFirstName,
    string? VisitorLastName,
    string? VisitorEmail) : ICommand;