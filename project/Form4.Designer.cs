namespace project
{
    partial class Form4
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
            this.txtDisplayE_Ename = new System.Windows.Forms.TextBox();
            this.btnDisplayE = new System.Windows.Forms.Button();
            this.lbxDisplayEmployee = new System.Windows.Forms.ListBox();
            this.btnMainFrame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display details of Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee name";
            // 
            // txtDisplayE_Ename
            // 
            this.txtDisplayE_Ename.Location = new System.Drawing.Point(188, 138);
            this.txtDisplayE_Ename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDisplayE_Ename.Name = "txtDisplayE_Ename";
            this.txtDisplayE_Ename.Size = new System.Drawing.Size(132, 22);
            this.txtDisplayE_Ename.TabIndex = 2;
            // 
            // btnDisplayE
            // 
            this.btnDisplayE.Location = new System.Drawing.Point(39, 197);
            this.btnDisplayE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayE.Name = "btnDisplayE";
            this.btnDisplayE.Size = new System.Drawing.Size(100, 28);
            this.btnDisplayE.TabIndex = 3;
            this.btnDisplayE.Text = "Display";
            this.btnDisplayE.UseVisualStyleBackColor = true;
            this.btnDisplayE.Click += new System.EventHandler(this.btnDisplayE_Click);
            // 
            // lbxDisplayEmployee
            // 
            this.lbxDisplayEmployee.FormattingEnabled = true;
            this.lbxDisplayEmployee.ItemHeight = 16;
            this.lbxDisplayEmployee.Location = new System.Drawing.Point(39, 252);
            this.lbxDisplayEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxDisplayEmployee.Name = "lbxDisplayEmployee";
            this.lbxDisplayEmployee.Size = new System.Drawing.Size(1000, 180);
            this.lbxDisplayEmployee.TabIndex = 4;
            // 
            // btnMainFrame
            // 
            this.btnMainFrame.Location = new System.Drawing.Point(888, 484);
            this.btnMainFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMainFrame.Name = "btnMainFrame";
            this.btnMainFrame.Size = new System.Drawing.Size(121, 28);
            this.btnMainFrame.TabIndex = 5;
            this.btnMainFrame.Text = "Main Form";
            this.btnMainFrame.UseVisualStyleBackColor = true;
            this.btnMainFrame.Click += new System.EventHandler(this.btnAssignMangerE_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnMainFrame);
            this.Controls.Add(this.lbxDisplayEmployee);
            this.Controls.Add(this.btnDisplayE);
            this.Controls.Add(this.txtDisplayE_Ename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDisplayE_Ename;
        private System.Windows.Forms.Button btnDisplayE;
        private System.Windows.Forms.ListBox lbxDisplayEmployee;
        private System.Windows.Forms.Button btnMainFrame;
    }
}