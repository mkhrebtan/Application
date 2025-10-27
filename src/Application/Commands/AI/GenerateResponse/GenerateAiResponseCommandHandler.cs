using Application.Assistant;
using Application.Authentication;
using Application.Mediator;
using Application.ReadServices;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.AI.GenerateResponse;

internal sealed class GenerateAiResponseCommandHandler(
    IAiAssistant aiAssistant,
    IUserContext userContext,
    IUserRepository userRepository,
    IEventsReadService eventsReadService)
    : ICommandHandler<GenerateAiResponseCommand, string>
{
    public async Task<Result<string>> Handle(GenerateAiResponseCommand request,
        CancellationToken cancellationToken = default)
    {
        var userId = userContext.UserId;
        if (userId is null || userId == Guid.Empty)
        {
            return Result<string>.Failure(Error.Problem(
                "AiAsk.Unauthenticated",
                "User must be authenticated to interact with the AI assistant."));
        }

        var user = await userRepository.GetByIdAsync(userId.Value, cancellationToken);
        if (user is null)
        {
            return Result<string>.Failure(Error.Problem(
                "AiAsk.UserNotFound",
                "Authenticated user not found in the system."));
        }

        var promptEvents = await eventsReadService.GetEventsForAssistantAsync(cancellationToken);
        var promptData = new Prompt(
            new PromptContextData(
                DateTime.UtcNow,
                userId.Value,
                user.FirstName,
                user.LastName,
                promptEvents),
            request.Prompt);

        var response = await aiAssistant.GetResponseAsync(promptData, cancellationToken);
        return Result<string>.Success(response);
    }
}