using Application.Queries.Tags.GetTags;

namespace Application.Queries.Events.GetEvent;

public record EventDetailsDto(
    Guid Id,
    string Title,
    string Description,
    DateTime Date,
    string Location,
    int? Capacity,
    int ParticipantsCount,
    bool IsUserParticipating,
    bool IsUserOrganizer,
    bool IsPublic,
    IEnumerable<TagDto> Tags);