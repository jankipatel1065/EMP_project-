namespace project
{
    partial class Form3
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
            this.cbxAssignM_Mname = new System.Windows.Forms.ComboBox();
            this.cbxAssignM_Ename = new System.Windows.Forms.ComboBox();
            this.lbxEmployeeManager = new System.Windows.Forms.ListBox();
            this.btnAssignManager = new System.Windows.Forms.Button();
            this.btnUnassignManager = new System.Windows.Forms.Button();
            this.btnMainFrame = new System.Windows.Forms.Button();
            this.btnDisplayManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign/Unassign Manager to Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manager name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee name";
            // 
            // cbxAssignM_Mname
            // 
            this.cbxAssignM_Mname.FormattingEnabled = true;
            this.cbxAssignM_Mname.Location = new System.Drawing.Point(308, 144);
            this.cbxAssignM_Mname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxAssignM_Mname.Name = "cbxAssignM_Mname";
            this.cbxAssignM_Mname.Size = new System.Drawing.Size(180, 28);
            this.cbxAssignM_Mname.TabIndex = 3;
            // 
            // cbxAssignM_Ename
            // 
            this.cbxAssignM_Ename.FormattingEnabled = true;
            this.cbxAssignM_Ename.Location = new System.Drawing.Point(308, 218);
            this.cbxAssignM_Ename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxAssignM_Ename.Name = "cbxAssignM_Ename";
            this.cbxAssignM_Ename.Size = new System.Drawing.Size(180, 28);
            this.cbxAssignM_Ename.TabIndex = 4;
            // 
            // lbxEmployeeManager
            // 
            this.lbxEmployeeManager.FormattingEnabled = true;
            this.lbxEmployeeManager.ItemHeight = 20;
            this.lbxEmployeeManager.Location = new System.Drawing.Point(108, 431);
            this.lbxEmployeeManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxEmployeeManager.Name = "lbxEmployeeManager";
            this.lbxEmployeeManager.Size = new System.Drawing.Size(725, 184);
            this.lbxEmployeeManager.TabIndex = 5;
            // 
            // btnAssignManager
            // 
            this.btnAssignManager.Location = new System.Drawing.Point(108, 326);
            this.btnAssignManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignManager.Name = "btnAssignManager";
            this.btnAssignManager.Size = new System.Drawing.Size(112, 35);
            this.btnAssignManager.TabIndex = 6;
            this.btnAssignManager.Text = "Assign";
            this.btnAssignManager.UseVisualStyleBackColor = true;
            this.btnAssignManager.Click += new System.EventHandler(this.btnAssignManager_Click_1);
            // 
            // btnUnassignManager
            // 
            this.btnUnassignManager.Location = new System.Drawing.Point(281, 326);
            this.btnUnassignManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnassignManager.Name = "btnUnassignManager";
            this.btnUnassignManager.Size = new System.Drawing.Size(112, 35);
            this.btnUnassignManager.TabIndex = 7;
            this.btnUnassignManager.Text = "Unassign";
            this.btnUnassignManager.UseVisualStyleBackColor = true;
            this.btnUnassignManager.Click += new System.EventHandler(this.btnUnassignManager_Click);
            // 
            // btnMainFrame
            // 
            this.btnMainFrame.Location = new System.Drawing.Point(952, 581);
            this.btnMainFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainFrame.Name = "btnMainFrame";
            this.btnMainFrame.Size = new System.Drawing.Size(166, 35);
            this.btnMainFrame.TabIndex = 9;
            this.btnMainFrame.Text = "Main Form";
            this.btnMainFrame.UseVisualStyleBackColor = true;
            this.btnMainFrame.Click += new System.EventHandler(this.btnDisplayEmployee_Click);
            // 
            // btnDisplayManager
            // 
            this.btnDisplayManager.Location = new System.Drawing.Point(468, 326);
            this.btnDisplayManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplayManager.Name = "btnDisplayManager";
            this.btnDisplayManager.Size = new System.Drawing.Size(99, 29);
            this.btnDisplayManager.TabIndex = 10;
            this.btnDisplayManager.Text = "Display";
            this.btnDisplayManager.UseVisualStyleBackColor = true;
            this.btnDisplayManager.Click += new System.EventHandler(this.btnDisplayManager_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnDisplayManager);
            this.Controls.Add(this.btnMainFrame);
            this.Controls.Add(this.btnUnassignManager);
            this.Controls.Add(this.btnAssignManager);
            this.Controls.Add(this.lbxEmployeeManager);
            this.Controls.Add(this.cbxAssignM_Ename);
            this.Controls.Add(this.cbxAssignM_Mname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxEmployeeManager;
        private System.Windows.Forms.Button btnAssignManager;
        private System.Windows.Forms.Button btnUnassignManager;
        private System.Windows.Forms.Button btnMainFrame;
        public System.Windows.Forms.ComboBox cbxAssignM_Mname;
        public System.Windows.Forms.ComboBox cbxAssignM_Ename;
        private System.Windows.Forms.Button btnDisplayManager;
    }
}