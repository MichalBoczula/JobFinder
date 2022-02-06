#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["JobsCatalogApi/JobsCatalogApi/JobsCatalogApi.csproj", "JobsCatalogApi/JobsCatalogApi/"]
COPY ["JobsCatalog.Persistance/JobsCatalog.Persistance/JobsCatalog.Persistance.csproj", "JobsCatalog.Persistance/JobsCatalog.Persistance/"]
COPY ["JobsCataologDomain/JobsCataologDomain/JobsCatalog.Domain.csproj", "JobsCataologDomain/JobsCataologDomain/"]
COPY ["JobsCatalog.Application/JobsCatalog.Application/JobsCatalog.Application.csproj", "JobsCatalog.Application/JobsCatalog.Application/"]
RUN dotnet restore "JobsCatalogApi/JobsCatalogApi/JobsCatalogApi.csproj"
COPY . .
WORKDIR "/src/JobsCatalogApi/JobsCatalogApi"
RUN dotnet build "JobsCatalogApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JobsCatalogApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JobsCatalogApi.dll"]