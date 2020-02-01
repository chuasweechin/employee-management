FROM mcr.microsoft.com/dotnet/core/sdk:2.2.402-alpine3.9

# setup app
RUN mkdir /usr/src && mkdir /usr/src/app

# Create app directory
WORKDIR /usr/src/app

COPY ./ ./

RUN dotnet build

EXPOSE 5000
EXPOSE 5001

CMD [ "dotnet", "run" ]