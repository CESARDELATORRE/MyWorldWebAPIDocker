#Base Docker image to grab from Docker HUB and use
FROM microsoft/dotnet:1.0.0-preview2-sdk

ENV ASPNETCORE_URLS="http://*:81"
# (OPTIONAL) ENV ASPNETCORE_ENVIRONMENT="Development"

# Copy files to app directory
COPY . /app

# Set working directory
WORKDIR /app

#RUN dotnet restore

# Restore NuGet packages
RUN ["dotnet", "restore"]

# Build the .NET Core app
RUN ["dotnet", "build"]

# Open port exposed by Docker
EXPOSE 81/tcp

# Entrypoint
ENTRYPOINT ["dotnet", "run"]
# ENTRYPOINT ["dotnet", "WebApiMicroservice.dll"]
