using API.Extensions;
using Api.Middlewares.Exceptions;
using Application;
using Application.Commands.EventParticipants.Join;
using Application.Commands.EventParticipants.Leave;
using Application.Commands.Events.Create;
using Application.Commands.Events.Delete;
using Application.Commands.Events.Update;
using Application.Commands.Users.Login;
using Application.Commands.Users.RefreshToken;
using Application.Commands.Users.Signup;
using Application.Mediator;
using Application.Queries.Events.GetEvent;
using Application.Queries.Events.GetEventParticipants;
using Application.Queries.Events.GetEventsList;
using Application.Queries.Events.GetUserEvents;
using Application.Queries.Tags.GetTags;
using Application.Queries.Users.GetUser;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services
    .AddPersistence(builder.Configuration)
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.Services.AddSwaggerGenWithAuth();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhostFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:8080", "http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(setup =>
    {
        setup.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
        setup.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.MapSwagger().RequireAuthorization();

app.UseAuthentication();
app.UseAuthorization();

app.UseExceptionHandler();

app.UseCors("AllowLocalhostFrontend");

// Auth Endpoints
app.MapPost("/auth/login", async (
        [FromHeader(Name = "X-Visitor-Id")] Guid visitorId,
        LoginUserCommand request,
        ICommandHandler<LoginUserCommand, LoginUserCommandResponse> handler,
        CancellationToken cancellationToken) =>
    {
        request = request with { VisitorId = visitorId, };
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Auth");

app.MapPost("/auth/signup", async (
        [FromHeader(Name = "X-Visitor-Id")] Guid visitorId,
        SignupUserCommand request,
        ICommandHandler<SignupUserCommand, SignupUserCommandResponse> handler,
        CancellationToken cancellationToken) =>
    {
        request = request with { VisitorId = visitorId, };
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Auth");

app.MapPost("/auth/refresh-token", async (
        RefreshTokenCommand request,
        ICommandHandler<RefreshTokenCommand, RefreshTokenCommandResponse> handler,
        CancellationToken cancellationToken) =>
    {
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Auth");

app.MapPost("/events", async (
        CreateEventCommand request,
        ICommandHandler<CreateEventCommand, CreateEventCommandResponse> handler,
        CancellationToken cancellationToken) =>
    {
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Events")
    .RequireAuthorization();

app.MapPatch("/events/{id:guid}", async (
        Guid id,
        UpdateEventCommand request,
        ICommandHandler<UpdateEventCommand> handler,
        CancellationToken cancellationToken) =>
    {
        request = request with { EventId = id, };
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.NoContent() : result.GetProblem();
    })
    .WithTags("Events")
    .RequireAuthorization();

app.MapDelete("/events/{id:guid}", async (
        Guid id,
        ICommandHandler<DeleteEventCommand> handler,
        CancellationToken cancellationToken) =>
    {
        var request = new DeleteEventCommand(id);
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.NoContent() : result.GetProblem();
    })
    .WithTags("Events")
    .RequireAuthorization();

app.MapPost("/events/{id:guid}/join", async (
        Guid id,
        [FromHeader(Name = "X-Visitor-Id")] Guid? visitorId,
        JoinEventCommand request,
        ICommandHandler<JoinEventCommand> handler,
        CancellationToken cancellationToken) =>
    {
        request = request with { EventId = id, VisitorId = visitorId, };
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.NoContent() : result.GetProblem();
    })
    .WithTags("Events");

app.MapPost("/events/{id:guid}/leave", async (
        Guid id,
        [FromHeader(Name = "X-Visitor-Id")] Guid? visitorId,
        LeaveEventCommand request,
        ICommandHandler<LeaveEventCommand> handler,
        CancellationToken cancellationToken) =>
    {
        request = request with { EventId = id, VisitorId = visitorId, };
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.NoContent() : result.GetProblem();
    })
    .WithTags("Events");

app.MapGet("/events", async (
        [FromHeader(Name = "X-Visitor-Id")] Guid? visitorId,
        string? searchTerm,
        bool? today,
        bool? weekend,
        Guid[]? tagIds,
        int pageNumber,
        int pageSize,
        IQueryHandler<GetEventsListQuery, EventsListQueryResponse> handler,
        CancellationToken cancellationToken) =>
    {
        var request = new GetEventsListQuery(visitorId, searchTerm, today, weekend, tagIds, pageNumber, pageSize);
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Events");

app.MapGet("/events/{id:guid}", async (
        Guid id,
        [FromHeader(Name = "X-Visitor-Id")] Guid? visitorId,
        IQueryHandler<GetEventQuery, GetEventQueryResponse> handler,
        CancellationToken cancellationToken) =>
    {
        var request = new GetEventQuery(id, visitorId);
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Events");

app.MapGet("/events/me", async (
        IQueryHandler<GetUserEventsQuery, GetUserEventsQueryResponse> handler,
        CancellationToken cancellationToken) =>
    {
        var request = new GetUserEventsQuery();
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Events");

app.MapGet("/events/{id:guid}/participants", async (
        Guid id,
        IQueryHandler<GetEventParticipantsQuery, GetEventParticipantsQueryResponse> handler,
        CancellationToken cancellationToken) =>
    {
        var request = new GetEventParticipantsQuery(id);
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Events");

app.MapGet("users/me", async (
        IQueryHandler<GetUserQuery, GetUserQueryResponse> handler,
        CancellationToken cancellationToken) =>
    {
        var request = new GetUserQuery();
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Users")
    .RequireAuthorization();

app.MapGet("tags", async (
        IQueryHandler<GetTagsQuery, GetTagsQueryResponse> queryHandler) =>
    {
        var query = new GetTagsQuery();
        var result = await queryHandler.Handle(query, CancellationToken.None);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Tags");

await app.RunAsync();