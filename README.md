# Futuro do Trabalho API - Gerenciamento de Habilidades

Este projeto consiste em uma Web API desenvolvida em **ASP.NET Core 8** para o gerenciamento de habilidades (Skills Management), um tema central no "Futuro do Trabalho". A aplicação foi desenvolvida seguindo rigorosamente as boas práticas de API RESTful, versionamento e documentação, utilizando **Entity Framework Core** para persistência de dados.

## 1. Integrantes

*   Camila do Prado Padalino - RM98316
*   Gabriel Teixeira Machado - RM551570
*   Guilherme Brazioli - RM98237


## Funcionalidades (CRUD de Habilidades)

A API oferece um conjunto completo de operações CRUD (Create, Read, Update, Delete) para a entidade `Habilidade`.

| Verbo HTTP | Rota | Descrição | Status Codes de Sucesso |
| :--- | :--- | :--- | :--- |
| **GET** | `/api/v1/habilidades` | Lista todas as habilidades cadastradas. | 200 OK |
| **GET** | `/api/v1/habilidades/{id}` | Busca uma habilidade específica pelo ID. | 200 OK, 404 Not Found |
| **POST** | `/api/v1/habilidades` | Cria uma nova habilidade. | 201 Created, 400 Bad Request |
| **PUT** | `/api/v1/habilidades/{id}` | Atualiza uma habilidade existente. | 204 No Content, 400 Bad Request, 404 Not Found |
| **DELETE** | `/api/v1/habilidades/{id}` | Exclui uma habilidade. | 204 No Content, 404 Not Found |

**Modelo de Dados (`Habilidade`)**

| Campo | Tipo | Descrição |
| :--- | :--- | :--- |
| `Id` | `int` | Chave primária. |
| `Nome` | `string` | Nome da habilidade (ex: "Pensamento Crítico"). |
| `Descricao` | `string` | Descrição detalhada da habilidade. |
| `Tipo` | `string` | Classificação (ex: "Hard Skill" ou "Soft Skill"). |

## 4. Forma de Funcionamento (Como Rodar)

A aplicação utiliza o .NET 8 e pode ser executada em qualquer ambiente com o SDK instalado.

1.  **Pré-requisitos:**
    *   .NET SDK 8.0 ou superior.
2.  **Clonar o Repositório:**
    ```bash
    cd FuturoTrabalhoApi
    ```
3.  **Executar a Aplicação:**
    ```bash
    dotnet run
    ```
    A API será iniciada, geralmente na porta `https://localhost:7042` (verifique o console).
4.  **Acessar o Swagger:**
    Abra o navegador e acesse a URL do Swagger para testar os endpoints:
    `https://localhost:7042/swagger/index.html` (A porta pode variar).
