# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy entire project folder into image (Render is case-sensitive!)
COPY ./PORTFOLIOWEBSITE ./PORTFOLIOWEBSITE

# Go into the working project folder
WORKDIR /src/PORTFOLIOWEBSITE

# Restore and publish
RUN dotnet restore
RUN dotnet publish -c Release -o /app/out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "PORTFOLIOWEBSITE.dll"]
