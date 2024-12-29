FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app
COPY ./build ./
CMD ["dotnet", "MokaBot.dll"]
