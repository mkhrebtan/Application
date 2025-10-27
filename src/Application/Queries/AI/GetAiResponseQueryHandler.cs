using Application.Assistant;
using Application.Authentication;
using Application.Mediator;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Queries.AI;

internal sealed class GetAiResponseQueryHandler(
    IAiAssistant aiAssistant,
    IUserContext userContext,
    IUserRepository userRepository)
    : IQueryHandler<GetAiResponseQuery, string>
{
    public async Task<Result<string>> Handle(GetAiResponseQuery request, CancellationToken cancellationToken = default)
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

        var promptData = new Prompt(
            new PromptContextData(
                DateTime.UtcNow,
                userId.Value,
                user.FirstName,
                []),
            request.Query);

        var response = await aiAssistant.GetResponseAsync(promptData, cancellationToken);
        return Result<string>.Success(response);
    }
}