FROM microsoft/aspnetcore
WORKDIR /net    
EXPOSE 80
COPY . /net
CMD ["dotnet", "netDemo.dll"]