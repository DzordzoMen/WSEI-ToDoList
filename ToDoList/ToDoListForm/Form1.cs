using System;
using System.Windows.Forms;
using ToDoListLibrary;

namespace ToDoListForm {
  public partial class Form1 : Form {
    ToDoList _toDoList = new ToDoList();

    public Form1() {
      InitializeComponent();
      GetRecords();
    }

    public void GetRecords() {
      var records = _toDoList.GetTasks();

      dataGridView1.DataSource = records;
      //dataGridView1.DataMember = "tasks";
    }

    private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      GetRecords();
    }

    private void button2_Click(object sender, EventArgs e) {
      var task = new Tasks {
        Name = textBox1.Text,
        Check = 0
      };

      _toDoList.AddTask(task);
      textBox1.Clear();
      GetRecords();
    }

    private void button4_Click(object sender, EventArgs e) {
      int index = dataGridView1.CurrentRow.Index;

      var taskId = dataGridView1[0, index].Value.ToString();
      var taskName = dataGridView1[1, index].Value.ToString();
      var taskCheck = dataGridView1[2, index].Value.ToString();

      long id;
      long check;

      Int64.TryParse(taskId, out id);
      Int64.TryParse(taskCheck, out check);
      
      var task = new Tasks {
        Id = id,
        Name = taskName,
        Check = check
      };

      _toDoList.EditTask(task);
      GetRecords();
    }

    private void button3_Click(object sender, EventArgs e) {
      int index = dataGridView1.CurrentRow.Index;

      var taskId = dataGridView1[0, index].Value.ToString();
      var taskName = dataGridView1[1, index].Value.ToString();
      var taskCheck = dataGridView1[2, index].Value.ToString();

      long id;
      long check;

      Int64.TryParse(taskId, out id);
      Int64.TryParse(taskCheck, out check);
      
      var task = new Tasks {
        Id = id,
        Name = taskName,
        Check = check
      };

      _toDoList.DeleteTask(task);
      GetRecords();
    }

    private void button1_Click(object sender, EventArgs e) {
            int index = dataGridView1.CurrentRow.Index;

      var taskId = dataGridView1[0, index].Value.ToString();
      var taskName = dataGridView1[1, index].Value.ToString();
      var taskCheck = dataGridView1[2, index].Value.ToString();

      long id;
      long check;

      Int64.TryParse(taskId, out id);
      Int64.TryParse(taskCheck, out check);
      
      var task = new Tasks {
        Id = id,
        Name = taskName,
        Check = check
      };

      _toDoList.ChangeStatus(task);
      GetRecords();
    }
  }
}
