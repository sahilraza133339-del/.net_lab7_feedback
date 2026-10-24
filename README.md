# Feedback Management Module (ASP.NET Core MVC)

This project is based on the Experiment 7 PDF: **Feedback Management Module using MVC Layout, Partial View & Validation**.

## Features
- MVC model, controller, and Razor views
- Feedback form with name, email, rating, and comments
- Data annotation validation
- Dashboard with submission count, average rating, response rate, and recent feedback
- Bootstrap layout and Bootstrap Icons

## Requirements
- .NET 8 SDK
- Visual Studio 2022 or Visual Studio Code

## Run locally
Open a terminal in this folder and run:

```bash
dotnet restore
dotnet run
```

Open the localhost URL printed in the terminal.

## GitHub upload
Create a new empty repository on GitHub. Then run these commands in this project folder:

```bash
git init
git add .
git commit -m "Add Feedback Management MVC project"
git branch -M main
git remote add origin https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
git push -u origin main
```

Replace the remote URL with your own GitHub repository URL.

## Note
The supplied PDF contains the model and two views, but does not show the controller or application startup code. Those files have been added so the project has a complete MVC structure. This sample stores submissions in memory, so new feedback is lost when the application restarts. Bootstrap and validation scripts are loaded from CDNs.
