# Arquitectura de Software - Actividad # 02 - Practica .NET

## 👨‍💻 Información del Estudiante

- **Nombre:** Jesús Omar Uc Domíguez
- **Matrícula:** SW2509031
- **Grupo:** 3C
- **Cuatrimestre:** 3er Cuatrimestre
- **Carrera:** TSU en Desarrollo e Innovación de Software
- **Profesor:** Jorge Javier Pedrozo Romero

---

# 🔐 Catálogo de Videojuegos

Este proyecto es una **aplicación web MVC desarrollada en .NET** que permite gestionar un catálogo de videojuegos. El sistema permite visualizar una lista de juegos, ver los detalles de cada uno y potencialmente agregar o modificar registros según la lógica del catálogo.

La aplicación está estructurada bajo el patrón **Modelo-Vista-Controlador (MVC)**, facilitando claridad en la arquitectura y separando responsabilidades entre lógica de negocios, interfaz de usuario y acceso a datos. 

---

## 📌 Características

- Interfaz web amigable para visualizar videojuegos.
- Organización de código por capas (**Models**, **Views**, **Controllers**).
- Uso de .NET y C# para lógica de backend.
- Posibilidad de ampliar con CRUD completo (crear, leer, actualizar y eliminar).

---

## 🧮 Cómo funciona mi catálogo

1. **Inicio de la aplicación:** Al iniciar el proyecto, se carga la página principal donde se muestra una lista de videojuegos.
2. **Controladores MVC:** Los controladores manejan las solicitudes y retornan las vistas correspondientes.
3. **Modelos de datos:** Representan las entidades como videojuegos y permiten interacción con los datos.
4. **Vistas:** Se encargan de presentar la información al usuario en formato HTML.
5. **Navegación:** El usuario puede ver información de cada videojuego y navegar por la interfaz.

---

## 📁 Estructura del proyecto

```

ArqSoft-S01-JesusUc/
├─ Areas/
│ └─ Identity/ # Administración de cuentas/usuarios
├─ Controllers/
│ └─ *.cs # Lógica de ruta y acciones
├─ Data/
│ └─ *.cs # Contexto y acceso a datos
├─ Models/
│ └─ *.cs # Entidades del dominio (Videojuegos, etc.)
├─ Properties/
├─ Views/
│ └─ *.cshtml # Frontend / vistas de navegación
├─ wwwroot/ # Recursos públicos (CSS, JS, imágenes)
├─ Program.cs
├─ MiProyecto.slnx
└─ appsettings.json

```


---

## 🎨 Tecnologías utilizadas

- **.NET 6 / .NET Core MVC**
- **C#**
- **HTML + CSS**
- **Razor Views (CSHTML)**
- **MVC Pattern (Model-View-Controller)**
- **Visual Studio / .NET CLI**

---

# 📚 Archivos principales

- **Program.cs** – Configuración principal y arranque del servidor.
- **Controllers/** – Gestión de rutas y acciones del catálogo.
- **Models/** – Clases que representan los videojuegos y otras entidades.
- **Views/** – Archivos visuales que el usuario ve en el navegador.
- **Data/** – Lugar para la lógica de conexión y acceso a datos.
- **appsettings.json** – Configuración general de la aplicación.

---

## 🤝 Agradecimientos

- **Profesor Jorge Javier Pedrozo Romero** por la estructura del curso y la práctica
- **Tecnológico de Software** por la formación integral

---

## 📧 Contacto

- **Email Institucional:** [jesus.uc@tecdesoftware.edu.mx]
- **GitHub:** [JesusUc18](https://github.com/JesusUc18)

---

## 📄 Licencia

Este proyecto es parte de las actividades académicas del **Tecnológico de Software** y está bajo la licencia MIT.

---

<div align="center">

**⭐ Si te gustó este proyecto, dale una estrella ⭐**


