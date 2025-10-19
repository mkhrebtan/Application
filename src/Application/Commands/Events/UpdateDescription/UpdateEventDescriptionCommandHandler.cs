using Application.Abstraction.Mediator;
using Domain.Abstraction.Interfaces;
using Domain.Repositories;
using Domain.Shared.ErrorHandling;

namespace Application.Commands.Events.UpdateDescription;

internal sealed class UpdateEventDescriptionCommandHandler : ICommandHandler<UpdateEventDescriptionCommand>
{
    private readonly IEventRepository _eventRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateEventDescriptionCommandHandler(IEventRepository eventRepository, IUnitOfWork unitOfWork)
    {
        _eventRepository = eventRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(UpdateEventDescriptionCommand request, CancellationToken cancellationToken = default)
    {
        var existingEvent = await _eventRepository.GetByIdAsync(request.EventId, cancellationToken);
        if (existingEvent is null)
        {
            return Result.Failure(Error.NotFound("Event.NotFound", $"Event with ID {request.EventId} was not found."));
        }

        var updateResult = existingEvent.UpdateDescription(request.Description);
        if (updateResult.IsFailure)
        {
            return updateResult;
        }

        _eventRepository.Update(existingEvent);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
}