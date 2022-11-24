namespace project
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.btnUnassignTask = new System.Windows.Forms.Button();
            this.lbxEmployeeTask = new System.Windows.Forms.ListBox();
            this.cbxAssignT_Ename = new System.Windows.Forms.ComboBox();
            this.cbxAssignT_Tname = new System.Windows.Forms.ComboBox();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign/Unassign Task to Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "E_name";
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Location = new System.Drawing.Point(92, 246);
            this.btnAssignTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(100, 28);
            this.btnAssignTask.TabIndex = 5;
            this.btnAssignTask.Text = "Assign";
            this.btnAssignTask.UseVisualStyleBackColor = true;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // btnUnassignTask
            // 
            this.btnUnassignTask.Location = new System.Drawing.Point(275, 246);
            this.btnUnassignTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnassignTask.Name = "btnUnassignTask";
            this.btnUnassignTask.Size = new System.Drawing.Size(100, 28);
            this.btnUnassignTask.TabIndex = 6;
            this.btnUnassignTask.Text = "Unassign";
            this.btnUnassignTask.UseVisualStyleBackColor = true;
            this.btnUnassignTask.Click += new System.EventHandler(this.btnUnassignTask_Click);
            // 
            // lbxEmployeeTask
            // 
            this.lbxEmployeeTask.FormattingEnabled = true;
            this.lbxEmployeeTask.ItemHeight = 16;
            this.lbxEmployeeTask.Location = new System.Drawing.Point(92, 302);
            this.lbxEmployeeTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxEmployeeTask.Name = "lbxEmployeeTask";
            this.lbxEmployeeTask.Size = new System.Drawing.Size(641, 180);
            this.lbxEmployeeTask.TabIndex = 7;
            // 
            // cbxAssignT_Ename
            // 
            this.cbxAssignT_Ename.FormattingEnabled = true;
            this.cbxAssignT_Ename.Location = new System.Drawing.Point(236, 165);
            this.cbxAssignT_Ename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxAssignT_Ename.Name = "cbxAssignT_Ename";
            this.cbxAssignT_Ename.Size = new System.Drawing.Size(160, 24);
            this.cbxAssignT_Ename.TabIndex = 8;
            // 
            // cbxAssignT_Tname
            // 
            this.cbxAssignT_Tname.FormattingEnabled = true;
            this.cbxAssignT_Tname.Location = new System.Drawing.Point(236, 95);
            this.cbxAssignT_Tname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxAssignT_Tname.Name = "cbxAssignT_Tname";
            this.cbxAssignT_Tname.Size = new System.Drawing.Size(160, 24);
            this.cbxAssignT_Tname.TabIndex = 9;
            // 
            // btnMainForm
            // 
            this.btnMainForm.Location = new System.Drawing.Point(838, 454);
            this.btnMainForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(131, 28);
            this.btnMainForm.TabIndex = 10;
            this.btnMainForm.Text = "Main form";
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(470, 246);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(84, 28);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.cbxAssignT_Tname);
            this.Controls.Add(this.cbxAssignT_Ename);
            this.Controls.Add(this.lbxEmployeeTask);
            this.Controls.Add(this.btnUnassignTask);
            this.Controls.Add(this.btnAssignTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.Button btnUnassignTask;
        private System.Windows.Forms.ListBox lbxEmployeeTask;
        private System.Windows.Forms.Button btnMainForm;
        public System.Windows.Forms.ComboBox cbxAssignT_Ename;
        public System.Windows.Forms.ComboBox cbxAssignT_Tname;
        private System.Windows.Forms.Button btnDisplay;
    }
}