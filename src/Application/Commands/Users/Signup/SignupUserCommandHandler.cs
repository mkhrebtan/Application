using Application.Authentication;
using Application.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Models;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Users.Signup;

internal sealed class SignupUserCommandHandler : ICommandHandler<SignupUserCommand, SignupUserCommandResponse>
{
    private readonly IEventParticipantRepository _eventParticipantRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IRefreshTokenRepository _refreshTokenRepository;
    private readonly ITokenProvider _tokenProvider;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;

    public SignupUserCommandHandler(
        IUserRepository userRepository,
        IUnitOfWork unitOfWork,
        ITokenProvider tokenProvider,
        IPasswordHasher passwordHasher,
        IEventParticipantRepository eventParticipantRepository,
        IRefreshTokenRepository refreshTokenRepository)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _tokenProvider = tokenProvider;
        _passwordHasher = passwordHasher;
        _eventParticipantRepository = eventParticipantRepository;
        _refreshTokenRepository = refreshTokenRepository;
    }

    public async Task<Result<SignupUserCommandResponse>> Handle(
        SignupUserCommand request,
        CancellationToken cancellationToken = default)
    {
        if (await _userRepository.EmailExistsAsync(request.Email, cancellationToken))
        {
            return Result<SignupUserCommandResponse>.Failure(Error.Conflict("User.EmailAlreadyExists",
                "The specified email is already in use."));
        }

        var passwordHash = _passwordHasher.HashPassword(request.Password);
        var userResult = User.Create(request.FirstName, request.LastName, request.Email, passwordHash);
        if (userResult.IsFailure)
        {
            return Result<SignupUserCommandResponse>.Failure(userResult.Error);
        }

        _userRepository.Add(userResult.Value);

        await _eventParticipantRepository.MergeVisitorParticipantsAsync(
            request.VisitorId,
            userResult.Value.Id,
            userResult.Value.Email,
            cancellationToken);

        var accessToken = _tokenProvider.GenerateAccessToken(userResult.Value);
        var refreshToken = _tokenProvider.GenerateRefreshToken(userResult.Value);

        _refreshTokenRepository.Add(refreshToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<SignupUserCommandResponse>.Success(
            new SignupUserCommandResponse(accessToken, refreshToken.Token));
    }
}