FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Presentation/EstanteVirtual.Api/EstanteVirtual.Api.csproj", "src/Presentation/EstanteVirtual.Api/"]
RUN dotnet restore "src/Presentation/EstanteVirtual.Api/EstanteVirtual.Api.csproj"
COPY . .
WORKDIR "/src/src/Presentation/EstanteVirtual.Api"
RUN dotnet build "EstanteVirtual.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EstanteVirtual.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EstanteVirtual.Api.dll"]
