using System.Text.Json.Serialization;
using Application.Common;
using Application.Mediator;

namespace Application.Commands.Events.Update;

public record UpdateEventCommand(
    [property: JsonIgnore] Guid EventId,
    string? Title,
    string? Description,
    DateTime? Date,
    string? Location,
    OptionalUpdate<int?> Capacity,
    bool? IsPublic,
    Guid[] TagIds,
    string[] UserTagNames) : ICommand;