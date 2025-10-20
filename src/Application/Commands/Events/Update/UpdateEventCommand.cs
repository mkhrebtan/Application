using Application.Common;
using Application.Mediator;

namespace Application.Commands.Events.Update;

public record UpdateEventCommand(
    Guid EventId,
    string? Title,
    string? Description,
    DateTime? Date,
    string? Location,
    OptionalUpdate<int?> Capacity,
    bool? IsPublic) : ICommand;