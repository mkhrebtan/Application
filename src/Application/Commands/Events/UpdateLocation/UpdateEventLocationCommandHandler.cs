using Application.Abstraction.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Events.UpdateLocation;

internal sealed class UpdateEventLocationCommandHandler : ICommandHandler<UpdateEventLocationCommand>
{
    private readonly IEventRepository _eventRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateEventLocationCommandHandler(IEventRepository eventRepository, IUnitOfWork unitOfWork)
    {
        _eventRepository = eventRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(UpdateEventLocationCommand request, CancellationToken cancellationToken = default)
    {
        var existingEvent = await _eventRepository.GetByIdAsync(request.EventId, cancellationToken);
        if (existingEvent is null)
        {
            return Result.Failure(Error.NotFound("Event.NotFound", $"Event with ID {request.EventId} was not found."));
        }

        var updateResult = existingEvent.UpdateLocation(request.Location);
        if (updateResult.IsFailure)
        {
            return updateResult;
        }

        _eventRepository.Update(existingEvent);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
}