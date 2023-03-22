# C# Fundamentals - Hello Worl

Program gives the basics of how to create a new console application and additional commands.

## Creating a basic console application in .NET 6 Core

```bash
dotnet new console --framework net6.0
```

.NET Core 6 introduced a new Program.cs file that simplifies
code written for main. If you want to revert to the previous programming
style

```bash
dotnet new console --use-program-main --framework net6.0
```

## To build debug version

```bash
dotnet build
```

## To build a release version

```bash
dotnet build --configuration Release
```

## Build and execute executable

```bash
dotnet run
```
