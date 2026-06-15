# API de Gestión de Clientes y Mensajes

Esta es una API REST profesional desarrollada en C# con .NET 8 utilizando Entity Framework Core para realizar operaciones CRUD completas y gestionar relaciones entre tablas.

## Tecnologías Utilizadas
* **Lenguaje:** C# (.NET 8)
* **Framework Web:** ASP.NET Core Web API
* **ORM:** Entity Framework Core
* **Base de Datos:** SQL Server

## Pasos para la ejecución local
1. Clonar el repositorio: `git clone https://github.com/melmokimk-boop/gestion-clientes-api.git`
2. Configurar la cadena de conexión en `appsettings.json`.
3. Ejecutar migraciones: `dotnet ef database update`
4. Iniciar la API: `dotnet run`

## Endpoints Principales (`Clientes`)
* **GET** `/api/clientes` - Obtiene todos los clientes.
* **GET** `/api/clientes/{id}` - Obtiene un cliente por ID.
* **POST** `/api/clientes` - Crea un cliente.
* **PUT** `/api/clientes/{id}` - Modifica un cliente.
* **DELETE** `/api/clientes/{id}` - Elimina un cliente.