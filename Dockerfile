FROM microsoft/dotnet

COPY . /hwapp
WORKDIR /hwapp
RUN ["dotnet", "restore"]

#EXPOSE 5000

CMD ["dotnet", "run"]

