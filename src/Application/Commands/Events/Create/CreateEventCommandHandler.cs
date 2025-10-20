using Application.Abstraction.Mediator;
using Application.Authentication;
using Domain.Abstraction.Interfaces;
using Domain.Models;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Events.Create;

internal sealed class CreateEventCommandHandler : ICommandHandler<CreateEventCommand, CreateEventCommandResponse>
{
    private readonly IEventRepository _eventRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserContext _userContext;

    public CreateEventCommandHandler(IEventRepository eventRepository, IUnitOfWork unitOfWork, IUserContext userContext)
    {
        _eventRepository = eventRepository;
        _unitOfWork = unitOfWork;
        _userContext = userContext;
    }

    public async Task<Result<CreateEventCommandResponse>> Handle(
        CreateEventCommand request,
        CancellationToken cancellationToken = default)
    {
        var userId = _userContext.UserId;
        if (userId is null)
        {
            return Result<CreateEventCommandResponse>.Failure(Error.Problem(
                "CreateEvent.Unauthenticated",
                "User must be authenticated to create an event."));
        }

        var newEventResult = Event.Create(
            userId.Value,
            request.Title,
            request.Description,
            request.Date,
            request.Location,
            request.IsPublic,
            request.Capacity);
        if (newEventResult.IsFailure)
        {
            return Result<CreateEventCommandResponse>.Failure(newEventResult.Error);
        }

        _eventRepository.Add(newEventResult.Value);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        var response = new CreateEventCommandResponse(newEventResult.Value.Id);
        return Result<CreateEventCommandResponse>.Success(response);
    }
}