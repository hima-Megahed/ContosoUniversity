#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ContosoUniversity.Api/ContosoUniversity.Api.csproj", "ContosoUniversity.Api/"]
COPY ["ContosoUniversity.Persistence/ContosoUniversity.Persistence.csproj", "ContosoUniversity.Persistence/"]
COPY ["ContosoUniversity.Models/ContosoUniversity.Models.csproj", "ContosoUniversity.Models/"]
COPY ["ContosoUniversity.Application/ContosoUniversity.Application.csproj", "ContosoUniversity.Application/"]
COPY ["ContosoUniversity.Repositories/ContosoUniversity.Repositories.csproj", "ContosoUniversity.Repositories/"]
RUN dotnet restore "ContosoUniversity.Api/ContosoUniversity.Api.csproj"
COPY . .
WORKDIR "/src/ContosoUniversity.Api"
RUN dotnet build "ContosoUniversity.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContosoUniversity.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContosoUniversity.Api.dll"]
