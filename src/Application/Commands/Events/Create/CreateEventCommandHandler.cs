using Application.Abstraction.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Models;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Events.Create;

internal sealed class CreateEventCommandHandler : ICommandHandler<CreateEventCommand, CreateEventCommandResponse>
{
    private readonly IEventRepository _eventRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateEventCommandHandler(IEventRepository eventRepository, IUnitOfWork unitOfWork)
    {
        _eventRepository = eventRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<CreateEventCommandResponse>> Handle(
        CreateEventCommand request,
        CancellationToken cancellationToken = default)
    {
        var newEventResult = Event.Create(
            Guid.NewGuid(),
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