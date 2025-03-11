# Calculadora Tabajara 2025 ACDP

## Introdução

Uma Calculadora de console simples, que permite armazenar as quatro operações matematicas.

## Funcionalidades

- **Operações Básicas**: Realize somas, subtrações, divisões e multiplicações.
- **Suporte a Decimais**: Trabalhes com numeros que tem até 3 casas decimais.
- **Validação de entrada**: A Calculadora garante que apenas a opções validas serão usadas.
- **Tratamento de divisão por zero**: 
- **Historico de operações**: 		
  O Sistema armazena um historico de até 100 calculos anteriores.
- Funcionalidade de Tabuada.

## Como ultilizar



1.  Clone o repositorio ou baixe o codigo fonte.
2.  Abra o Terminal ou prompt de Comando e navegue até a pasta raiz.
3.	Utilize o camando abaixo para restaurar as dependências do projeto.

 ```
 dotnet restore
 ```

 4. Compile a solução utilizando o comando:
 ```	
  dotnet build --configuration Release
 ```

 5.Para executar o projeto compilando em tempo real
  ```
   dotnet run --project Calculadora.ConsoleApp
  ```

  6. Para executar o arquivo compilado, navegue até a pasta ./Calculadora.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
    ```
    Calculdora.ConsoleApp.exe
    ```

## Demo

![](https://imgur.com/iYAt6vQ.gif)

# Requisitos

- **.NET SDK (recomendado .NET 8.) ou superior)**