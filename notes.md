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
