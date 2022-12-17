# Get base SDKImge from Microsoft 
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /source


#copy the csproj file and restore any dependecies (via nuget)

COPY ResurantReactpro/ResurantReactpro.csproj /source/
RUN dotnet restore


# copy the project file and build ou release 
COPY . ./
RUN dotnet publish -c Release -o out ResurantReactpro/ResurantReactpro.csproj


#Generate run time  image
FROM mcr.microsoft.com/dotnet/sdk:5.0 
WORKDIR /app
COPY --from=build /source/ .
ENTRYPOINT ["dotnet","ResurantReactpro.dll"]


