using Application.Abstraction.Mediator;

namespace Application.Commands.Events.Delete;

public record DeleteEventCommand(Guid EventId) : ICommand;