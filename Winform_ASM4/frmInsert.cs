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
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            float price = float.Parse(txtPrice.Text);
            BookDB db = new BookDB();
            db.addNewBook(new Book() { BookName = name ,BookPrice=price}) ;
            this.Close();
        }
    }
}
