# -------- BUILD STAGE --------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# copy csproj from project folder
COPY HelloDevOpsApi/*.csproj ./HelloDevOpsApi/
RUN dotnet restore HelloDevOpsApi/HelloDevOpsApi.csproj

# copy everything else
COPY HelloDevOpsApi/. ./HelloDevOpsApi/
WORKDIR /app/HelloDevOpsApi

RUN dotnet publish -c Release -o /out

# -------- RUNTIME STAGE --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /out ./
EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "HelloDevOpsApi.dll"]
