using System.Text.Json.Serialization;
using Application.Mediator;

namespace Application.Commands.Users.Login;

public record LoginUserCommand(string Email, string Password, [property: JsonIgnore] Guid VisitorId)
    : ICommand<LoginUserCommandResponse>;