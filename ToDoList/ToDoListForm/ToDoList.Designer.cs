namespace ToDoListForm {
  partial class ToDoList {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.DataGrid = new System.Windows.Forms.DataGridView();
      this.AddBtn = new System.Windows.Forms.Button();
      this.DeleteBtn = new System.Windows.Forms.Button();
      this.EditBtn = new System.Windows.Forms.Button();
      this.NewTaskField = new System.Windows.Forms.TextBox();
      this.ChangeStatusBtn = new System.Windows.Forms.Button();
      this.ShowAllCheckBox = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // DataGrid
      // 
      this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DataGrid.Location = new System.Drawing.Point(12, 64);
      this.DataGrid.MultiSelect = false;
      this.DataGrid.Name = "DataGrid";
      this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DataGrid.Size = new System.Drawing.Size(351, 341);
      this.DataGrid.TabIndex = 0;
      this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOnStart);
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(288, 16);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(75, 23);
      this.AddBtn.TabIndex = 2;
      this.AddBtn.Text = "Add";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddTask);
      // 
      // DeleteBtn
      // 
      this.DeleteBtn.Location = new System.Drawing.Point(288, 411);
      this.DeleteBtn.Name = "DeleteBtn";
      this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
      this.DeleteBtn.TabIndex = 3;
      this.DeleteBtn.Text = "Delete";
      this.DeleteBtn.UseVisualStyleBackColor = true;
      this.DeleteBtn.Click += new System.EventHandler(this.DeleteTask);
      // 
      // EditBtn
      // 
      this.EditBtn.Location = new System.Drawing.Point(13, 411);
      this.EditBtn.Name = "EditBtn";
      this.EditBtn.Size = new System.Drawing.Size(75, 23);
      this.EditBtn.TabIndex = 4;
      this.EditBtn.Text = "Edit";
      this.EditBtn.UseVisualStyleBackColor = true;
      this.EditBtn.Click += new System.EventHandler(this.EditTask);
      // 
      // NewTaskField
      // 
      this.NewTaskField.Location = new System.Drawing.Point(12, 18);
      this.NewTaskField.Name = "NewTaskField";
      this.NewTaskField.Size = new System.Drawing.Size(270, 20);
      this.NewTaskField.TabIndex = 5;
      // 
      // ChangeStatusBtn
      // 
      this.ChangeStatusBtn.Location = new System.Drawing.Point(111, 411);
      this.ChangeStatusBtn.Name = "ChangeStatusBtn";
      this.ChangeStatusBtn.Size = new System.Drawing.Size(150, 23);
      this.ChangeStatusBtn.TabIndex = 6;
      this.ChangeStatusBtn.Text = "Change Status";
      this.ChangeStatusBtn.UseVisualStyleBackColor = true;
      this.ChangeStatusBtn.Click += new System.EventHandler(this.ChangeTaskStatus);
      // 
      // ShowAllCheckBox
      // 
      this.ShowAllCheckBox.AutoSize = true;
      this.ShowAllCheckBox.Checked = true;
      this.ShowAllCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ShowAllCheckBox.Location = new System.Drawing.Point(13, 41);
      this.ShowAllCheckBox.Name = "ShowAllCheckBox";
      this.ShowAllCheckBox.Size = new System.Drawing.Size(162, 17);
      this.ShowAllCheckBox.TabIndex = 7;
      this.ShowAllCheckBox.Text = "Pokazać wszystkie zadania?";
      this.ShowAllCheckBox.UseVisualStyleBackColor = true;
      this.ShowAllCheckBox.CheckedChanged += new System.EventHandler(this.DisplayChange);
      // 
      // ToDoList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(375, 438);
      this.Controls.Add(this.ShowAllCheckBox);
      this.Controls.Add(this.ChangeStatusBtn);
      this.Controls.Add(this.NewTaskField);
      this.Controls.Add(this.EditBtn);
      this.Controls.Add(this.DeleteBtn);
      this.Controls.Add(this.AddBtn);
      this.Controls.Add(this.DataGrid);
      this.Name = "ToDoList";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ToDoList";
      ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView DataGrid;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.Button DeleteBtn;
    private System.Windows.Forms.Button EditBtn;
    private System.Windows.Forms.TextBox NewTaskField;
    private System.Windows.Forms.Button ChangeStatusBtn;
    private System.Windows.Forms.CheckBox ShowAllCheckBox;
  }
}

