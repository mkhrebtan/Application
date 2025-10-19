using Application.Abstraction.Mediator;

namespace Application.Commands.Events.UpdateLocation;

public record UpdateEventLocationCommand(Guid EventId, string Location) : ICommand;