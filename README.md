# JobsApi

Retrieve information about jobs with date range

## Installation

*You need those things to be installed:*<br>
1. .NET SDK - [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
2. MSSQL Server - [MSSQL Server® 2019 Express](https://www.microsoft.com/en-us/download/details.aspx?id=101064)

*Update appsettings.json with  your connection string*

sample: 

```console
  "ConnectionStrings": {
    "Sql": "Server=localhost\\SQLEXPRESS;Database=Jobs;Trusted_Connection=True;"
  },
```

*Run Migrations*

```console
dotnet-ef database update
```

or

run manually sql script `InitialMigrationWithData.sql` inside `Migrations` folder

## Build

```console
dotnet build
```

## Run

```console
dotnet run
```

## Swagger

[Swagger documentation](http://localhost:5032/swagger)
