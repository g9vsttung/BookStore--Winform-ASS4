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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            string EmpID = txtEmpID.Text;
            string pass = txtPassword.Text;
            EmployeeDB db = new EmployeeDB();
            string role = db.CheckLogin(EmpID, pass);
            if (role == "")
            {
                lbError.Text = "Sorry, this account is not exist!";
            }else if(role == "admin")
            {
                this.Hide();
                frmMaintainBooks frm = new frmMaintainBooks();              
                frm.ShowDialog();
                

            }
            else if(role == "employee")
            {
                this.Hide();
                Employee ee=new Employee() { EmpID = EmpID, EmpPassword = pass };
                frmChangeAccount frm = new frmChangeAccount(ee);
                frm.ShowDialog();
            }
        }
    }
}
