# PackMan

> Learning to Create a CLI app that checks if the installed version is the latest available version.

This project uses [GitHub Packages](https://github.com/features/packages).

## Create the NuGet Config

```powershell
# First, Create the nuget.config file (make sure it's ignored in your .gitignore settings)
dotnet new nugetconfig
# Next, add the source for accessing your package
dotnet nuget add source https://nuget.pkg.github.com/username/index.json -n "github"
# Build your solution
dotnet build --configuration Release
# Generate your package
dotnet pack --configuration Release
# Publish your package
dotnet nuget push "PackMan/bin/Release/PackMan.1.0.0.nupkg" --source "github"
```
