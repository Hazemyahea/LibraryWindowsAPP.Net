using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClsBooksBussines;
namespace Library
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }
        private void refrechData()
        {
            dataGridViewBooksMain.DataSource = ClsBooksBussines.ClsBooksBussines.GetAllBooks();
        }
        private void BooksForm_Load(object sender, EventArgs e)
        {
            refrechData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateBookForm addUpdateBookForm = new AddUpdateBookForm(Convert.ToInt32(dataGridViewBooksMain.CurrentRow.Cells[0].Value));
            addUpdateBookForm.ShowDialog();
            addUpdateBookForm.Close();
            refrechData();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddUpdateBookForm addUpdateBookForm = new AddUpdateBookForm(-1);
            addUpdateBookForm.ShowDialog();
            addUpdateBookForm.Close();
            refrechData();
        }
    }
}
