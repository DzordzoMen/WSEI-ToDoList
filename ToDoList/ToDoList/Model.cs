using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoLibrary {
  public class TaskListContext : DbContext {
    public DbSet<Tasks> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      // haha dobre mmmm
      optionsBuilder.UseSqlite("Data Source=C:/Users/neipr/source/repos/git/WSEI-ToDoList/ToDoList/ToDoList/Database/ToDoListDB.db");
    }
  }

  [Table("tasks")]
  public class Tasks {
    public int Id { get; set; }

    public string Name { get; set; }

    public bool Check { get; set;}
  }
}
