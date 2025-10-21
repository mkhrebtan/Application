namespace Application.Queries.Users.GetUser;

public record GetUserQueryResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email);