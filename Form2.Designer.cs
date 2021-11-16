namespace Part_10._5_Student_Forms
{
    partial class FormAddStudent
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(11, 5);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(151, 212);
            this.lstStudents.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(299, 31);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(126, 27);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 229);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstStudents);
            this.Name = "FormAddStudent";
            this.Text = "Add a student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDone;
    }
}