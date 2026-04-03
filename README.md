# UMS

ASP.NET Core MVC project (Controllers + Razor Views) targeting .NET 10.

Prerequisites
- .NET 10 SDK installed: https://dotnet.microsoft.com/
- MySQL server available (local or remote) or use Docker

Clone

```
git clone https://github.com/aamadan/UMS.git
cd UMS
```

Configure database
- Edit `appsettings.json` and set `ConnectionStrings:DefaultConnection` to your MySQL connection string. Example:

```
"ConnectionStrings": {
  "DefaultConnection": "server=127.0.0.1;database=cs14;user=root;password=1234;"
}
```
Apply database migrations

The project uses Entity Framework Core migrations. From the `UMS` folder run:

1. (Optional) Install the EF CLI if not present:

```
dotnet tool install --global dotnet-ef --version 9.*
```

2. Create/update the database:

```
dotnet ef database update
```

Run the app

```
dotnet restore
dotnet run
```

Open browser:
- Users list: `https://localhost:5001/users/getusers`
- Employees list: `https://localhost:5001/employees/getemployees`

Notes
- On first run the app will attempt to apply migrations and seed an initial user (`username: admin`).
- If you change the DB connection, re-run `dotnet ef database update`.
- For production deployment, secure connection strings and use migrations in your CI/CD.

If you want, provide a GitHub repo name and I can show commands to push this repo to GitHub.
