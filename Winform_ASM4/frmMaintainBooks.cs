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
    public partial class frmMaintainBooks : Form
    {
        private BookDB db = new BookDB();
        private List<Book> listBook;
        public frmMaintainBooks()
        {
            InitializeComponent();
        }
        
        private void LoadBook()
        {
            //Fill data
            listBook = db.getBooks();
            dgv.DataSource = listBook;
            //Clear
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
           
            //Set value
            txtID.DataBindings.Add("Text", listBook, "BookID");
            txtName.DataBindings.Add("Text", listBook, "BookName");
            txtPrice.DataBindings.Add("Text", listBook, "BookPrice");       
        }
        private void frmMaintainBooks_Load(object sender, EventArgs e)
        {
            LoadBook();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsert frm = new frmInsert();
            frm.ShowDialog();
            LoadBook();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            db.deleteBook(id);
            LoadBook();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Book b = new Book() { BookID = id, BookName = txtName.Text, BookPrice = float.Parse(txtPrice.Text) };
            db.updateBook(b);
            LoadBook();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBookReport frm = new frmBookReport();
            frm.ShowDialog();
        }
    }
}
