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