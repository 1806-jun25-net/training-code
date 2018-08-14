# FROM microsoft/dotnet:2.1-sdk

# #WORKDIR will create the directory if it didn't already exist
# WORKDIR /app

# #copies current dir contents (Project1/*)
# #into current dir in Docker (/app)
# COPY *.sln ./

# RUN dotnet restore

# RUN dotnet build

# WORKDIR /app/Project1.MVC

# ENV ASPNETCORE_URLS http://*:5000

# CMD [ "dotnet", "run" ]

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Project1.UI/*.csproj ./Project1.UI/
COPY Project1.ContextLibrary/*.csproj ./Project1.ContextLibrary/
COPY Project1.Database/*.csproj ./Project1.Database/
COPY Project1.Library/*.csproj ./Project1.Library/
COPY Project1.MVC/*.csproj ./Project1.MVC/
COPY Project1.Test/*.csproj ./Project1.Test/

RUN dotnet restore

# copy everything else and build app
COPY . ./
WORKDIR /app/Project1.MVC
RUN dotnet publish -c Release -o out

# runtime stage
FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/Project1.MVC/out ./
ENTRYPOINT ["dotnet", "Project1.MVC.dll"]