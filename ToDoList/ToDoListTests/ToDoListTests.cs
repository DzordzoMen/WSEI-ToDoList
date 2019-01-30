using System;
using System.Collections.Generic;
using ToDoLibrary;
using Xunit;

namespace ToDoListTests {
  public class ToDoListTests {
    public ToDoList _toDoList = new ToDoList();

    [Fact]
    public void GetTasks_None_ShouldReturnListWithTasks() {
      var result = _toDoList.GetTasks();

      var checkIFList = result is List<Tasks>;

      Assert.True(checkIFList);
    }

    [Fact]
    public void GetNotFinishedTasks_None_ShouldReturnListWithTasks() {
      var result = _toDoList.GetNotFinishedTasks();

      var checkIfList = result is List<Tasks>;

      Assert.True(checkIfList);
    }

    [Fact]
    public void ChangeStatus_WrongTask_ShouldReturnStringWithMessage() {
      var wrongTask = new Tasks();
      wrongTask.Id = 9999;
      wrongTask.Name = "Wrong Task";
      wrongTask.Check = false;

      var result = _toDoList.ChangeStatus(wrongTask);

      Assert.Equal("Nie mo¿na znaleŸæ takiego zadania", result);
    }

    [Fact]
    public void ChangeStatus_CorrectTask_ShouldReturnStringWithMessage() {
      var correctTask = new Tasks();
      correctTask.Id = 3;
      correctTask.Name = "Task do Testowania";
      correctTask.Check = false;

      var result = _toDoList.ChangeStatus(correctTask);

      Assert.Equal("Zmieniono status zadania", result);
    }

    [Fact]
    public void AddTask_NewTask_ShouldReturnStringWithMessage() {
      var newTask = new Tasks();
      newTask.Name = "ZnaleŸæ kogoœ kto zap³aci za dodanie do projektu";

      var result = _toDoList.AddTask(newTask);

      Assert.Equal("Dodano nowe zadanie.", result);
    }

    [Fact]
    public void EditTask_WrongTask_ShouldReturnStringWithMessage() {
      var wrongTask = new Tasks();
      wrongTask.Id = 9999;
      wrongTask.Name = "Wrong Task";
      wrongTask.Check = false;

      var result = _toDoList.EditTask(wrongTask);

      Assert.Equal("Nie mo¿na znaleŸæ takiego zadania", result);
    }

    [Fact]
    public void EditTask_CorrectTask_ShouldReturnStringWithMessage() {
      var correctTask = new Tasks();
      correctTask.Id = 3;
      correctTask.Name = "Task do Testowania";
      correctTask.Check = false;

      var result = _toDoList.EditTask(correctTask);

      Assert.Equal("Zmieniono nazwê zadania", result);
    }

    [Fact]
    public void DeleteTask_WrongTask_ShouldReturnStringWithMessage() {
      var wrongTask = new Tasks();
      wrongTask.Id = 9999;
      wrongTask.Name = "Wrong Task";
      wrongTask.Check = false;

      var result = _toDoList.DeleteTask(wrongTask);

      Assert.Equal("Nie mo¿na znaleŸæ takiego zadania", result);
    }

    [Fact]
    public void DeleteTask_CorrectTask_ShouldReturnStringWithMessage() {
      var correctTask = new Tasks();
      correctTask.Id = 8888888;
      correctTask.Name = "Task do Usuniêcia";
      correctTask.Check = false;

      var result = _toDoList.DeleteTask(correctTask);

      _toDoList.AddTask(correctTask);

      Assert.Equal("Usuniêto zadanie", result);
    }
  }
}
