using Application.Mediator;

namespace Application.Commands.AI.GenerateResponse;

public record GenerateAiResponseCommand(string Prompt) : ICommand<string>;