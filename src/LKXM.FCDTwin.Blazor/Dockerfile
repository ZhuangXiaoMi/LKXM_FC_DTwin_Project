#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["LKXM.FCDTwin.Blazor/LKXM.FCDTwin.Blazor.csproj", "LKXM.FCDTwin.Blazor/"]
RUN dotnet restore "LKXM.FCDTwin.Blazor/LKXM.FCDTwin.Blazor.csproj"
COPY . .
WORKDIR "/src/LKXM.FCDTwin.Blazor"
RUN dotnet build "LKXM.FCDTwin.Blazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LKXM.FCDTwin.Blazor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LKXM.FCDTwin.Blazor.dll"]