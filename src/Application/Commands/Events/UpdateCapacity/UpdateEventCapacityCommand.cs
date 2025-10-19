using Application.Abstraction.Mediator;

namespace Application.Commands.Events.UpdateCapacity;

public record UpdateEventCapacityCommand(Guid EventId, int? Capacity) : ICommand;