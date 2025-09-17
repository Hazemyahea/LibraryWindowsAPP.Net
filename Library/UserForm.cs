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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private void refrechData()
        {
            dataGridUsers.DataSource = clsUser.clsUser.GetAllUsers();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            refrechData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "هل أنت متأكد أنك تريد حذف هذا المستخدم؟",
           "تأكيد الحذف",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                clsUser.clsUser.DeleteUser(Convert.ToInt32(dataGridUsers.CurrentRow.Cells[0].Value));
               

            }
            refrechData();

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUpdateUser addUpdateUserForm = new AddUpdateUser(-1);
            addUpdateUserForm.ShowDialog();
            addUpdateUserForm.Close();
            refrechData();
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(dataGridUsers.CurrentRow.Cells[0].Value);
            AddUpdateUser addUpdateUserForm = new AddUpdateUser(userid);
            addUpdateUserForm.ShowDialog();
            addUpdateUserForm.Close();
            refrechData();
        }
    }
}
