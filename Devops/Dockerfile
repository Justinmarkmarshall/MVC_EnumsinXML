FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine

COPY /PublishOutput /app/

WORKDIR /app/

USER 1000

ENV IS_CONTAINERIZED=true

ENTRYPOINT ["dotnet", "SerializationDemo.dll"]