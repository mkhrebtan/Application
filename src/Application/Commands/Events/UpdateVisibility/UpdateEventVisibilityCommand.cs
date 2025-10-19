using Application.Abstraction.Mediator;

namespace Application.Commands.Events.UpdateVisibility;

public record UpdateEventVisibilityCommand(Guid EventId, bool IsPublic) : ICommand;