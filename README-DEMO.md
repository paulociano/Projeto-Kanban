# Projeto Kanban - Demo portátil

Esta branch prepara o projeto original para uma demonstração local sem SQL Server.

## Como funciona

- Banco em memória com Entity Framework Core InMemory.
- Conta demo criada automaticamente.
- Servidor local fixo em `http://localhost:5050`.
- Ao iniciar o executável, o navegador é aberto automaticamente.
- Nenhum dado da demonstração é persistido após encerrar o aplicativo.

## Login

- Usuário: `demo@kanban.local`
- Senha: `demo123`

## Gerar o executável para Windows

Na raiz do projeto:

```powershell
dotnet publish ProjetoKanban.csproj -c Release -r win-x64 --self-contained true -o publish
```

Depois execute:

```text
publish\ProjetoKanban.exe
```

A pasta `publish` inteira deve acompanhar o executável.

## Voltar ao SQL Server

No `appsettings.json`, altere:

```json
"DemoMode": false
```

A aplicação volta a utilizar a connection string `DefaultConnection`.

## Observação

O projeto continua em .NET 5 para preservar compatibilidade com o código original. Como .NET 5 está fora de suporte, uma modernização posterior para uma versão LTS atual é recomendada.
