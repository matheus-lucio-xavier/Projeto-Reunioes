# Projeto Reuniões – Sistema de Reservas de Salas

Projeto final da matéria **Plataforma de Desenvolvimento de Sistemas**.
Aplicação desktop para cadastrar salas de reunião e gerenciar as reservas, impedindo conflitos de horário na mesma sala.

## Funcionalidades

- Cadastro, edição e listagem de **salas** (nome, andar, quantidade de assentos)
- Cadastro, edição e listagem de **reservas** (nome, início, fim, sala, status ativa/cancelada)
- Busca por nome e paginação nas consultas
- Validação de dados e **verificação de colisão de horários** por sala

## Tecnologias

| Camada | Tecnologia |
|---|---|
| Linguagem / Plataforma | C# com .NET 10 |
| Interface | Windows Forms (`net10.0-windows`) |
| Acesso a dados | Entity Framework Core 10 |
| Banco de dados | PostgreSQL (driver `Npgsql.EntityFrameworkCore.PostgreSQL`) |
| Validação | Data Annotations (`System.ComponentModel.DataAnnotations`) |

## Estrutura

```
sql/                              Script de criação do banco (BancoDados.sql)
SistemaReservas/
├── SistemaReservas/              Biblioteca (núcleo)
│   ├── Models/  Enums/  Dto/     Entidades, enums e DTOs
│   ├── Contexts/                 AppDbContext (EF Core)
│   ├── Repositories/             Repositório genérico
│   └── Services/                 Regras de negócio (Sala e Reserva)
└── SistemaReservas.Desktop/      Aplicação Windows Forms
    └── Screens/                  Telas de cadastro e gerenciamento
```

## Como executar

1. Instale o **.NET 10 SDK** (Windows) e o **PostgreSQL**.
2. Crie o banco `SistemaReservas` e execute o script `sql/BancoDados.sql`.
3. Ajuste a string de conexão em `Contexts/AppDbContext.cs` (host, porta, usuário e senha).
4. Execute:
   ```bash
   dotnet run --project SistemaReservas/SistemaReservas.Desktop
   ```
   ou abra `SistemaReservas.slnx` no Visual Studio e rode o projeto *Desktop*.
