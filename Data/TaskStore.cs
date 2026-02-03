using TaskManagerApi.Models;

namespace TaskManagerApi.Data;

public static class TaskStore
{
    public static List<Tarea> Tareas { get; } = new();

    public static int NextId =>
        Tareas.Count == 0 ? 1 : Tareas.Max(t => t.Id) + 1;
}
