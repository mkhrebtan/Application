using Application.Mediator;

namespace Application.Queries.AI;

public record GetAiResponseQuery(string Query) : IQuery<string>;