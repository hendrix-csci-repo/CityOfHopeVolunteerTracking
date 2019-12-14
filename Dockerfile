# This is the base image which determines from which Docker image the container should derive.
FROM microsoft/dotnet:latest
FROM mcr.microsoft.com/dotnet/core/sdk
# Copy the files and folders from current directory to "app" directory
COPY . /app
 
# Set the working directory as "app" directory
WORKDIR /app
 
# Run the following commands in Linux Terminal to restore .NET Core packages
CMD "dotnet restore && dotnet build"
 
# Expose a port number from the container to outside world
EXPOSE 5000
EXPOSE 5001

 
# Determine an entry point of the application.
ENTRYPOINT ["dotnet", "run" ]