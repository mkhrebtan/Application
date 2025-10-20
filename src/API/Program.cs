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
using Infrastructure;
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

// Auth Endpoints
app.MapPost("/auth/login", async (
        LoginUserCommand request,
        ICommandHandler<LoginUserCommand, LoginUserCommandResponse> handler,
        CancellationToken cancellationToken) =>
    {
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.Ok(result.Value) : result.GetProblem();
    })
    .WithTags("Auth");

app.MapPost("/auth/signup", async (
        SignupUserCommand request,
        ICommandHandler<SignupUserCommand, SignupUserCommandResponse> handler,
        CancellationToken cancellationToken) =>
    {
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

// Event Endpoints
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
        JoinEventCommand request,
        ICommandHandler<JoinEventCommand> handler,
        CancellationToken cancellationToken) =>
    {
        request = request with { EventId = id, };
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.NoContent() : result.GetProblem();
    })
    .WithTags("Events");

app.MapPost("/events/{id:guid}/leave", async (
        Guid id,
        LeaveEventCommand request,
        ICommandHandler<LeaveEventCommand> handler,
        CancellationToken cancellationToken) =>
    {
        request = request with { EventId = id, };
        var result = await handler.Handle(request, cancellationToken);
        return result.IsSuccess ? Results.NoContent() : result.GetProblem();
    })
    .WithTags("Events");

await app.RunAsync();