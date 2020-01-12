dotnet restore
dotnet build Chompies.Shared.sln --configuration Release
dotnet test Chompies.Shared.Tests/Chompies.Shared.Tests.csproj
dotnet publish Chompies.Shared.sln --configuration Release
copy Chompies.Shared\bin\Release\netstandard2.0\publish\*.dll ..\Player\Assets\Libraries
