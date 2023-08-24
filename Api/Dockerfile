FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["url-shortener-with-redis-bloom-filter/url-shortener-with-redis-bloom-filter.csproj", "url-shortener-with-redis-bloom-filter/"]
RUN dotnet restore "url-shortener-with-redis-bloom-filter/url-shortener-with-redis-bloom-filter.csproj"
COPY . .
WORKDIR "/src/url-shortener-with-redis-bloom-filter"
RUN dotnet build "url-shortener-with-redis-bloom-filter.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "url-shortener-with-redis-bloom-filter.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "url-shortener-with-redis-bloom-filter.dll"]
