 <img align="left" width="116" height="116" src="https://i.imgur.com/id2VAPF.png" />
 
 # WorldDoomLeague
![.NET Core](https://github.com/jasontaylordev/CleanArchitecture/workflows/.NET%20Core/badge.svg)

<br/>

This is an Api + SPA front-end website for the World Doom League. This software follows the [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) software principle to separate business logic from infrastructure.


## Technologies
* .NET 5
* ASP.NET Core in .NET 5
* Entity Framework Core 5
* MediatR
* AutoMapper
* FluentValidation
* NUnit, FluentAssertions, Moq & Respawn
* MariaDb
* NSwag
* React

## Getting Started

Here is how to get the Api to compile locally:

1. Install the latest [.NET 5 SDK](https://dotnet.microsoft.com/download)
2. Navigate to `src/Api` and run `dotnet run` to launch the project

### Database Configuration

The site is configured to use an in-memory database by default. This ensures that all users will be able to run the solution without needing to set up additional infrastructure (e.g. SQL Server).

If you would like to use MariaDb, you will need to update **Api/appsettings.json** as follows:

```json
  "UseInMemoryDatabase": false,
```

Verify that the **DefaultConnection** connection string within **appsettings.json** points to a valid SQL Server instance. 

When you run the application the database will be automatically created (if necessary) and the latest migrations will be applied.

### Database Migrations

To use `dotnet-ef` for your migrations please add the following flags to your command (values assume you are executing from repository root)

- `--project src/Infrastructure` (optional if in this folder)
- `--startup-project src/WebUI`
- `--output-dir Persistence/Migrations`

For example, to add a new migration from the root folder:

 `dotnet ef migrations add "SampleMigration" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations`

# Overview of Api Design

The system is designed using principles from Clean Architecture and CQRS. As such, it uses MediatR to send a message from the controller to the Application layer and finally to the Infrastructure layer to interface externally with systems to get and manipulate required data. The Infrastructure layer then sends back either an error or the requested VM or DTO.

It uses AutoMapper when convenient, but most query viewmodels don't match the base entity, or need extended logic performed before finally resting in a DTO.


### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.


### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.


### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

### Api

This layer contains the REST controller based on ASP.NET Core 3.1. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only *Startup.cs* should reference Infrastructure.

## Support

If you are having problems, please let us know by [raising a new issue](https://github.com/bcahue/WorldDoomLeague.Api/issues/new/choose).

## License

This project is licensed with the [MIT license](LICENSE).
