FROM microsoft/aspnetcore:2.0
ARG source
WORKDIR /app
EXPOSE 80
COPY ./simple-core-ngular/bin/Debug/netcoreapp2.0/publish .
ENTRYPOINT ["dotnet", "simple-core-ngular.dll"]
