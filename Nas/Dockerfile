FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY . .
ENV ASPNETCORE_ENVIRONMENT=Production
RUN chmod +x /app/entrypoint.sh
ENTRYPOINT ["/app/entrypoint.sh"]