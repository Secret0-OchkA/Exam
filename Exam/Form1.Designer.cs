namespace Exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_test = new DataGridView();
            button_Add = new Button();
            button_Update = new Button();
            button_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_test).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_test
            // 
            dataGridView_test.AllowUserToAddRows = false;
            dataGridView_test.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_test.Location = new Point(12, 12);
            dataGridView_test.Name = "dataGridView_test";
            dataGridView_test.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_test.Size = new Size(500, 150);
            dataGridView_test.TabIndex = 0;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(28, 193);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 1;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(135, 193);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(75, 23);
            button_Update.TabIndex = 2;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(238, 193);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 3;
            button_delete.Text = "delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_delete);
            Controls.Add(button_Update);
            Controls.Add(button_Add);
            Controls.Add(dataGridView_test);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_test).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_test;
        private Button button_Add;
        private Button button_Update;
        private Button button_delete;
    }
}