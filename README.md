API de Gestión de Tareas (Task Manager API)
Una API RESTful para la gestión de tareas desarrollada en ASP.NET Core 8.0. Permite realizar operaciones CRUD completas sobre tareas con persistencia en memoria.

📋 Características
✅ CRUD completo: Crear, Leer, Actualizar y Eliminar tareas

✅ Marcar como completada: Endpoint específico para completar tareas

✅ Documentación automática: Swagger/OpenAPI integrado

✅ Sin base de datos: Persistencia en memoria (ideal para pruebas)

✅ Código limpio: Arquitectura simple y fácil de entender

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
🛠️ Instalación y Ejecución
Prerrequisitos
.NET 8.0 SDK

Postman (opcional, para pruebas)

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
La API estará disponible en: http://localhost:5000

Acceder a la documentación Swagger

text
http://localhost:5000/swagger
http://localhost:5000/swagger/index.html
📡 Endpoints de la API
Método	Endpoint	Descripción
GET	/api/tareas	Obtener todas las tareas
POST	/api/tareas	Crear una nueva tarea
PUT	/api/tareas/{id}	Actualizar una tarea existente
PATCH	/api/tareas/{id}/completar	Marcar tarea como completada
DELETE	/api/tareas/{id}	Eliminar una tarea
📝 PROBAR LA API CON POSTMAN
Paso 1: Importar la colección en Postman
Abre Postman

Haz clic en "Import"

Copia y pega el siguiente JSON:

json
{
  "info": {
    "name": "Task Manager API",
    "schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json"
  },
  "item": [
    {
      "name": "Obtener todas las tareas",
      "request": {
        "method": "GET",
        "url": "http://localhost:5000/api/tareas"
      }
    },
    {
      "name": "Crear nueva tarea",
      "request": {
        "method": "POST",
        "url": "http://localhost:5000/api/tareas",
        "body": {
          "mode": "raw",
          "raw": "{\n  \"titulo\": \"Mi primera tarea\",\n  \"descripcion\": \"Descripción de ejemplo\"\n}",
          "options": {
            "raw": {
              "language": "json"
            }
          }
        },
        "header": [
          {
            "key": "Content-Type",
            "value": "application/json"
          }
        ]
      }
    },
    {
      "name": "Actualizar tarea",
      "request": {
        "method": "PUT",
        "url": "http://localhost:5000/api/tareas/1",
        "body": {
          "mode": "raw",
          "raw": "{\n  \"titulo\": \"Título actualizado\",\n  \"descripcion\": \"Descripción actualizada\"\n}",
          "options": {
            "raw": {
              "language": "json"
            }
          }
        },
        "header": [
          {
            "key": "Content-Type",
            "value": "application/json"
          }
        ]
      }
    },
    {
      "name": "Marcar tarea como completada",
      "request": {
        "method": "PATCH",
        "url": "http://localhost:5000/api/tareas/1/completar"
      }
    },
    {
      "name": "Eliminar tarea",
      "request": {
        "method": "DELETE",
        "url": "http://localhost:5000/api/tareas/1"
      }
    }
  ]
}
Paso 2: Configurar variables de entorno (opcional)
Crea un entorno en Postman con:

base_url: http://localhost:5000

Luego usa {{base_url}}/api/tareas en las URLs

Paso 3: Probar cada endpoint manualmente
1. GET - Obtener todas las tareas
URL: http://localhost:5000/api/tareas

Método: GET

Body: No requiere

Respuesta esperada (200 OK):

json
[]
(Inicialmente vacío hasta que crees tareas)

2. POST - Crear nueva tarea
URL: http://localhost:5000/api/tareas

Método: POST

Headers: Content-Type: application/json

Body (raw JSON):

json
{
  "titulo": "Aprender ASP.NET Core",
  "descripcion": "Crear mi primera API RESTful"
}
Respuesta esperada (201 Created):

json
{
  "id": 1,
  "titulo": "Aprender ASP.NET Core",
  "descripcion": "Crear mi primera API RESTful",
  "completada": false
}
3. PUT - Actualizar tarea
URL: http://localhost:5000/api/tareas/1

Método: PUT

Headers: Content-Type: application/json

Body (raw JSON):

json
{
  "titulo": "Título actualizado",
  "descripcion": "Descripción modificada"
}
Respuesta esperada: 204 No Content

4. PATCH - Marcar como completada
URL: http://localhost:5000/api/tareas/1/completar

Método: PATCH

Body: No requiere

Respuesta esperada: 204 No Content

5. DELETE - Eliminar tarea
URL: http://localhost:5000/api/tareas/1

Método: DELETE

Body: No requiere

Respuesta esperada: 204 No Content

Paso 4: Flujo de prueba completo en Postman
GET /api/tareas → Debería devolver array vacío []

POST /api/tareas → Crear una tarea (guarda el id devuelto)

GET /api/tareas → Verificar que aparece la tarea creada

PUT /api/tareas/{id} → Actualizar la tarea

GET /api/tareas → Verificar los cambios

PATCH /api/tareas/{id}/completar → Marcar como completada

GET /api/tareas → Verificar que completada: true

DELETE /api/tareas/{id} → Eliminar la tarea

GET /api/tareas → Verificar que se eliminó

🎯 Ejemplos de Prueba para Postman
Caso 1: Crear múltiples tareas
json
[
  {
    "titulo": "Revisar documentación",
    "descripcion": "Leer la documentación de ASP.NET Core"
  },
  {
    "titulo": "Probar endpoints",
    "descripcion": "Probar todos los métodos HTTP"
  },
  {
    "titulo": "Configurar Swagger",
    "descripcion": "Agregar documentación OpenAPI"
  }
]
Caso 2: Verificar validaciones
Intentar PUT/PATCH/DELETE con ID inexistente → 404 Not Found

POST sin título o descripción → Se acepta (la API no tiene validaciones estrictas)

📊 Códigos de Estado HTTP
Código	Descripción	Ejemplo en Postman
200	OK - Operación exitosa	GET exitoso
201	Created - Recurso creado	POST exitoso
204	No Content - Operación exitosa sin contenido	PUT, PATCH, DELETE
404	Not Found - Recurso no encontrado	ID no existente
500	Internal Server Error - Error del servidor	Error en la API
🔧 Solución de Problemas en Postman
Problema: "Could not get any response"
Verifica que la API esté ejecutándose (dotnet run)

Verifica el puerto (normalmente 5000 o 5001)

Prueba en el navegador: http://localhost:5000/swagger

Problema: "415 Unsupported Media Type"
Asegúrate de que los headers incluyan: Content-Type: application/json

Problema: Los datos no persisten entre ejecuciones
Es normal, la API usa almacenamiento en memoria

Los datos se pierden al reiniciar la aplicación

🐳 Docker (Opcional)
bash
# Construir la imagen
docker build -t api-tareas .

# Ejecutar el contenedor
docker run -p 5000:80 api-tareas
Luego en Postman, cambia la URL a: http://localhost:5000/api/tareas

📚 Recursos Adicionales
Documentación oficial de Postman

ASP.NET Core Web API Tutorial

OpenAPI Specification

🤝 Contribuir
Haz fork del proyecto

Crea una rama para tu feature (git checkout -b feature/AmazingFeature)

Commit tus cambios (git commit -m 'Add some AmazingFeature')

Push a la rama (git push origin feature/AmazingFeature)

Abre un Pull Request

👨‍💻 Autor
Cristian Diaz

GitHub: @CristianDiazAndesscd

Proyecto: API de Gestión de Tareas
