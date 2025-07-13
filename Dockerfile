# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy everything into container
COPY . ./

# Run restore and publish using the correct .csproj name
RUN dotnet restore "debabrata-portfolio.csproj"
RUN dotnet publish "debabrata-portfolio.csproj" -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "debabrata-portfolio.dll"]
