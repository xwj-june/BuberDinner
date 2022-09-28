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

## CQRS & MediatR

CQRS stands for Command Query Responsibility Segregation. It is a design pattern to separate out operations for read/write data by splitting the processing logic into Command/Query process.

A downside of using basic CQRS pattern is that each service only processes a particular Command/Query request, which will generate many services.

MediatR package can help out the constrain above by encapsulating Command and Query to another layer. It can be set up by implementing command/query handles with IRequestHandler interface. So all need to be done is pass the Command/Query request to MediatoR who will understand the command/query and process it to return wanted result.
