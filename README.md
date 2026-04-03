# UMS

ASP.NET project (Controllers + Razor Views).

This repository contains an ASP.NET Core app (MVC controllers and Razor views) targeting .NET 10.

How to push to GitHub:

1. Initialize and commit locally:

```
cd UMS
git init
git add .
git commit -m "Initial commit - ASP.NET MVC project"
```

2a. Using GitHub CLI (`gh`):

```
gh repo create <OWNER>/<REPO-NAME> --public --source=. --remote=origin --push
```

2b. Or using web UI: create an empty repo, then:

```
git remote add origin https://github.com/<OWNER>/<REPO-NAME>.git
git branch -M main
git push -u origin main
```

Replace `<OWNER>` and `<REPO-NAME>` accordingly.
