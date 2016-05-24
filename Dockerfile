FROM microsoft/dotnet


RUN useradd -d /hwapp -m app

USER app
COPY . /hwapp
WORKDIR /hwapp
RUN dotnet restore
CMD ["dotnet", "run"]

