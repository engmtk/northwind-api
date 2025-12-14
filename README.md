# Northwind API

API REST desenvolvida em **ASP.NET Core Web API** para consulta de produtos do banco **Northwind**, utilizando **Dapper** para acesso a dados e **Swagger** para documentação e testes.

Este projeto tem como objetivo demonstrar boas práticas de arquitetura, organização de código e acesso a dados em aplicações .NET.

---

## 🚀 Tecnologias Utilizadas

- ASP.NET Core Web API
- .NET
- Dapper
- SQL Server (Northwind)
- Swagger (Swashbuckle)
- Injeção de Dependência (DI)

---

## 📁 Estrutura do Projeto

Claro, vamos criar um README.md bem profissional para o seu projeto. Eu vou te fornecer um modelo claro, com os detalhes certos para o GitHub. Esse modelo pode ser copiado e colado diretamente no seu repositório.

README.md para o Repositório Northwind API
# Northwind API

Esta é uma API RESTful construída utilizando **ASP.NET Core Web API**, **Dapper** para acesso a dados e **Swagger** para documentação e testes. O banco de dados utilizado é o **Northwind**, um banco de dados de exemplo comum no mundo do SQL Server.

---

## 🚀 Tecnologias Utilizadas

- **.NET (ASP.NET Core Web API)**
- **Dapper**
- **SQL Server (Northwind)**
- **Swagger (Swashbuckle)**
- **Injeção de Dependência (DI)**

---

## 📁 Estrutura do Projeto



NorthwindApi
│
├── Controllers
│ └── ProductsController.cs # Controlador para manipulação dos produtos
│
├── Data
│ └── ProductsRepository.cs # Repositório para consultas e operações com o banco de dados
│
├── Models
│ └── Product.cs # Modelo para representar os dados dos produtos
│
├── Properties
│ └── launchSettings.json # Configurações de inicialização do projeto
│
├── appsettings.json # Configurações de conexão com o banco de dados
├── Program.cs # Configuração da aplicação (DI, Swagger, etc)
└── NorthwindApi.csproj # Arquivo de projeto .NET


---

## 🔗 Endpoints Disponíveis

### 🔹 Listar produtos (paginado)
**GET /api/products?page=1&pageSize=10**


**Parâmetros:**
- `page` (int) – Página atual (default: 1)
- `pageSize` (int) – Quantidade de registros por página (default: 10)

---

### 🔹 Buscar produto por ID
GET /api/products/{id}

**Exemplo:**
GET /api/products/1


---

## 📦 Modelo de Dados (Product)

json
{
  "productID": 1,
  "productName": "Chai",
  "unitPrice": 18.00,
  "unitsInStock": 39
}

⚙️ Configuração do Banco de Dados

No arquivo appsettings.json, configure a connection string:

{
  "ConnectionStrings": {
    "Northwind": "Server=SEU_SERVIDOR\\SQLEXPRESS;Initial Catalog=NORTHWND;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
 Como Executar o Projeto
 Restaurar dependências

COMANDO> dotnet restore

Executar a aplicação
COMANDO> dotnet run

Swagger

Após iniciar o projeto, acesse:

http://localhost:5000/swagger

O Swagger permite:

Visualizar os endpoints

Executar requisições

Ver exemplos de resposta

Boas Práticas Aplicadas

Separação de responsabilidades (Controller / Repository / Model)

Uso de Dapper para acesso performático ao banco

Injeção de Dependência

Métodos assíncronos (async/await)

Paginação com validação

DTO tipado

Próximas Evoluções

Filtros por categoria e fornecedor

Paginação com metadados

Tratamento global de erros

Autenticação (JWT)

Testes unitários

Alexandre Santos
Projeto desenvolvido para estudos e portfólio em .NET e Web API.

Evidências da execução:

<img width="1912" height="1080" alt="{B5D97564-A6CE-41E6-AB92-78F0B415F04F}" src="https://github.com/user-attachments/assets/8d180f60-45db-4ef1-acd4-1a38200c51f2" />
<img width="1914" height="1080" alt="{900E3D19-70D7-42DE-A91A-D3897EAA5151}" src="https://github.com/user-attachments/assets/0f4a14e8-25ca-460f-8a0c-e67885d297ee" />

