using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
namespace Winform_ASM4
{
    public partial class frmChangeAccount : Form
    {
        private Employee emp;
        public frmChangeAccount(Employee e)
        {
            InitializeComponent();
            emp = e;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDB db = new EmployeeDB();
            emp.EmpPassword = txtPass.Text;
            bool check = db.UpdateEmp(emp);
            if (check)
            {
                txtPass.Text = emp.EmpPassword;
                lbRs.Text = "Success!";
            }
            else
            {
                lbRs.Text = "Fail!";
            }
        }

        private void frmChangeAccount_Load(object sender, EventArgs e)
        {
            txtName.Text = emp.EmpID;
            txtPass.Text = emp.EmpPassword;
        }
    }
}
