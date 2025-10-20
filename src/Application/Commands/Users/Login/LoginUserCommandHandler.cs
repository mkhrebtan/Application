using Application.Authentication;
using Application.Mediator;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Users.Login;

internal sealed class LoginUserCommandHandler : ICommandHandler<LoginUserCommand, LoginUserCommandResponse>
{
    private readonly IPasswordHasher _passwordHasher;
    private readonly ITokenProvider _tokenProvider;
    private readonly IUserRepository _userRepository;

    public LoginUserCommandHandler(
        IUserRepository userRepository,
        ITokenProvider tokenProvider,
        IPasswordHasher passwordHasher)
    {
        _userRepository = userRepository;
        _tokenProvider = tokenProvider;
        _passwordHasher = passwordHasher;
    }

    public async Task<Result<LoginUserCommandResponse>> Handle(
        LoginUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);
        if (user is null)
        {
            return Result<LoginUserCommandResponse>.Failure(
                Error.NotFound("User.InvalidCredentials", "Invalid email or password."));
        }

        if (!_passwordHasher.VerifyHashedPassword(user.PasswordHash, request.Password))
        {
            return Result<LoginUserCommandResponse>.Failure(
                Error.NotFound("User.InvalidCredentials", "Invalid email or password."));
        }

        var accessToken = _tokenProvider.GenerateAccessToken(user);
        var refreshToken = _tokenProvider.GenerateRefreshToken(user);

        return Result<LoginUserCommandResponse>.Success(
            new LoginUserCommandResponse(accessToken, refreshToken.Token));
    }
}