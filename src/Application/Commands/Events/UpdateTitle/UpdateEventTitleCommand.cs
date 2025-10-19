using Application.Abstraction.Mediator;

namespace Application.Commands.Events.UpdateTitle;

public record UpdateEventTitleCommand(Guid EventId, string Title) : ICommand;