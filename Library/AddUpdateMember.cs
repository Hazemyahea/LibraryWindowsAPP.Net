using ClsMembersBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClsMembersBusiness;
namespace Library
{
    public partial class AddUpdateMember : Form
    {
        ClsMembersBusiness.ClsMembersBusiness ClsMember = new ClsMembersBusiness.ClsMembersBusiness();
        public enum enMode
        {
            addMember = 0,
            updateMember = 1
        }

        public int MemberID { get; set; }
        public enMode Mode { get; set; }
        public AddUpdateMember(int MemberId)
        {
            InitializeComponent();
            MemberID = MemberId;

            if (MemberID > 0)
                this.Mode = enMode.updateMember;
            else
                this.Mode = enMode.addMember;
        }

        private void AddUpdateMember_Load(object sender, EventArgs e)
        {
            if (this.Mode == enMode.updateMember)
            {
                ClsMember = ClsMembersBusiness.ClsMembersBusiness.Find(this.MemberID);

                if (ClsMember != null)
                {
                    LabelAddUpdate.Text = "Update Member";
                    labelMebmeIDInt.Text = this.MemberID.ToString();

                    textBoxFullName.Text = ClsMember.FullName;
                    textBoxPhone.Text = ClsMember.Phone;
                    textBoxEmail.Text = ClsMember.Email;
                    textBoxJoinDate.Text = ClsMember.JoinDate.ToString();
                }
            }
            else
            {
                LabelAddUpdate.Text = "Add Member";
                textBoxJoinDate.Text = DateTime.Now.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClsMember.FullName = textBoxFullName.Text;
            ClsMember.Email = textBoxEmail.Text;
            ClsMember.Phone = textBoxPhone.Text;
            ClsMember.JoinDate = DateTime.Now;
            if (ClsMember.Save())
            {
                MessageBox.Show("تم الحفظ بنجاح.", "نجاح",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ.", "خطأ",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
