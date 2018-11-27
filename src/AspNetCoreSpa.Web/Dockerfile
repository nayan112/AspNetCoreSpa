FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
# Setup NodeJs
RUN apt-get update -qq && \
    apt-get install -qq -y wget && \
    apt-get install -qq -y gnupg2 && \
    wget -qO- https://deb.nodesource.com/setup_8.x | bash - && \
    apt-get install -qq -y build-essential nodejs && \
    apt-get install -qq -y nginx
# End setup

WORKDIR /app

EXPOSE 5050

FROM microsoft/dotnet:2.1-sdk AS build
# Setup NodeJs
RUN apt-get update -qq && \
    apt-get install -qq -y wget && \
    apt-get install -qq -y gnupg2 && \
    wget -qO- https://deb.nodesource.com/setup_8.x | bash - && \
    apt-get install -qq -y build-essential nodejs && \
    apt-get install -qq -y nginx
# End setup

WORKDIR /src
COPY ["src/MyCommunity.Web/MyCommunity.Web.csproj", "src/MyCommunity.Web/"]
COPY ["src/AspNetCoreSpa.Core/AspNetCoreSpa.Core.csproj", "src/AspNetCoreSpa.Core/"]
COPY ["src/AspNetCoreSpa.Infrastructure/AspNetCoreSpa.Infrastructure.csproj", "src/AspNetCoreSpa.Infrastructure/"]
RUN dotnet restore "src/MyCommunity.Web/MyCommunity.Web.csproj"
COPY ["src/MyCommunity.Web/ClientApp/package.json", "src/MyCommunity.Web/ClientApp/"]

RUN cd src/MyCommunity.Web/ClientApp \
    && npm i --silent

COPY . .
WORKDIR "/src/src/MyCommunity.Web"
RUN dotnet build "MyCommunity.Web.csproj" -c Release -o /app

FROM build AS publish

RUN dotnet publish "MyCommunity.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyCommunity.Web.dll"]
