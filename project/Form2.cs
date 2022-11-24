using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        List<employee> eList2 = new List<employee>();
        List<task> task2 = new List<task>();

        string ComboTask;
        string ComboEmp;

        public Form2(Form1 form1, List<employee> elist, List<task> tList)
        {
            InitializeComponent();
            this.form1 = form1;
            eList2 = elist;
            task2 = tList;
        }
       
        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
            lbxEmployeeTask.Items.Clear();
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            if (cbxAssignT_Tname.SelectedIndex == -1 || cbxAssignT_Ename.SelectedIndex == -1)
            {
                MessageBox.Show("Please select value to assign!!!");
            }
            else
            {
                ComboTask = cbxAssignT_Tname.SelectedItem.ToString();
                ComboEmp = cbxAssignT_Ename.SelectedItem.ToString();
                employee eName = eList2.Find(x => x.E_Name.Equals(ComboEmp));
                task tName = task2.Find(x => x.T_name.Equals(ComboTask));
                Boolean isDuplicate = false;
                foreach (var c in eName.TaskAssign)
                {
                    if (c.T_name == ComboTask)
                    {
                        isDuplicate = true;
                    }
                }
                if (!isDuplicate)
                {
                    eName.TaskAssign.Add(tName);
                    MessageBox.Show("Task is assigned!!!");
                }
                else
                {
                    MessageBox.Show("Task already assigned!!!");
                }
                cbxAssignT_Ename.ResetText();
                cbxAssignT_Tname.ResetText();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (cbxAssignT_Tname.SelectedIndex == -1 || cbxAssignT_Ename.SelectedIndex == -1)
            {
                MessageBox.Show("Please select value to display!!!");
            }
            else {         
                lbxEmployeeTask.Items.Clear();
                employee eName = eList2.Find(x => x.E_Name.Equals(ComboEmp));

                foreach (var task in eList2)
                {
                    foreach (var c in task.TaskAssign)
                    {
                        lbxEmployeeTask.Items.Add(task.E_Name + " is assigned " + c.T_name + " task.");
                    }
                }
            }
        }

        private void btnUnassignTask_Click(object sender, EventArgs e)
        {
            if (cbxAssignT_Tname.SelectedIndex == -1 || cbxAssignT_Ename.SelectedIndex == -1)
            {
                MessageBox.Show("Please select value to unassign!!!");
            }
            else
            {
                ComboTask = cbxAssignT_Tname.SelectedItem.ToString();
                ComboEmp = cbxAssignT_Ename.SelectedItem.ToString();
                employee eName = eList2.Find(x => x.E_Name.Equals(ComboEmp));
                task tName = task2.Find(x => x.T_name.Equals(ComboTask));
                Boolean isDuplicate = false;

                foreach (var task in eName.TaskAssign)
                {
                    if (task.T_name == ComboTask)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate == true)
                {
                    eName.TaskAssign.Remove(tName);
                    MessageBox.Show("Task is unassigned!!!");
                }
                else
                {
                    MessageBox.Show("Task already unassigned!!!!");
                }
                cbxAssignT_Ename.ResetText();
                cbxAssignT_Tname.ResetText();
            }
        }
    }
}
