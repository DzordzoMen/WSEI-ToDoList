using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoListLibrary;

namespace ToDoListForm {
  public partial class ToDoList : Form {

    #region Properties

    ToDoListLibrary.ToDoList _toDoList = new ToDoListLibrary.ToDoList();

    private bool _showAll = true;

    #endregion

    #region Constructor

    public ToDoList() {
      InitializeComponent();
      GetRecords();
    }

    #endregion

    #region Grid Methods

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

    #endregion

    #region Button and CheckBox methods

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

    private void DisplayChange(object sender, EventArgs e) {
      _showAll = !_showAll;

      GetRecords();
    }

    #endregion

    #region ReturnSelectedTask method

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

    #endregion
  }
}
