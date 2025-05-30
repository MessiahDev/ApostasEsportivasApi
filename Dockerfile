FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ApostasEsportivasApi/*.csproj ./ApostasEsportivasApi/
RUN dotnet restore ./ApostasEsportivasApi/ApostasEsportivasApi.csproj

COPY . .

RUN dotnet publish ./ApostasEsportivasApi/ApostasEsportivasApi.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "ApostasEsportivasApi.dll"]