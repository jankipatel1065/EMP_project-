using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        List<employee> eList = new List<employee>();
        List<manager> mList = new List<manager>();
        List<task> tList = new List<task>();

        private Form2 form2;
        private Form3 form3;
        private Form4 form4;
        public Form1()
        {
            InitializeComponent();
            this.form2 = new Form2(this, eList, tList);
            this.form3 = new Form3(this, eList, mList);
            this.form4 = new Form4(this,eList, mList, tList);
        }

        private void btnEadd_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValidDate = regex.IsMatch(txtEjoiningDate.Text.Trim());

            if (txtEid.Text == "" || txtEname.Text == "" || txtEdepartment.Text == "" || txtEaddress.Text == "" || txtEjoiningDate.Text == "")
            {
                MessageBox.Show("Enter valid input, field is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (eList.Exists(x => x.E_ID == Int32.Parse(txtEid.Text)))
            {
                MessageBox.Show("Employee Id already exists!!!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(txtEid.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Enter valid input, only numbers in Id!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEname.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid input, only string in name!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEdepartment.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid input, only string in department!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEaddress.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid input, only string in address!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(isValidDate))
            {
                MessageBox.Show("Enter valid input, date is not in correct format!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eList.Add(new employee() { E_ID = Int32.Parse(txtEid.Text), E_Name = txtEname.Text, E_add = txtEaddress.Text, E_department = txtEdepartment.Text, E_joiningDate = txtEjoiningDate.Text });
                MessageBox.Show("Employee data added successfully!!!!!");
                form3.cbxAssignM_Ename.Items.Clear();
                form2.cbxAssignT_Ename.Items.Clear();

                if (eList.Count > 0)
                {
                    foreach (var c in eList)
                    {
                        form2.cbxAssignT_Ename.Items.Add(c.E_Name);
                        form3.cbxAssignM_Ename.Items.Add(c.E_Name);
                    }
                }
            }
            txtEid.Clear();
            txtEname.Clear();
            txtEdepartment.Clear();
            txtEaddress.Clear();
            txtEjoiningDate.Clear();
        }

        private void btnEremove_Click(object sender, EventArgs e)
        {
            if (txtEid.Text == "")
            {
                MessageBox.Show("Enter valid input, employee id is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(eList.Exists(x => x.E_ID == Int32.Parse(txtEid.Text))))
            {
                MessageBox.Show("Employee does not exist!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eList.Remove(eList.Find(x => x.E_ID == Int32.Parse(txtEid.Text)));
            }
            txtEid.Clear();
        }

        private void btnEdisplay_Click(object sender, EventArgs e)
        {
            lbxEmployee.Items.Clear();
            if (eList.Count == 0)
            {
                MessageBox.Show("Employee list is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbxEmployee.Items.Clear();

                eList.ForEach(x => lbxEmployee.Items.Add(x.E_ID + " " + x.E_Name + " " + x.E_add + " " + x.E_department + " " + x.E_joiningDate));
            }
        }

        private void btnEclear_Click(object sender, EventArgs e)
        {
            if (eList.Count == 0)
            {
                MessageBox.Show("Employee list is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eList.Clear();
            }
        }

        private void btnMadd_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValidDate = regex.IsMatch(txtMjoinigDate.Text.Trim());

            Regex regexPhone = new Regex("^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            bool isValidPhone = regexPhone.IsMatch(txtMphone.Text.Trim());

            if (txtMid.Text == "" || txtMname.Text == "" || txtMaddress.Text == "" || txtMphone.Text == "" || txtMjoinigDate.Text == "")
            {
                MessageBox.Show("Enter valid input, field is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mList.Exists(x => x.M_id == Int32.Parse(txtMid.Text)))
            {
                MessageBox.Show("Manager Id already exists!!!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(txtMid.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Enter valid input, only numbers in Id!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMname.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid input, only string in name!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaddress.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid input, only string in address!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(isValidPhone))
            {
                MessageBox.Show("Enter valid input, phone is not in correct format!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(isValidDate))
            {
                MessageBox.Show("Enter valid input, date is not in correct format!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mList.Add(new manager() { M_id = Int32.Parse(txtMid.Text), M_name = txtMname.Text, M_add = txtMaddress.Text, M_phone = txtMphone.Text, M_joiningDate = txtMjoinigDate.Text });
                MessageBox.Show("Manager data added successfully!!!!!");
                form3.cbxAssignM_Mname.Items.Clear();
                if (mList.Count > 0)
                {
                    foreach (var c in mList)
                    {
                        form3.cbxAssignM_Mname.Items.Add(c.M_name);
                    }
                }
            }
            txtMid.Clear();
            txtMname.Clear();
            txtMaddress.Clear();
            txtMphone.Clear();
            txtMjoinigDate.Clear();
        }

        private void btnMdisplay_Click(object sender, EventArgs e)
        {
            lbxManager.Items.Clear();
            if (mList.Count == 0)
            {
                MessageBox.Show("Manager list is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbxManager.Items.Clear();
                mList.ForEach(x => lbxManager.Items.Add(x.M_id + " " + x.M_name + " " + x.M_add + " " + x.M_phone + " " + x.M_joiningDate));
            }
        }

        private void btnMremove_Click(object sender, EventArgs e)
        {
            if (txtMid.Text == "")
            {
                MessageBox.Show("Enter valid input, manager id is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(mList.Exists(x => x.M_id == Int32.Parse(txtMid.Text))))
            {
                MessageBox.Show("Manager does not exist!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mList.Remove(mList.Find(x => x.M_id == Int32.Parse(txtMid.Text)));
            }
            txtMid.Clear();
        }

        private void btnMclear_Click(object sender, EventArgs e)
        {
            if (mList.Count == 0)
            {
                MessageBox.Show("Manager list is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mList.Clear();
            }
        }

        private void btnTadd_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValidStartDate = regex.IsMatch(txtTstartDate.Text.Trim());
            bool isValidEndDate = regex.IsMatch(txtTendDate.Text.Trim());

            if (txtTname.Text == "" || txtTdescription.Text == "" || txtTstatus.Text == "" || txtTstartDate.Text == "" || txtTendDate.Text == "")
            {
                MessageBox.Show("Enter valid input, field is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tList.Exists(x => x.T_name == txtTname.Text))
            {
                MessageBox.Show("Task already exists!!!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTname.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid input, only string in name!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTdescription.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid input, only string in description!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTstatus.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid input, only string in status!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(isValidStartDate))
            {
                MessageBox.Show("Enter valid input, start date is not in correct format!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(isValidEndDate))
            {
                MessageBox.Show("Enter valid input, end date is not in correct format!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tList.Add(new task() { T_name = txtTname.Text, T_status = txtTstatus.Text, T_description = txtTdescription.Text, T_startDate = txtTstartDate.Text, T_endDate = txtTendDate.Text });
                MessageBox.Show("Task data added successfully!!!!!");
                form2.cbxAssignT_Tname.Items.Clear();
                if (tList.Count > 0)
                {
                    foreach (var c in tList)
                    {
                        form2.cbxAssignT_Tname.Items.Add(c.T_name);
                    }
                }
            }
            txtTname.Clear();
            txtTdescription.Clear();
            txtTstatus.Clear();
            txtTstartDate.Clear();
            txtTendDate.Clear();
        }

        private void btnTremove_Click(object sender, EventArgs e)
        {
            if (txtTname.Text == "")
            {
                MessageBox.Show("Enter valid input,task name is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(tList.Exists(x => x.T_name == txtTname.Text)))
            {
                MessageBox.Show("Task does not exist!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tList.Remove(tList.Find(x => x.T_name == txtTname.Text));
            }
            txtTname.Clear();
        }

        private void btnTdisplay_Click(object sender, EventArgs e)
        {
            lbxTask.Items.Clear();
            if (tList.Count == 0)
            {
                MessageBox.Show("Task list is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbxTask.Items.Clear();
                tList.ForEach(x => lbxTask.Items.Add(x.T_name + " " + x.T_status + " " + x.T_description + " " + x.T_startDate + " " + x.T_endDate));
            }
        }

        private void btnTclear_Click(object sender, EventArgs e)
        {
            if (tList.Count == 0)
            {
                MessageBox.Show("Task list is empty!!!!", "Error box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tList.Clear();
            }
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
            lbxEmployee.Items.Clear();
            lbxManager.Items.Clear();
            lbxTask.Items.Clear();
        }

        private void btnAssignManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
            lbxEmployee.Items.Clear();
            lbxManager.Items.Clear();
            lbxTask.Items.Clear();
        }

        private void btnDisplayEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            form4.Show();
            lbxEmployee.Items.Clear();
            lbxManager.Items.Clear();
            lbxTask.Items.Clear();
        }
    }
         
}
