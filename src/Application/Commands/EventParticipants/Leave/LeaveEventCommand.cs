using System.Text.Json.Serialization;
using Application.Mediator;

namespace Application.Commands.EventParticipants.Leave;

public record LeaveEventCommand([property: JsonIgnore] Guid EventId, [property: JsonIgnore] Guid? VisitorId) : ICommand;