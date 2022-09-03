FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Net7MemoryUsage.Console/Net7MemoryUsage.Console.csproj", "Net7MemoryUsage.Console/"]
RUN dotnet restore "Net7MemoryUsage.Console/Net7MemoryUsage.Console.csproj"
COPY . .
WORKDIR "/src/Net7MemoryUsage.Console"
RUN dotnet build "Net7MemoryUsage.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Net7MemoryUsage.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Net7MemoryUsage.Console.dll"]
