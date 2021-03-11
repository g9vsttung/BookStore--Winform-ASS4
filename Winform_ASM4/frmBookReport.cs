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
    public partial class frmBookReport : Form
    {
        private BookDB db = new BookDB();
        private List<Book> listBook;
        public frmBookReport()
        {
            InitializeComponent();
        }
        private void LoadBook()
        {
            //Fill data
            listBook = db.getBooks();
            listBook.Sort();
            dgv.DataSource = listBook;
           
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void frmBookReport_Load(object sender, EventArgs e)
        {
            LoadBook();
        }
    }
}
