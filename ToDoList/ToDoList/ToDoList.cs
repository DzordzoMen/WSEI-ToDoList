using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ToDoLibrary {
  public class ToDoList {
    private readonly TaskListContext _context;

    public ToDoList () {
      _context = new TaskListContext();
    }

    public List<Tasks> GetTasks() {
      var result = _context.Tasks
        .OrderBy(t => t.Id)
        .ToList();

      return result;
    }

    public List<Tasks> GetNotFinishedTasks() {
      var result = _context.Tasks
        .OrderBy(t => t.Id)
        .Where(t => t.Check == false)
        .ToList();

      return result;

    }

    public string ChangeStatus(Tasks task) {

      var taskFromDb = _context.Tasks.Find(task.Id);
      if (taskFromDb == null) return "Nie można znaleźć takiego zadania";

      taskFromDb.Check = !task.Check;
      _context.Tasks.Update(taskFromDb);
      _context.SaveChanges();

      return "Zmieniono status zadania";
    }

    public string AddTask(Tasks task) {
      _context.Tasks.Add(task);
      _context.SaveChanges();

      return "Dodano nowe zadanie.";
    }

    public string EditTask(Tasks task) {
      var taskFromDb = _context.Tasks.Find(task.Id);
      if (taskFromDb == null) return "Nie można znaleźć takiego zadania";

      taskFromDb.Name = task.Name;
      taskFromDb.Check = false;
      _context.Tasks.Update(taskFromDb);
      _context.SaveChanges();

      return "Zmieniono nazwę zadania";
    }

    public string DeleteTask(Tasks task) {
      var taskToRemove = _context.Tasks.Find(task.Id);
      if (taskToRemove == null) return "Nie można znaleźć takiego zadania";

      _context.Tasks.Remove(taskToRemove);
      _context.SaveChanges();
      return "Usunięto zadanie";
    }
  }
}
