Northwind API

API REST desenvolvida em **ASP.NET Core Web API** para consulta de produtos do banco **Northwind**, utilizando **Dapper** para acesso a dados e **Swagger** para documentação e testes.

Este projeto tem como objetivo demonstrar boas práticas de arquitetura, organização de código e acesso a dados em aplicações .NET.

Tecnologias Utilizadas

- ASP.NET Core Web API
- .NET
- Dapper
- SQL Server (Northwind)
- Swagger (Swashbuckle)
- Injeção de Dependência (DI)

---

Estrutura do Projeto
NorthwindApi
│
├── Controllers
│ └── ProductsController.cs
│
├── Data
│ └── ProductsRepository.cs
│
├── Models
│ └── Product.cs
│
├── Properties
│ └── launchSettings.json
│
├── appsettings.json
├── Program.cs
└── NorthwindApi.csproj
Endpoints da API

Listar produtos (paginado)
GET /api/products?page=1&pageSize=10


**Parâmetros:**
- `page` (int) – Página atual (default: 1)
- `pageSize` (int) – Quantidade de registros por página (default: 10)

---

Buscar produto por ID
GET /api/products/{id}

**Exemplo:**
GET /api/products/1

Modelo de Dados (Product)

``json
{
  "productID": 1,
  "productName": "Chai",
  "unitPrice": 18.00,
  "unitsInStock": 39
}

Configuração do Banco de Dados

No arquivo appsettings.json, configure a connection string:

{
  "ConnectionStrings": {
    "Northwind": "Server=SEU_SERVIDOR\\SQLEXPRESS;Initial Catalog=NORTHWND;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}

Como Executar o Projeto
1 Restaurar dependências
dotnet restore

2 Executar a aplicação
dotnet run

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

Projeto desenvolvido para estudos e portfólio em .NET e Web API.

Evidências dos testes:

<img width="1910" height="1080" alt="{4DAC9C4C-3EFF-4EE9-BA58-E760F46D045A}" src="https://github.com/user-attachments/assets/514cff0c-c367-4278-b632-3f68330d7139" />
<img width="1822" height="966" alt="{FF033BA5-DCD1-4D7C-9C30-67EE5EB6AC3E}" src="https://github.com/user-attachments/assets/49fc185d-1619-4e9c-9a5b-101587a7d309" />



