# VencerAlert-API

[![licence mit](https://img.shields.io/badge/licence-MIT-blue.svg)](https://github.com/louresb/CryptographyAPI/blob/main/LICENSE)
![Development Status Badge](https://img.shields.io/badge/Status-Development-yellow)

<p>Projeto desenvolvido com o intuito de cadastrar produtos próximos ao vencimento utilizando Clean Archtecture e para persistência dos dados foi utilizado o banco de dados SQLite, mapeamento de dados com Fluent e como ORM Entity Framework Core.</p>

## Tecnologias utilizadas

- C#/Asp.net 6.0
- Entity Framework
- Sqlite
- Swagger

## Operações

<p>Operações básicas (CRUD) para a classe produtos.</p>

## Dependências

- VencerAlert.Infrastructure
  - Microsoft.EntityFrameworkCore 6.0.30
  - Microsoft.EntityFrameworkCore.Design 6.0.30
  - Microsoft.EntityFrameworkCore.Sqlite 6.0.30

## Rotas

| Método HTTP | Rota               |
| ----------- | ------------------ |
| GET         | /api/Products      |
| POST        | /api/Products      |
| PUT         | /api/Products      |
| DELETE      | /api/Products      |
| GET         | /api/Products/{id} |

## Estrutura do Projeto

src
├── VencerAlert.API
├── VencerAlert.Application
├── VencerAlert.CrossCutting
├── VencerAlert.Domain
├── VencerAlert.Infrastructure

## Instalação

1. Clone o repositório:

```powershell

git clone https://github.com/Leonnardo21/VencerAlert-API

```

2. Navegue até a pasta do projeto:

```powershell

cd VencerAlertAPI

```

3. Antes de rodar o projeto instale as dependências:

```powershell

dotnet restore

```

4. Construa o projeto:

```powershell

dotnet build

```

5. Rode:

```powershell

dotnet run

```
