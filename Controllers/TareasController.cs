using Microsoft.AspNetCore.Mvc;
using TaskManagerApi.Data;
using TaskManagerApi.Models;

namespace TaskManagerApi.Controllers;

[ApiController]
[Route("api/tareas")]
public class TareasController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(TaskStore.Tareas);
    }

    [HttpPost]
    public IActionResult Create(Tarea request)
    {
        var tarea = new Tarea
        {
            Id = TaskStore.NextId,
            Titulo = request.Titulo,
            Descripcion = request.Descripcion,
            Completada = false
        };

        TaskStore.Tareas.Add(tarea);
        return CreatedAtAction(nameof(GetAll), new { id = tarea.Id }, tarea);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Tarea request)
    {
        var tarea = TaskStore.Tareas.FirstOrDefault(t => t.Id == id);
        if (tarea == null) return NotFound();

        tarea.Titulo = request.Titulo;
        tarea.Descripcion = request.Descripcion;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var tarea = TaskStore.Tareas.FirstOrDefault(t => t.Id == id);
        if (tarea == null) return NotFound();

        TaskStore.Tareas.Remove(tarea);
        return NoContent();
    }

    [HttpPatch("{id}/completar")]
    public IActionResult Complete(int id)
    {
        var tarea = TaskStore.Tareas.FirstOrDefault(t => t.Id == id);
        if (tarea == null) return NotFound();

        tarea.Completada = true;
        return NoContent();
    }
}
