using Application.Authentication;
using Application.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Users.Login;

internal sealed class LoginUserCommandHandler : ICommandHandler<LoginUserCommand, LoginUserCommandResponse>
{
    private readonly IEventParticipantRepository _eventParticipantRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IRefreshTokenRepository _refreshTokenRepository;
    private readonly ITokenProvider _tokenProvider;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;

    public LoginUserCommandHandler(
        IUserRepository userRepository,
        ITokenProvider tokenProvider,
        IPasswordHasher passwordHasher,
        IRefreshTokenRepository refreshTokenRepository,
        IUnitOfWork unitOfWork,
        IEventParticipantRepository eventParticipantRepository)
    {
        _userRepository = userRepository;
        _tokenProvider = tokenProvider;
        _passwordHasher = passwordHasher;
        _refreshTokenRepository = refreshTokenRepository;
        _unitOfWork = unitOfWork;
        _eventParticipantRepository = eventParticipantRepository;
    }

    public async Task<Result<LoginUserCommandResponse>> Handle(
        LoginUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);
        if (user is null || !_passwordHasher.VerifyHashedPassword(user.PasswordHash, request.Password))
        {
            return Result<LoginUserCommandResponse>.Failure(
                Error.NotFound("User.InvalidCredentials", "Invalid email or password."));
        }

        await _eventParticipantRepository.MergeVisitorParticipantsAsync(
            request.VisitorId,
            user.Id,
            user.Email,
            cancellationToken);

        var accessToken = _tokenProvider.GenerateAccessToken(user);
        var refreshToken = _tokenProvider.GenerateRefreshToken(user);

        _refreshTokenRepository.Add(refreshToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<LoginUserCommandResponse>.Success(
            new LoginUserCommandResponse(accessToken, refreshToken.Token));
    }
}