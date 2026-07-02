FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY Tools/ModelFinder/ModelFinder.csproj Tools/ModelFinder/
RUN dotnet restore Tools/ModelFinder/ModelFinder.csproj

COPY . .
RUN dotnet publish Tools/ModelFinder/ModelFinder.csproj -c Release -o /out --no-restore

FROM mcr.microsoft.com/dotnet/runtime:10.0
WORKDIR /app

COPY --from=build /out ./
COPY --from=build /src/Entities ./Entities
COPY --from=build /src/DTO ./DTO

ENV MODEL_FINDER_ROOT=/app
ENV PORT=10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "ModelFinder.dll"]
