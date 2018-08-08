FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY RestaurantReviews.ConsoleApp/*.csproj ./RestaurantReviews.ConsoleApp/
COPY RestaurantReviews.Context/*.csproj ./RestaurantReviews.Context/
COPY RestaurantReviews.Library/*.csproj ./RestaurantReviews.Library/
COPY RestaurantReviews.Testing/*.csproj ./RestaurantReviews.Testing/
COPY RestaurantReviews.WebApp/*.csproj ./RestaurantReviews.WebApp/
RUN dotnet restore

# copy everything else and build app
COPY . ./
WORKDIR /app/RestaurantReviews.WebApp
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/RestaurantReviews.WebApp/out ./
ENTRYPOINT ["dotnet", "RestaurantReviews.WebApp.dll"]
