# busca imagem
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build 
WORKDIR /app

# copiar projeto e restaurar depedencias
COPY *.csproj ./
RUN dotnet restore

# carrega aplica��o
COPY . ./
RUN dotnet publish -c Release -o out

# carrega imagem
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "progress-manager.dll" ]