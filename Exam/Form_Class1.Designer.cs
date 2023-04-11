namespace Exam
{
    partial class Form_Class1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Text = new TextBox();
            button_Ok = new Button();
            button_Cancel = new Button();
            SuspendLayout();
            // 
            // textBox_Text
            // 
            textBox_Text.Location = new Point(12, 23);
            textBox_Text.Name = "textBox_Text";
            textBox_Text.Size = new Size(156, 23);
            textBox_Text.TabIndex = 0;
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(12, 70);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(75, 23);
            button_Ok.TabIndex = 1;
            button_Ok.Text = "Ok";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(93, 70);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 2;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // Form_Class1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 123);
            Controls.Add(button_Cancel);
            Controls.Add(button_Ok);
            Controls.Add(textBox_Text);
            Name = "Form_Class1";
            Text = "Form_Class1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Ok;
        private Button button_Cancel;
        internal protected TextBox textBox_Text;
    }
}