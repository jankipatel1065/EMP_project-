using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class employee
    {
        List<task> tasks;
        task t = new task();
        manager m = new manager();
        public employee()
        {
            TaskAssign = new List<task>();
            ManagerAssign = new List<manager>();
        }
        public int E_ID { get; set; } 
        public string E_Name { get; set; }
        public string E_add { get; set; }
        public string E_department { get; set; }
        public string E_joiningDate { get; set; }
        public string taskAssign { get; set; }
        public string managerName { get; set; }
        public List<task> TaskAssign { get; set; }
        public List<manager> ManagerAssign { get; set; }

        public override string ToString()//override method
        {
            return ("Id : " + E_ID + ", Employee name : " + E_Name + ", Address : " + E_add +", Department : " + E_department + 
                ", Joining date: " + E_joiningDate ) ; 
        }



       
        }
       


    }


