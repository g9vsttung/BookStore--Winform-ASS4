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
    public partial class frmSearch : Form
    {
        BookDB db = new BookDB();
        List<Book> listBook;
        public frmSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content = txtSearch.Text;
            listBook=db.findBooks(content);
            LoadBook();
        }
        private void LoadBook()
        {
            dgv.DataSource = listBook;
            float total = 0;
            foreach(var b in listBook)
            {
                total += b.BookPrice;
            }
            lbTotalPrice.Text = "TotalPrice: " + total;
        }
    }
}
