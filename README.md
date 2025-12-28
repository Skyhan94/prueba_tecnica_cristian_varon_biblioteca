# 📚 Biblioteca Codex - Gestión Administrativa

Descripción del Proyecto

Biblioteca Codex es una plataforma de gestión administrativa diseñada para centralizar y organizar el catálogo de una biblioteca digital. El sistema permite administrar de manera eficiente la relación entre Autores y sus Libros, proporcionando una experiencia de usuario fluida y visualmente atractiva. Esta aplicación fue desarrollada como una **Prueba Técnica**, enfocándose en la implementación de una arquitectura robusta, código limpio y una interfaz de usuario personalizada que rompe con los esquemas tradicionales de tablas grises, apostando por una estética profesional en Modo Claro con acentos en Naranja y Café.

## 🚀 Características Principales

* **Dashboard Estadístico:** Pantalla de inicio con contadores dinámicos de Libros y Autores en tiempo real.
* **CRUD Completo:** Gestión de Autores y Libros (Crear, Leer, Actualizar, Eliminar).
* **Diseño UI/UX:** Interfaz personalizada con temática Clara (Light Mode) y acentos en **Naranja y Café**, optimizada para la legibilidad.
* **Relaciones de Datos:** Implementación de relaciones 1:N entre Autores y Libros utilizando Entity Framework Core.
* **Navegación Inteligente:** Barra lateral con detección automática de la página activa.

## 🛠️ Tecnologías Utilizadas

* **Backend:** .NET 10.0 (ASP.NET Core MVC)
* **Base de Datos:** SQL Server Local (LocalDB)
* **ORM:** Entity Framework Core
* **Frontend:** HTML5, CSS3, Bootstrap 5 y Bootstrap Icon

## ⚙️ Pasos para Configurar la aplicacion

### 1. Clonar el repositorio

* git clone
 https://github.com/Skyhan94/prueba_tecnica_cristian_varon_biblioteca

### 2. Configurar la cadena de conexion
* Abre el archivo appsettings.json reemplaza los datos de la base de datos (Server y Database) en el siguiente codigo y luego reemplazalo en el archivo. Solo deben revisar en su Sql Server el nombre del servidor, el nombre del database lo pueden dejar asi, entity framework se encargara de crear la base de datos si no existe con el paso siguiente.

  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BibliotecaCodexDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }

### 3. Crear la Base de Datos (Migraciones)
Una vez abierto el proyecto en Visual Studio, sigue estos pasos para generar la estructura de tablas y relaciones:

* Abre la Consola del Administrador de Paquetes (Menú: Herramientas -> Administrador de Paquetes NuGet -> Consola del Administrador de Paquetes).
* Ejecuta el siguiente comando: Update-Database

Nota: Este paso requiere que tengas instalado el SDK de .NET y las herramientas de Entity Framework (incluidas en el proyecto).

### 4. Ejecutar pulsando la tecla F5

* Pulsa la tecla F5 o el botón "Play" en Visual Studio para compilar y ejecutar el proyecto en tu navegador.

## 💡 Funcionalidades Principales

### 1. Inicio: Contiene contador de libros y autores agregados a la aplicacion, las tarjetas tienen un hipervinculo o enlace que arrojan a la lista de libros o lista de autores segun el enlace seleccionado. Ademas la barra de navegacion que permite visualizar en que parte de la pagina estamos y nos permite navegar a travez de las diferentes secciones de la pagina o aplicativo web

<img width="1906" height="925" alt="image" src="https://github.com/user-attachments/assets/a6b4553c-20ae-462b-a105-a29613d917f3" />

### 2. Autores: Contiene la lista de Autores de libros agregados, el boton de agregar un nuevo Autor, ademas, al frente de cada autor se pueden visualizar unos botones que permiten eliminar o editar un autor.

<img width="1895" height="929" alt="image" src="https://github.com/user-attachments/assets/b1c4b0ed-83dd-4f50-9576-668aeeba2852" />

### 3. Agregar Nuevo Autor: Al dar clic en el boton "Agregar Nuevo Autor" Se redirecciona a la pagina donde se debe ingresar el nombre del autor, luego se encuentran unos botones para Crear el nuevo autor o regresar a la lista de autores.

<img width="1916" height="927" alt="image" src="https://github.com/user-attachments/assets/167b7ccd-ddee-4616-ad5e-e877c6f4a39c" />

### 4. Editar un Autor: En la lista de autores, al dar clic en el boton "Editar" Se redirecciona a la pagina donde aparece el nombre del autor y se puede cambiar el nombre en caso de que un autor ingresado sea incorrecto encontramos de igual forma los botones de guardar y regresar a la lista

<img width="1909" height="929" alt="image" src="https://github.com/user-attachments/assets/e2712634-5c5a-4e34-8da7-a6f489bdd880" />

### 5. Eliminar un Autor: En la lista de autores, al dar clic en "Eliminar" Se redirecciona a la pagina de eliminar donde el aplicativo pide confirmacion para eliminar y muestra el autor a eliminar, aparecen dos botones, uno para eliminar y otro para regresar a la lista de autores.

<img width="1914" height="929" alt="image" src="https://github.com/user-attachments/assets/830c5d2a-1a2f-4cb2-b3ed-e37896b5345e" />

### 6. Libros: En esta seccion encontramos el listado de libros donde encontramos el titulo, el autor, la opcion de agregar un nuevo libro y las opciones de editar y eliminar un libro.

<img width="1907" height="931" alt="image" src="https://github.com/user-attachments/assets/8b671cf3-9fbe-4a77-9246-ea783255dc1d" />

### 7. Agregar Nuevo Libro: Al hacer clic en "Agregar Nuevo Libro" Se redirecciona a la pagina de Agregar Libros, donde encontramos 2 input, uno para escribir el titulo del libro y otro para elegir el nombre del autor, en la opcion de elegir el autor, es necesario que el autor este dentro de la lista de autores para que pueda ser asignado al libro, de lo contrario es necesario primero agregar el autor y luego seleccionarlo en la lista de autores. Encontramos nuevamente el boton de crear y regresar a la lista de libros

<img width="1910" height="927" alt="image" src="https://github.com/user-attachments/assets/66cc7548-72f6-42d1-9ff2-af1746e4b733" />

### 8. Editar un Libro: Al hacer clic en la opcion "Editar" de alguno de los libros aparecera los mismos input que aparecen al crear un nuevo libro, con la diferencia de que el Titulo y el autor van a estar diligenciados, se puede digitar un nuevo titulo o elegir un nuevo autor y hacer clic en la opcion "Guardar" o en caso contrario de no querer editar, hacer clic en la opcion "Regresar a la lista"

<img width="1911" height="935" alt="image" src="https://github.com/user-attachments/assets/8a401427-3486-4fa8-a83a-ab0cf794672f" />

### 9. Eliminar un Libro: Al hacer clic en la opcion "Eliminar" en el listado de libros al igual que con el autor se redirecciona a una pagina donde aparecera una confirmacion de elinacion junto con el nombre del libro a eliminar y las opciones de eliminar o regresar a la lista de libros.

<img width="1914" height="919" alt="image" src="https://github.com/user-attachments/assets/b4e08041-dc16-4ae2-9bc4-087c3c2cded1" />

## 🗄️Diagrama Entidad Relacion de la Base de Datos

<img width="1557" height="691" alt="image" src="https://github.com/user-attachments/assets/22cad5e4-7c69-410a-aa4b-36e904fe6f1e" />


## Desarrollado por: Cristian Johan Varon - 2025 Repositorio https://github.com/Skyhan94/prueba_tecnica_cristian_varon_biblioteca



