using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoListLibrary;

namespace ToDoListForm {
  public partial class ToDoList : Form {
    ToDoListLibrary.ToDoList _toDoList = new ToDoListLibrary.ToDoList();

    private bool _showAll = true;

    public ToDoList() {
      InitializeComponent();
      GetRecords();
    }

    public void GetRecords() {
      List<Tasks> records;

      if (_showAll) {
        records = _toDoList.GetTasks();
      } else {
        records = _toDoList.GetNotFinishedTasks();
      }

      DataGrid.DataSource = records;
    }

    private void DataGridOnStart(object sender, DataGridViewCellEventArgs e) {
      GetRecords();
    }

    // Add Button
    private void AddTask(object sender, EventArgs e) {
      var task = new Tasks {
        Name = NewTaskField.Text,
        Check = 0
      };

      var message = _toDoList.AddTask(task);
      NewTaskField.Clear();
      GetRecords();
      MessageBox.Show(message);
    }

    // Edit Button
    private void EditTask(object sender, EventArgs e) {
      Tasks task = ReturnSelectedTask();

      var message = _toDoList.EditTask(task);
      GetRecords();
      MessageBox.Show(message);
    }

    // Delete button
    private void DeleteTask(object sender, EventArgs e) {
      Tasks task = ReturnSelectedTask();

      var message = _toDoList.DeleteTask(task);
      GetRecords();
      MessageBox.Show(message);
    }

    // Change Status Button
    private void ChangeTaskStatus(object sender, EventArgs e) {
      Tasks task = ReturnSelectedTask();

      var message = _toDoList.ChangeStatus(task);
      GetRecords();
      MessageBox.Show(message);
    }



    private Tasks ReturnSelectedTask() {
      int index = DataGrid.CurrentRow.Index;

      var taskId = DataGrid[0, index].Value.ToString();
      var taskName = DataGrid[1, index].Value.ToString();
      var taskCheck = DataGrid[2, index].Value.ToString();


      Int64.TryParse(taskId, out long id);
      Int64.TryParse(taskCheck, out long check);

      var task = new Tasks {
        Id = id,
        Name = taskName,
        Check = check
      };
      return task;
    }

    private void DisplayChange(object sender, EventArgs e) {
      _showAll = !_showAll;

      GetRecords();
    }
  }
}
