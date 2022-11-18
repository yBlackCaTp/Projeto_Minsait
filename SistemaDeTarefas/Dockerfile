#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR ./app
EXPOSE 80

COPY *.csproj ./
RUN dotnet restore

COPY ../ ./
RUN dotnet publish "SistemaDeTarefas.csproj" -c Release -o /app/out /p:UseAppHost=false
#RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR ./app
COPY --from=base /app/out .

ENTRYPOINT ["dotnet", "SistemaDeTarefas.dll"]
