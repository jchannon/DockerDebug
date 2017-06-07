FROM microsoft/dotnet:1.1-runtime-deps

RUN apt-get update

RUN apt-get install curl unzip

RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l ~/vsdbg

COPY ./publish /app

WORKDIR /app

ENTRYPOINT ./jsonfile
