#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV DATABASE_CONECTION="Server=192.168.0.3,1433;Database=master;User Id=sa;Password=Test1234;"

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DallApi.csproj", "DallApi/"]
RUN dotnet restore "DallApi/DallApi.csproj"

WORKDIR "/src/DallApi"
COPY . .
RUN dotnet build "DallApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DallApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "DallApi.dll"]