#Parte de build/construção inicia aqui:

#Cria a máquina virtual e prepara o dotnet para execução do programa
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

#Crio e defino o meu arquivo de trabaho dentro da imagem
WORKDIR /src

#Carregando as dependencias na imagem
#Ganho de performance depois da primeira execução
COPY src/*.csproj .
RUN dotnet restore --use-current-runtime

#Copio da pasta src que está na minha máquina para dentro da imagem
COPY src .

#Compila a aplicação dentro da imagem
#Salva a aplicação compilada no /publish
RUN dotnet publish my-api.sln -c Release -o /publish


#Parte de execução inicia aqui:
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /publish
#Busca as informações do /publish para executar na imagem
COPY --from=build-env /publish .
EXPOSE 80
ENTRYPOINT [ "dotnet", "my-api.ddl" ]