# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["coffee-service.csproj", "./"]
RUN dotnet restore "coffee-service.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "coffee-service.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "coffee-service.csproj" -c Release -o /app/publish

# Final stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5023
ENV ASPNETCORE_URLS=http://+:5023
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "coffee-service.dll"]

