using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListLibrary;

namespace DlaZabawyTesty {
  class Program {
    static void Main(string[] args) {

      ToDoList ToDoList = new ToDoList();

      var Tasks = ToDoList.GetTasks();

      foreach (var task in Tasks) {
        Console.WriteLine("- {0}", task.Name);
      }

      Console.ReadLine();
    }
  }
}
