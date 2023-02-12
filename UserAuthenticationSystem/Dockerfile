FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UserAuthenticationSystem/UserAuthenticationSystem.csproj", "UserAuthenticationSystem/"]
RUN dotnet restore "UserAuthenticationSystem/UserAuthenticationSystem.csproj"
COPY . .
WORKDIR "/src/UserAuthenticationSystem"
RUN dotnet build "UserAuthenticationSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UserAuthenticationSystem.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserAuthenticationSystem.dll"]
