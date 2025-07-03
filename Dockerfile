FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TrainingWebsite/TrainingWebsite.csproj", "TrainingWebsite/"]
COPY ["Shared/Shared.csproj", "Shared/"]
RUN dotnet restore "TrainingWebsite/TrainingWebsite.csproj"
COPY . .
WORKDIR "/src/TrainingWebsite"
RUN dotnet build "TrainingWebsite.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "TrainingWebsite.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrainingWebsite.dll"]