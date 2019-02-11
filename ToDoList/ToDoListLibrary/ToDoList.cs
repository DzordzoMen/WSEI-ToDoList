using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListLibrary {

  public class ToDoList {

    #region Properties

    private readonly toDoListConnectionString _context;

    #endregion

    #region Constructor

    public ToDoList () {
      _context = new toDoListConnectionString();
    }

    #endregion

    #region Public methods

    public List<Tasks> GetTasks() {
      var result = _context.Tasks
        .OrderBy(t => t.Id)
        .ToList<Tasks>();

      return result;
    }

    public List<Tasks> GetNotFinishedTasks() {
      var result = _context.Tasks
        .OrderBy(t => t.Id)
        .Where(t => t.Check == 0)
        .ToList();

      return result;

    }
    
    public string ChangeStatus(Tasks task) {

      var taskFromDb = _context.Tasks.Find(task.Id);
      if (taskFromDb == null) return "Nie można znaleźć takiego zadania";

      taskFromDb.Check = ChangeBool(taskFromDb.Check);
      _context.SaveChanges();

      return "Zmieniono status zadania";
    }
    
    public string AddTask(Tasks task) {

      if (task.Id == 0) {
        var lastTask = _context.Tasks
          .OrderBy(t => t.Id)
          .ToList()
          .Last();

        task.Id = lastTask.Id + 1;
      }

      _context.Tasks.Add(task);
      _context.SaveChanges();

      return "Dodano nowe zadanie.";
    }
    
    public string EditTask(Tasks task) {
      var taskFromDb = _context.Tasks.Find(task.Id);
      if (taskFromDb == null) return "Nie można znaleźć takiego zadania";

      taskFromDb.Name = task.Name;
      taskFromDb.Check = 0;
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

    #endregion

    #region Privates
    private long ChangeBool(long check) {
      if (check > 0) return 0;

      return 1;
    }

    #endregion
  }

}
