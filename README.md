# Censo INEGI - Aplicación de Escritorio

## Descripción
La aplicación **Censo INEGI** es una herramienta de escritorio desarrollada en **C# utilizando .NET Framework** y **MySQL** para gestionar la información del censo de viviendas y habitantes del estado de Coahuila, México. El sistema permite registrar viviendas, habitantes, actividades económicas, y realizar consultas y reportes estadísticos sobre la población. La aplicación está diseñada bajo el modelo **MVC** (Modelo-Vista-Controlador) y hace uso de los patrones de diseño **Singleton** y **Repository**.

## Características
- **Registro de Viviendas**: Registro detallado de viviendas, incluyendo calle, número, colonia, municipio, tipo de casa y actividades económicas de los habitantes.
- **Registro de Habitantes**: Posibilidad de registrar los habitantes de cada vivienda, incluyendo datos personales como nombre, edad, género y relación con la vivienda.
- **Actividades Económicas**: Registro y asociación de actividades económicas que sostienen cada vivienda.
- **Seguridad de Acceso**: Sistema de login para usuarios y administradores. Los administradores pueden gestionar usuarios del sistema.
- **Consultas y Reportes**:
  - Consultar habitantes por vivienda.
  - Reportes estadísticos por municipio y localidad, con gráficos que muestran la cantidad de habitantes según diferentes criterios.
  - Dashboard para obtener el número de población por entidad, municipio y localidad.

## Tecnologías Utilizadas
- **Lenguaje de Programación**: C# (.NET Framework)
- **Base de Datos**: MySQL con Navicat como gestor de base de datos
- **Entorno de Desarrollo**: Visual Studio
- **Arquitectura**: MVC (Modelo-Vista-Controlador)
- **Patrones de Diseño**: Singleton, Repository

## Instalación y Ejecución
1. **Clonar el Repositorio**:
   ```bash
   git clone https://github.com/Oswi777/INEGI_App.git
   ```
2. **Configuración de la Base de Datos**:
   - Importa el script de la base de datos (`CensoINEGI.sql`) en tu servidor MySQL.
   - Asegúrate de configurar la cadena de conexión en `DatabaseConnection.cs` con las credenciales adecuadas.
3. **Abrir el Proyecto en Visual Studio**:
   - Abre el archivo de solución `.sln` en Visual Studio.
   - Restaura los paquetes NuGet si es necesario.
4. **Ejecutar la Aplicación**:
   - Presiona `F5` en Visual Studio para compilar y ejecutar la aplicación.

## Uso de la Aplicación
- **Login**: Accede con un usuario administrador o trabajador para comenzar a registrar y consultar información.
- **Registrar Vivienda**: Una vez iniciada la sesión, dirígete al formulario de registro de viviendas y llena los campos requeridos.
- **Registrar Habitantes**: Automáticamente se abrirá el formulario de registro de habitantes para asociar personas a la vivienda recién registrada.
- **Consultas**: Utiliza la sección de consulta para ver los habitantes registrados por vivienda y la información de las actividades económicas.
- **Generar Reportes**: Selecciona un municipio y/o localidad para generar un reporte detallado y visualización gráfica de la información censal.

## Funcionalidades del Administrador
- Crear nuevos usuarios del sistema.
- Consultar información de las viviendas y habitantes de manera ordenada.
- Acceso al dashboard con reportes estadísticos detallados.

## Contribuir
Si deseas contribuir al desarrollo de este proyecto:
1. Haz un fork del repositorio.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz un commit (`git commit -m 'Agregar nueva funcionalidad'`).
4. Empuja los cambios a GitHub (`git push origin feature/nueva-funcionalidad`).
5. Abre un Pull Request.

## Contacto
Para más información o consultas, puedes contactar a [Oswi777](https://github.com/Oswi777).

© 2024 Censo INEGI App

