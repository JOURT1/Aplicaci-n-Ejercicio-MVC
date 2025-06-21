# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar archivos del proyecto
COPY *.csproj ./
RUN dotnet restore

# Copiar el resto y publicar
COPY . ./
RUN dotnet publish -c Release -o out

# Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "MiniCoreComisiones.dll"]
