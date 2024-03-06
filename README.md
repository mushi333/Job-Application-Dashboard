# Job Application Dashboard

### Written in .NET MVC

This job application dashboard was made to keep track of my job applications in 2024. The application runs locally on my laptop.

A live demo can be seen [here](https://job-application-dashboard.fly.dev/). The data gets reset everyday.

## Tech Stack

Written in:

- C#
- .NET MVC
- PicoCSS
- SQLite

## Installation

To run this application:

- Make sure .NET 8 is installed, the install link can be found here - https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Run the following commands to install the necessary .NET packages:

```
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

- Create/Update the database using this command:

```
dotnet ef database update
```

- Run the dashboard using this command:

```
dotnet run --urls http://localhost:5000
```

- Open the following url - http://localhost:5000/
