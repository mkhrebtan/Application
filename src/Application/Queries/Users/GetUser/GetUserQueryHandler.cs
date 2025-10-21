using Application.Authentication;
using Application.Mediator;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Queries.Users.GetUser;

internal sealed class GetUserQueryHandler(IUserRepository userRepository, IUserContext userContext)
    : IQueryHandler<GetUserQuery, GetUserQueryResponse>
{
    public async Task<Result<GetUserQueryResponse>> Handle(
        GetUserQuery request,
        CancellationToken cancellationToken = default)
    {
        var userId = userContext.UserId;
        if (userId is null || userId == Guid.Empty)
        {
            return Result<GetUserQueryResponse>.Failure(Error.Problem(
                "GetUser.Unauthorized",
                "User is not authenticated."));
        }

        var user = await userRepository.GetByIdAsync((Guid)userId, cancellationToken);
        if (user is null)
        {
            return Result<GetUserQueryResponse>.Failure(Error.NotFound(
                "GetUser.UserNotFound",
                "User not found."));
        }

        return Result<GetUserQueryResponse>.Success(new GetUserQueryResponse(
            user.FirstName,
            user.LastName,
            user.Email));
    }
}