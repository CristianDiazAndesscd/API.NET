API de Gestión de Tareas (Task Manager API)
Una API RESTful para la gestión de tareas desarrollada en ASP.NET Core 8.0. Permite realizar operaciones CRUD completas sobre tareas con persistencia en memoria.

📋 Características
CRUD completo: Crear, Leer, Actualizar y Eliminar tareas

Marcar como completada: Endpoint específico para completar tareas

 Documentación automática: Swagger/OpenAPI integrado

 Sin base de datos: Persistencia en memoria (ideal para pruebas)

 Código limpio: Arquitectura simple y fácil de entender

🚀 Tecnologías Utilizadas
ASP.NET Core 8.0 - Framework principal

Swagger/OpenAPI - Documentación de API

C# 12 - Lenguaje de programación

JSON - Formato de datos

📁 Estructura del Proyecto
text
API.NET/
├── Controllers/
│   └── TareasController.cs    # Controlador de la API
├── Models/
│   └── Tarea.cs               # Modelo de datos
├── Data/
│   └── TaskStore.cs           # Almacenamiento en memoria
├── Program.cs                 # Configuración de la aplicación
└── appsettings.json          # Configuración

🛠️ Instalación y Ejecución:

Prerrequisitos
.NET 8.0 SDK

Visual Studio 2022, VS Code o cualquier editor de código

Pasos para ejecutar
Clonar el repositorio

bash
git clone https://github.com/CristianDiazAndesscd/API.NET.git
cd API.NET
Restaurar dependencias

bash
dotnet restore
Ejecutar la aplicación

bash
dotnet run
Acceder a la documentación Swagger

text
http://localhost:5000/swagger
http://localhost:5000/swagger/index.html
📡 Endpoints de la API
GET /api/tareas
Obtiene todas las tareas.

Response (200 OK):

json
[
  {
    "id": 1,
    "titulo": "Aprender C#",
    "descripcion": "Estudiar ASP.NET Core",
    "completada": false
  }
]

POST /api/tareas
Crea una nueva tarea.

Request Body:

json
{
  "titulo": "Nueva tarea",
  "descripcion": "Descripción de la tarea"
}
Response (201 Created):

json
{
  "id": 2,
  "titulo": "Nueva tarea",
  "descripcion": "Descripción de la tarea",
  "completada": false
}
PUT /api/tareas/{id}
Actualiza una tarea existente.

Request Body:

json
{
  "titulo": "Título actualizado",
  "descripcion": "Descripción actualizada"
}
Response: 204 No Content

PATCH /api/tareas/{id}/completar
Marca una tarea como completada.

Response: 204 No Content

DELETE /api/tareas/{id}
Elimina una tarea.

Response: 204 No Content

📝 Modelo de Datos:

csharp
public class Tarea
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public bool Completada { get; set; } = false;
}
🧪 Ejemplos de Uso:

Usando curl:
Obtener todas las tareas:

bash
curl -X GET http://localhost:5000/api/tareas
Crear una nueva tarea:

bash
curl -X POST http://localhost:5000/api/tareas \
  -H "Content-Type: application/json" \
  -d '{"titulo": "Revisar código", "descripcion": "Revisar pull requests"}'
Actualizar una tarea:

bash
curl -X PUT http://localhost:5000/api/tareas/1 \
  -H "Content-Type: application/json" \
  -d '{"titulo": "Título actualizado", "descripcion": "Nueva descripción"}'
Marcar como completada:

bash
curl -X PATCH http://localhost:5000/api/tareas/1/completar
Eliminar una tarea:

bash
curl -X DELETE http://localhost:5000/api/tareas/1
Usando herramientas gráficas:
Postman

Insomnia

Swagger UI (integrado en la aplicación)

🔧 Almacenamiento en Memoria
La API utiliza una clase estática TaskStore para almacenamiento temporal:

csharp
public static class TaskStore
{
    public static List<Tarea> Tareas { get; } = new();
    public static int NextId => Tareas.Count == 0 ? 1 : Tareas.Max(t => t.Id) + 1;
}
Nota: Los datos se pierden al reiniciar la aplicación. Para persistencia permanente, considera integrar una base de datos.

🐳 Docker (Opcional)

Si tienes Docker instalado, puedes ejecutar la API en un contenedor:

bash
# Construir la imagen
docker build -t api-tareas .

# Ejecutar el contenedor
docker run -p 5000:80 api-tareas

📊 Códigos de Estado HTTP

Código	Descripción
200	OK - Operación exitosa
201	Created - Recurso creado
204	No Content - Operación exitosa sin contenido
404	Not Found - Recurso no encontrado
500	Internal Server Error - Error del servidor

🤝 Contribuir

Haz fork del proyecto

Crea una rama para tu feature (git checkout -b feature/AmazingFeature)

Commit tus cambios (git commit -m 'Add some AmazingFeature')

Push a la rama (git push origin feature/AmazingFeature)

Abre un Pull Request

📄 Licencia
Este proyecto está bajo la Licencia MIT. Ver el archivo LICENSE para más detalles.

👨‍💻 Autor
Cristian Diaz

GitHub: @CristianDiazAndesscd

Proyecto: API de Gestión de Tareas
