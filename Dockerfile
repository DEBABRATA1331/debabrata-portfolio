# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy project files
COPY PORTFOLIOWEBSITE/*.csproj ./PORTFOLIOWEBSITE/
COPY PORTFOLIOWEBSITE/. ./PORTFOLIOWEBSITE/

# Restore and publish
WORKDIR /src/PORTFOLIOWEBSITE
RUN dotnet restore
RUN dotnet publish -c Release -o /app/out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "PORTFOLIOWEBSITE.dll"]
