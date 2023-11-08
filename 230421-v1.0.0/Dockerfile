FROM mcr.microsoft.com/dotnet/sdk:6.0
LABEL maintainer="SAMATE, NIST"
WORKDIR /sard
RUN apt-get update && apt-get install -y --no-install-recommends make
COPY . .
