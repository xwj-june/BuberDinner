# Notes

## Using .NET CLI to init projects

### Create solution and projects

dotnet new sln -o BuberDinner

dotnet new webapi -o BuberDinner.Api

dotnet new classlib -o BuberDinner.Contracts

dotnet new classlib -o BuberDinner.Infrastructure

dotnet new classlib -o BuberDinner.Application

dotnet new classlib -o BuberDinner.Domain

### Add projects to solution

dotnet sln add (ls -r \*\*\*.csproj)

### Add project dependencies

dotnet add .\BuberDinner.Api\ reference .\BuberDinner.Contracts\ .\BuberDinner.Application\

dotnet add .\BuberDinner.Infrastructure\ reference .\BuberDinner.Application\

dotnet add .\BuberDinner.Application\ reference .\BuberDinner.Domain\

dotnet add .\BuberDinner.Api\ reference .\BuberDinner.Infrastructure\

### Run Api project

dotnet run --project .\BuberDinner.Api\

## Design decisions

### Different Flow Controls - Exception, OneOf, FluentResult

Using Exception is well adopted in the industry, however, it could be hard and complex when handling multi-level exceptions from different layers in the solution

Using OneOf package can improve problem above by returning the last result to the top layer. This result could be any types that defined within OneOf. But it has a constrain when handling multiple errors.

Using FluentResult package which encapsulates both the success and failure result together. Defining Errors with this package and utilizing the Result type for final outputs can easily improve the constrain from above. Handling Multiple errors is very straightforward.
