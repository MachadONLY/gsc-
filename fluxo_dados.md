## Diagrama de Fluxo de Dados (Draw.io)

O diagrama abaixo representa o fluxo de dados da aplicação, desde a requisição do cliente até a persistência no banco de dados.

```mermaid
graph TD
    A[Cliente/Postman] --> B(Requisição HTTP: GET/POST/PUT/DELETE);
    B --> C{API Gateway / Controller};
    C --> D[Controller: HabilidadesController];
    D --> E(Serviço/Contexto: AppDbContext);
    E --> F[Persistência de Dados: EF Core];
    F --> G[Banco de Dados: In-Memory / SQL Server];
    G --> F;
    F --> E;
    E --> D;
    D --> H(Resposta HTTP: JSON);
    H --> A;

    subgraph API Futuro do Trabalho
        C
        D
        E
        F
    end

    style A fill:#f9f,stroke:#333,stroke-width:2px
    style G fill:#ccf,stroke:#333,stroke-width:2px
    style H fill:#9f9,stroke:#333,stroke-width:2px
```

**Instrução para o Aluno:** Você pode usar o código Mermaid acima em ferramentas que o suportam (como o GitHub) ou, para atender ao requisito do professor, desenhar o fluxo no [Draw.io](https://app.diagrams.net/) e salvar a imagem no repositório.
