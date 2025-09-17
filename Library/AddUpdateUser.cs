using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class AddUpdateUser : Form
    {
        clsUser.clsUser user = new clsUser.clsUser();
        public enum enMode
        {
            addUser = 0,
            UpdateUser=1
        }
        public int userID { get; set; }
       
        public enMode Mode { get; set; }
       
        public AddUpdateUser(int UserId)
        {
            InitializeComponent();


            if (UserId < 1)
            {
                this.Mode = enMode.addUser;
            }
            else
            {
                this.Mode= enMode.UpdateUser;
                this.userID = UserId;

            }
        }
        private void AddUpdateUser_Load(object sender, EventArgs e)
        {
            if (this.Mode == enMode.UpdateUser)
            {
                LabeMainAddUpdateUser.Text = "Update User";
                user = clsUser.clsUser.FindUserById(this.userID);
                if (user != null)
                {
                    LabelNumerUserID.Text = this.userID.ToString();
                    textBoxUserName.Text = user.UserName;
                    textBoxUserPassword.Text = user.PasswordHash;

                }
            }

            
        }

        private void btnAddUpdateUser_Click(object sender, EventArgs e)
        {
            user.UserName = textBoxUserName.Text;
            user.PasswordHash = textBoxUserPassword.Text;
            if (user.save())
            {
                MessageBox.Show("User Added!");
            }
            else
            {
                MessageBox.Show("User Not Added!");


            }

        }

        private void btnCloseUserAddForm_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
