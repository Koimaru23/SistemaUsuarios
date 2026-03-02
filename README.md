Use los patrones de singleton , DAO y Capas para la tarea
-Capa Presentacion: Contiene los formularios de la interfaz de usuario se encarga de capturar la entrada de datos y mostrar los resultados.
-Capa Datos (DatosDAO) : Implementa el patron DAO para centraliza todas las consultas fuera del formulario.
-Capa de Configuracion (Conexion): Implementa el patron Singleton para gestionar la conexion a SQL Server. Esto garantiza que el sistema utilice una unica instancia de conexion, optimizando el uso de recursos.
-Script de Base de Datos (BaseDatos.sql): Contiene la base de datos que realice para el trabajo.
