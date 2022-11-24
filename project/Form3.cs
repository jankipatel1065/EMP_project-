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

namespace project
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        List<employee> elist3 = new List<employee>();
        List<manager> mlist3 = new List<manager>();
        string ComboManager;
        string ComboEmp;
        public Form3(Form1 form1, List<employee> eList, List<manager> mlist)
        {
            InitializeComponent();
            this.form1 = form1;
            elist3 = eList;
            mlist3 = mlist;
        }

        private void btnDisplayEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
            lbxEmployeeManager.Items.Clear();
        }

        private void btnAssignManager_Click_1(object sender, EventArgs e)
        {
            if (cbxAssignM_Ename.SelectedIndex == -1 || cbxAssignM_Mname.SelectedIndex == -1)
            {
                MessageBox.Show("Please select value to assign!!!");
            }
            else
            {
                ComboManager = cbxAssignM_Mname.SelectedItem.ToString();
                ComboEmp = cbxAssignM_Ename.SelectedItem.ToString();
                employee eName = elist3.Find(x => x.E_Name.Equals(ComboEmp));
                manager MName = mlist3.Find(x => x.M_name.Equals(ComboManager));
                Boolean isDuplicate = false;
                Boolean isAssign = false;
                foreach (var c in eName.ManagerAssign)
                {
                    if (c.M_name == ComboManager)
                    {
                        isDuplicate = true;
                    }
                    if (c.M_name != null)
                    {
                        isAssign = true;
                    }
                    else
                    {
                        isAssign = false;
                    }
                }

                if (isAssign == true)
                {
                    MessageBox.Show("Manager is already assigned!!!");
                    isDuplicate = true;
                }
                if (isDuplicate == false)
                {
                    eName.ManagerAssign.Add(MName);
                    MessageBox.Show("Manager is assigned!!!");
                }

                cbxAssignM_Ename.ResetText();
                cbxAssignM_Mname.ResetText();
            }
        }

        private void btnUnassignManager_Click(object sender, EventArgs e)
        {
            if (cbxAssignM_Ename.SelectedIndex == -1 || cbxAssignM_Mname.SelectedIndex == -1)
            {
                MessageBox.Show("Please select value to unassign!!!");
            }
            else
            {
                ComboManager = cbxAssignM_Mname.SelectedItem.ToString();
                ComboEmp = cbxAssignM_Ename.SelectedItem.ToString();
                employee eName = elist3.Find(x => x.E_Name.Equals(ComboEmp));
                manager MName = mlist3.Find(x => x.M_name.Equals(ComboManager));
                Boolean isDuplicate = false;
                foreach (var c in eName.ManagerAssign)
                {
                    if (c.M_name == ComboManager)
                    {
                        isDuplicate = true;
                    }
                }
                if (isDuplicate == true)
                {
                    eName.ManagerAssign.Remove(MName);
                    MessageBox.Show("Manager unassigned!!!");
                }
                else
                {
                    MessageBox.Show("Manager already unassigned!!!");
                }
                cbxAssignM_Ename.ResetText();
                cbxAssignM_Mname.ResetText();
            }
        }  
        private void btnDisplayManager_Click_1(object sender, EventArgs e)
        {
            if (cbxAssignM_Ename.SelectedIndex == -1 || cbxAssignM_Mname.SelectedIndex == -1)
            {
                MessageBox.Show("Please select value to display!!!");
            }
            else
            {
                lbxEmployeeManager.Items.Clear();
                employee eName = elist3.Find(x => x.E_Name.Equals(ComboEmp));

                foreach (var task in elist3)
                {
                    foreach (var c in task.ManagerAssign)
                    {
                        lbxEmployeeManager.Items.Add(task.E_Name + " is assigned " + c.M_name + " manager.");
                    }
                }
            }
        }
    }
}
