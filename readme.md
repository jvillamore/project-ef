Install
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.8

# Base de datos en memoria

dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 8.0.8

# Conexión base de datos SQLServer

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.8

# Conexión con Postgresql

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.4

# Para las migraciones.

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.8

# Ejecución de las migraciones.

dotnet ef migration add Message

# Listar las migraciones

dotnet ef migration list

# Ejecutar las migraciones

dotnet ef database update
