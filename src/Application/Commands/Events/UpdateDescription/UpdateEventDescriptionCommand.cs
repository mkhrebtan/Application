using Application.Abstraction.Mediator;

namespace Application.Commands.Events.UpdateDescription;

public record UpdateEventDescriptionCommand(Guid EventId, string Description) : ICommand;