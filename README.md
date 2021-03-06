## Acerca del proyecto

Web API para consulta de pokemons.

### Elaborado con

-   [ASP.NET Core 5.0 MVC](https://dotnet.microsoft.com/learn/aspnet/what-is-aspnet-core)
-   ASP.NET Core 5.0 WebAPI
-   [Entity Framework Core 5.0](https://docs.microsoft.com/en-us/ef/core/)
-   OpenAPI (Swagger)
-   Base de datos SQL Server, utilizando EntityFramework

### Prerequisitos

-   Asegurese de tener el ultimo .NET 5 SDK (SDK 5.0 and above only). [Obtener aqui.](https://dotnet.microsoft.com/download/dotnet/5.0)

-   Visual Studio 2019 (v16.8+) 

-   Instalar el ultimo [.NET & EF CLI Tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) puede usar este comando :

    ```.NET Core CLI
    dotnet tool install --global dotnet-ef
    ```
-   Crear la base de datos

    ```
    CREATE DATABASE dbpokedex
    ```
-   Crear usuario para conexion

    ```
    CREATE LOGIN AdminPokedex WITH PASSWORD = 'StKRV6MR6A'
    GO
    USE dbpokedex
    GO
    CREATE USER AdminPokedex FOR LOGIN AdminPokedex;
    ALTER ROLE db_owner ADD MEMBER AdminPokedex;
    ```
-   Ejecutar script ``` databaseInit.sql ``` de la carpeta ```database``` ubicado en esta solucion, el script contiene la creacion de las tablas de la base de datos y la data del mismo.

### Modificacion de conexion a base de datos

-   Ya realizado lo anterior debera cambiar la cadena de conexion en el archivo ``` appsettings.json ``` y en la seccion de ```PokedexSQLConnection```

### En ejecucion

-   Cuando se haya iniciado la aplicacion la aplicacion le mostrara los end points del web api documentado con Swagger, para la ejecucion en el mismo le pedira la version del web API que en este caso por defecto esta en ```1```
