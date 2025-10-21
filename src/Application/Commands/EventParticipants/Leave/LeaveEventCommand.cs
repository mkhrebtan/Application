using System.Text.Json.Serialization;
using Application.Mediator;

namespace Application.Commands.EventParticipants.Leave;

public record LeaveEventCommand([property: JsonIgnore] Guid EventId, Guid? VisitorId) : ICommand;