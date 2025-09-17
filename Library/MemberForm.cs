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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }
        private void _refrechData()
        {
            dataGridViewMebmer.DataSource = ClsMembersBusiness.ClsMembersBusiness.GetAllMembers();
        }
        private void MemberForm_Load(object sender, EventArgs e)
        {
            _refrechData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateMember addUpdateMember = new AddUpdateMember(Convert.ToInt32(dataGridViewMebmer.CurrentRow.Cells[0].Value));
            addUpdateMember.ShowDialog();
            addUpdateMember.Close();
            _refrechData();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddUpdateMember addUpdateMember = new AddUpdateMember(-1);
            addUpdateMember.ShowDialog();
            addUpdateMember.Close();
            _refrechData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsMembersBusiness.ClsMembersBusiness.Delete(Convert.ToInt32(dataGridViewMebmer.CurrentRow.Cells[0].Value));
            _refrechData();
        }
    }
}
