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
    public partial class Form4 : Form
    {
        private Form1 form1;
        List<employee> eList4 = new List<employee>();
        List<manager> mLsit4 = new List<manager>();
        List<task> tList4 = new List<task>();
        public Form4(Form1 form1,List<employee> eList, List<manager> mList, List<task> tList)
        {
            InitializeComponent();
            this.form1 = form1;
            eList4 = eList;
            mLsit4 = mList;
            tList4 = tList;
        }

        private void btnAssignMangerE_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
            lbxDisplayEmployee.Items.Clear();
        }

        private void btnDisplayE_Click(object sender, EventArgs e)
        {
            lbxDisplayEmployee.Items.Clear();   
            Boolean flag = true;

            if (eList4.Count > 0)
            {
                foreach (var c in eList4)
                {
                    if (txtDisplayE_Ename.Text.Equals(c.E_Name))
                    {
                        lbxDisplayEmployee.Items.Add(c);

                        foreach (var p in c.TaskAssign)
                        {
                            lbxDisplayEmployee.Items.Clear();
                            lbxDisplayEmployee.Items.Add(c + ", Task : " + p.T_name);

                            foreach (var y in c.ManagerAssign)
                            {
                                lbxDisplayEmployee.Items.Clear();
                                if (txtDisplayE_Ename.Text.Equals(c.E_Name))
                                {
                                    lbxDisplayEmployee.Items.Add(c + ", Task : " + p.T_name + ", Manager : " + y.M_name);
                                }
                            }
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                    txtDisplayE_Ename.Clear();
                }
            }
            else
            {
                flag = false;
            }
            if (flag == false)
            {
                MessageBox.Show("Employee is not in a list!!!!");
            }
        }
    }
}
