using Application.Abstraction.Mediator;

namespace Application.Commands.Events.Create;

public record CreateEventCommand(
    string Title,
    string Description,
    DateTime Date,
    string Location,
    int? Capacity,
    bool IsPublic)
    : ICommand<CreateEventCommandResponse>;