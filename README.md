# Event Management Application

This is a full-stack application for managing events, built with an Angular frontend and an ASP.NET Core backend.

## Prerequisites

- [Docker](httpss://www.docker.com/get-started)
- [.NET SDK](httpss://dotnet.microsoft.com/download) (for local development/testing)
- [Node.js and npm](httpss://nodejs.org/en/download/) (for local development/testing)

## Technology Stack

### Backend

-   **.NET 9**
-   **ASP.NET Core**: For building the RESTful API.
-   **Entity Framework Core**: For data access and object-relational mapping.
-   **PostgreSQL**: The relational database.
-   **MediatR**: For implementing the CQRS pattern.
-   **FluentValidation**: For request validation.
-   **JWT (JSON Web Tokens)**: For securing the API.
-   **Docker**: For containerization.

### Frontend

-   **Angular 20**
-   **Tailwind CSS**: For styling.
-   **RxJS**: For reactive programming.

## Features

-   **User Authentication**: Secure user registration and login using JWT.
-   **Event Management**: Create, read, update, and delete events.
-   **Event Participation**: Users can join and leave events.
-   **Paged Lists**: Efficiently browse through large lists of events and users.
-   **Validation**: Robust input validation for all incoming requests.

## Setup and Running the Application

1.  **Clone the repository:**
    ```bash
    git clone <repository-url>
    cd <repository-folder>
    ```

2.  **Configure Environment Variables:**
    Create a `.env` file in the root of the project by copying the example below. Update the values as needed for your environment.

    ```dotenv
    POSTGRES_DB=event-management
    POSTGRES_USER=postgres
    POSTGRES_PASSWORD=postgres123
    POSTGRES_HOST=event-management.database
    POSTGRES_PORT=5432
    CONNECTION_STRING='Host=event-management.database;Port=5432;Database=event-management;Username=postgres;Password=postgres123;Pooling=true;Include Error Detail=true'

    ASPNETCORE_URLS=https://+:443;http://+:80
    ASPNETCORE_Kestrel__Certificates__Default__Password=Your_SSL_Certificate_Password
    ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx

    JwtSettings__SecretKey=a_long_and_secure_secret_key_for_jwt
    JwtSettings__Issuer=EventManagementAPI
    JwtSettings__Audience=EventManagementClient
    JwtSettings__AccessTokenExpirationMinutes=60
    JwtSettings__RefreshTokenExpirationDays=7
    ```

3.  **Build and Run with Docker Compose:**
    Use the following command to build and run the application in detached mode:
    ```bash
    docker-compose up -d --build
    ```

4.  **Accessing the applications:**
    -   **API**: `https://localhost:5001` or `http://localhost:5000`
    -   **Frontend**: `http://localhost:8080`

## Environment File (`.env`) Structure

The `.env` file is used to configure the application services.

### Database Configuration (`event-management.database` service)

-   `POSTGRES_DB`: The name of the database.
-   `POSTGRES_USER`: The username for the database.
-   `POSTGRES_PASSWORD`: The password for the database user.
-   `POSTGRES_HOST`: The hostname of the database server (used by the API service for connection).
-   `POSTGRES_PORT`: The port for the database server.

### API Configuration (`api` service)

-   `CONNECTION_STRING`: The full connection string for the PostgreSQL database.
-   `ASPNETCORE_URLS`: The URLs and ports the ASP.NET Core application will listen on within the container.
-   `ASPNETCORE_Kestrel__Certificates__Default__Password`: The password for your SSL certificate.
-   `ASPNETCORE_Kestrel__Certificates__Default__Path`: The path to your SSL certificate file (`.pfx`) inside the container. The `compose.yaml` file maps `~/.aspnet/https` on your host to `/https` in the container.

### JWT Authentication Settings (`api` service)

-   `JwtSettings__SecretKey`: A secret key for signing JWT tokens. This should be a long, random, and secure string.
-   `JwtSettings__Issuer`: The issuer of the JWT tokens (your API).
-   `JwtSettings__Audience`: The intended audience of the JWT tokens (your client application).
-   `JwtSettings__AccessTokenExpirationMinutes`: The lifetime of an access token in minutes.
-   `JwtSettings__RefreshTokenExpirationDays`: The lifetime of a refresh token in days.
