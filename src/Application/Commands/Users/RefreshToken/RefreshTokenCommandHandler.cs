using Application.Authentication;
using Application.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Users.RefreshToken;

internal sealed class RefreshTokenCommandHandler : ICommandHandler<RefreshTokenCommand, RefreshTokenCommandResponse>
{
    private readonly IRefreshTokenRepository _refreshTokenRepository;
    private readonly ITokenProvider _tokenProvider;
    private readonly IUnitOfWork _unitOfWork;

    public RefreshTokenCommandHandler(
        IRefreshTokenRepository refreshTokenRepository,
        IUnitOfWork unitOfWork,
        ITokenProvider tokenProvider)
    {
        _refreshTokenRepository = refreshTokenRepository;
        _unitOfWork = unitOfWork;
        _tokenProvider = tokenProvider;
    }

    public async Task<Result<RefreshTokenCommandResponse>> Handle(
        RefreshTokenCommand request,
        CancellationToken cancellationToken = default)
    {
        var existingRefreshToken =
            await _refreshTokenRepository.GetByTokenAsync(request.RefreshToken, cancellationToken);
        if (existingRefreshToken is null || existingRefreshToken.ExpiresAt < DateTime.UtcNow)
        {
            return Result<RefreshTokenCommandResponse>.Failure(
                Error.Problem("RefreshToken.Invalid", "The provided refresh token is invalid or has expired."));
        }

        existingRefreshToken.Revoke();

        var user = existingRefreshToken.User;
        var newAccessToken = _tokenProvider.GenerateAccessToken(user!);
        var newRefreshToken = _tokenProvider.GenerateRefreshToken(user!);

        _refreshTokenRepository.Update(existingRefreshToken);
        _refreshTokenRepository.Add(newRefreshToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<RefreshTokenCommandResponse>.Success(
            new RefreshTokenCommandResponse(newAccessToken, newRefreshToken.Token));
    }
}