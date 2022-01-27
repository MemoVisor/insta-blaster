# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY InstaBlaster/InstaBlaster.csproj /src/InstaBlaster/
RUN dotnet restore "InstaBlaster/InstaBlaster.csproj"
COPY . .
WORKDIR /src/InstaBlaster
RUN dotnet build "InstaBlaster.csproj" -c Debug -o /app

FROM build AS publish
RUN dotnet publish "InstaBlaster.csproj" -c Debug -o /app

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as insta-blaster
EXPOSE 80
WORKDIR /app
ARG APP_ENV
ENV TERM=xterm \
    ASPNETCORE_ENVIRONMENT=${APP_ENV:-Development} \
    ASPNETCORE_URLS=http://+:5000 \
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Install base packages
RUN apt-get update \
    && apt-get install -y nginx curl vim wget gnupg procps libgdiplus

# Install s6 overlay.
RUN cd /tmp/ \
    && curl -OL https://github.com/just-containers/s6-overlay/releases/download/v1.21.7.0/s6-overlay-amd64.tar.gz \
    && tar xzf /tmp/s6-overlay-amd64.tar.gz -C / \
    && rm -rf /tmp/*

# Copy config files
COPY ci/docker/rootfs /

# Copy builded app from builder.
COPY --from=publish /app .
WORKDIR /app
RUN useradd -s /bin/false nginx
ENTRYPOINT ["/init"]