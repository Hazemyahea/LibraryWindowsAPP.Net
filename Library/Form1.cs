using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsUser;
namespace Library
{
    public partial class DashBordForm : Form
    {
        public DashBordForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
          
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm NewUserForm = new UserForm();
            NewUserForm.MdiParent = this;
            NewUserForm.Show();

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm newBookForm = new BooksForm();
            newBookForm.MdiParent = this;
            newBookForm.Show();

        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm newMemberForm = new MemberForm();
            newMemberForm.MdiParent = this;
            newMemberForm.Show();
        }

        private void borrowingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainBorrowingForm newBorrowingForm = new MainBorrowingForm();
            newBorrowingForm.MdiParent = this;
            newBorrowingForm.Show();
        }
    }
}
