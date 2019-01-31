using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListLibrary;

namespace ToDoListTests {
  [TestClass]
  public class ToDoListTests {
    public ToDoList _toDoList = new ToDoList();


    [TestMethod]
    public void GetTasks_None_ShouldReturnListWithTasks() {
      var result = _toDoList.GetTasks();

      var checkIFList = result is List<Tasks>;

      Assert.IsTrue(checkIFList);
    }

    [TestMethod]
    public void GetNotFinishedTasks_None_ShouldReturnListWithTasks() {
      var result = _toDoList.GetNotFinishedTasks();

      var checkIfList = result is List<Tasks>;

      Assert.IsTrue(checkIfList);
    }
    
    [TestMethod]
    public void ChangeStatus_WrongTask_ShouldReturnStringWithMessage() {
      var wrongTask = new Tasks();
      wrongTask.Id = 9999;
      wrongTask.Name = "Wrong Task";
      wrongTask.Check = 0;

      var result = _toDoList.ChangeStatus(wrongTask);

      Assert.AreEqual("Nie można znaleźć takiego zadania", result);
    }

    [TestMethod]
    public void ChangeStatus_CorrectTask_ShouldReturnStringWithMessage() {
      var correctTask = new Tasks();
      correctTask.Id = 3;
      correctTask.Name = "Task do Testowania";
      correctTask.Check = 0;

      var result = _toDoList.ChangeStatus(correctTask);

      Assert.AreEqual("Zmieniono status zadania", result);
    }
    
    [TestMethod]
    public void AddTask_NewTask_ShouldReturnStringWithMessage() {
      var newTask = new Tasks {
        Name = "Znaleźć kogoś kto zapłaci za dodanie do projektu",
        Check = 1
      };

      var result = _toDoList.AddTask(newTask);

      Assert.AreEqual("Dodano nowe zadanie.", result);
    }
    
    [TestMethod]
    public void EditTask_WrongTask_ShouldReturnStringWithMessage() {
      var wrongTask = new Tasks();
      wrongTask.Id = 9999;
      wrongTask.Name = "Wrong Task";
      wrongTask.Check = 0;

      var result = _toDoList.EditTask(wrongTask);

      Assert.AreEqual("Nie można znaleźć takiego zadania", result);
    }

    [TestMethod]
    public void EditTask_CorrectTask_ShouldReturnStringWithMessage() {
      var correctTask = new Tasks();
      correctTask.Id = 3;
      correctTask.Name = "Task do Testowania";
      correctTask.Check = 0;

      var result = _toDoList.EditTask(correctTask);

      Assert.AreEqual("Zmieniono nazwę zadania", result);
    }
    
    [TestMethod]
    public void DeleteTask_WrongTask_ShouldReturnStringWithMessage() {
      var wrongTask = new Tasks();
      wrongTask.Id = 9999;
      wrongTask.Name = "Wrong Task";
      wrongTask.Check = 0;

      var result = _toDoList.DeleteTask(wrongTask);

      Assert.AreEqual("Nie można znaleźć takiego zadania", result);
    }

    [TestMethod]
    public void DeleteTask_CorrectTask_ShouldReturnStringWithMessage() {
      var correctTask = new Tasks();
      correctTask.Id = 2222;
      correctTask.Name = "Task do Usunięcia";
      correctTask.Check = 0;

      var result = _toDoList.DeleteTask(correctTask);

      _toDoList.AddTask(correctTask);

      Assert.AreEqual("Usunięto zadanie", result);
    }
  }
}
