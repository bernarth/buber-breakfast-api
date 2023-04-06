# Buber Breakfast API

This project was created in this way:
```
dotnet new sln -o BuberBreakfast

cd .\BuberBreakfast\

dotnet new classlib -o BuberBreakfast.Contracts
dotnet new webapi -o BuberBreakfast

dotnet sln add .\BuberBreakfast.Contracts\ .\BuberBreakfast\
```

### This project is made in .NET 7

Add references
```
dotnet add .\BuberBreakfast\ reference .\BuberBreakfast.Contracts\
```

Build project
```
dotnet build
```

Run the project
```
dotnet run --project .\BuberBreakfast\
```

### Packages added

- `dotnet add .\BuberBreakfast\ package ErrorOr`