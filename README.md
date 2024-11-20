Integrantes: Alissa Silva Cezero - RM552535, Melissa Barbosa de Souza - RM552535, Nicolas Paiffer do Carmo - RM554145
---
# **GoCycle API**

Uma aplicação **.NET Web API** desenvolvida para gerenciar usuários e dados relacionados ao sistema **GoCycle**. Um aplicativo que promove a utilização de bicicletas e afins para locomoção, algo como alugar e preservar o meio ambiente, recebendo pontos acumulaveis em estabelecimentos parceiros. Este projeto utiliza o **Entity Framework Core** para interagir com um banco de dados Oracle, incluindo o uso de repositórios, validações com Data Annotations e documentação interativa via Swagger.

---

## **Tecnologias Utilizadas**

- **.NET 8.0**
- **Entity Framework Core**
- **Oracle Database**
- **Swagger (Swashbuckle.AspNetCore)**

---

## **Configuração do Ambiente**

1. **Pré-requisitos**
   - **.NET SDK 8.0+**
   - **Oracle Database**
   - **Ferramenta de migração do EF Core**
   - **Visual Studio Code** ou IDE de sua escolha

2. **Configurar a String de Conexão**
   No arquivo `appsettings.json`, insira as informações do banco de dados Oracle:
   ```json
   {
       "ConnectionStrings": {
           "OracleConnection": "User Id=<usuario>;Password=<senha>;Data Source=<host>"
       }
   }

Restaurar Dependências No terminal, execute: dotnet restore

Aplicar Migrações Crie o banco de dados com base nas entidades: dotnet ef database update

Executar o Projeto Execute o projeto com: dotnet run

http://localhost:5208/swagger
