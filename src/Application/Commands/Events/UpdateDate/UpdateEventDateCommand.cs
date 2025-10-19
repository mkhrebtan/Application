using Application.Abstraction.Mediator;

namespace Application.Commands.Events.UpdateDate;

public record UpdateEventDateCommand(Guid EventId, DateTime Date) : ICommand;