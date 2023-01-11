# DIO - Modulo API

## Install

### EntityFramework Tools

```shell
dotnet tool install --global dotnet-ef
```

### Project Dependencies

```shell
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

### Migrations

```shell
dotnet-ef migrations add CriacaoTabelaContato
dotnet-ef database update
```
