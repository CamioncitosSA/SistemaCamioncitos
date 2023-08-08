# SistemaCamioncitos
## Grupo C - SOF-S-MA-6-1
Este es un sistema de gestión de vehículos desarrollado en C# utilizando Visual Studio y una base de datos en SQL Server. El sistema consta de tres módulos principales: Chofer, Vehículo y Ruta.

![pantallademoCDS](https://github.com/CamioncitosSA/SistemaCamioncitos/assets/134811261/6074fcf7-2ca0-4054-998b-ebabe674b6e5)


## Requisitos previos

Antes de instalar y ejecutar este sistema, asegúrese de tener lo siguiente:

- Microsoft Visual Studio instalado en su máquina.
- Microsoft SQL Server instalado en su máquina.
- Una base de datos vacía creada en SQL Server para utilizar con el sistema.

## Pasos para la instalación

Siga los siguientes pasos para instalar y ejecutar el sistema:

1. Clone o descargue este repositorio en su máquina local.
2. Antes de ejecutar el sistema, es necesario ejecutar los querys (ubicados en la capa de Datos) en la base de datos que tenga creada en el Sql Server.
3. Abra Visual Studio y vaya a `Archivo` -> `Abrir` -> `Proyecto/Solución`.
4. Navegue hasta la carpeta del repositorio y seleccione el archivo de solución (.sln).
5. Una vez que el proyecto esté abierto en Visual Studio, abra el archivo `CD_Connection.cs` ubicado en la capa de datos (`CapaDatos`).
6. En el archivo `CD_Connection.cs`, busque la línea que contiene la cadena de conexión:
```csharp
private SqlConnection db_connection = new SqlConnection("Server=Nombre_Servidor; Database=Nombre_BaseDatos; Integrated Security=true");
```
6. Reemplace `"Nombre_Servidor"` con el nombre de su servidor de SQL Server y `"Nombre_BaseDatos"` con el nombre de su base de datos creada para el sistema.
7. Guarde el archivo `CD_Connection.cs`.

## Ejecutar el sistema

Una vez que haya realizado los pasos anteriores, estará listo para ejecutar el sistema. Simplemente compile el proyecto y ejecute la aplicación desde Visual Studio.

## Licencia

Este proyecto está bajo la licencia [MIT](LICENSE).
