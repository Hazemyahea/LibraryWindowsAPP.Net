using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClsBorrowingsBusiness;
using ClsBooksBussines;
namespace Library
{
    public partial class MainBorrowingForm : Form
    {
        public MainBorrowingForm()
        {
            InitializeComponent();
        }
        private void _refrechDate()
        {
            dataGridViewMainBorrowing.DataSource = ClsBorrowingsBusiness.ClsBorrowingsBusiness.GetAllBorrowings();

            if (dataGridViewMainBorrowing.Columns.Count > 0)
            {
                if (dataGridViewMainBorrowing.Columns.Contains("BookID"))
                    dataGridViewMainBorrowing.Columns["BookID"].Visible = false;

            }

        }
        private void MainBorrowingForm_Load(object sender, EventArgs e)
        {
            _refrechDate();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e){
            if (dataGridViewMainBorrowing.CurrentRow.Cells["ReturnDate"].Value != DBNull.Value)
            {
                MessageBox.Show("تم استرجاع هذا الكتاب مسبقاً ✅", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ClsBorrowingsBusiness.ClsBorrowingsBusiness.ReutrnBook(Convert.ToInt32(dataGridViewMainBorrowing.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("تم تسجيل إرجاع الكتاب بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ClsBooksBussines.ClsBooksBussines.increaseCopiesAvailable(Convert.ToInt32(dataGridViewMainBorrowing.CurrentRow.Cells["BookID"].Value)))
                {
                    MessageBox.Show(Convert.ToString(dataGridViewMainBorrowing.CurrentRow.Cells["BookID"].Value));

                }
                _refrechDate(); // عشان تعيد تحميل البيانات في DataGridView
            }
            else
            {
                MessageBox.Show("فشل في تحديث حالة الكتاب ❌", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlBorrowes newCon = new ControlBorrowes(-1);
            newCon.ShowDialog();
            newCon.Close();
            _refrechDate();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlBorrowes newCon = new ControlBorrowes(Convert.ToInt32(dataGridViewMainBorrowing.CurrentRow.Cells[0].Value));
            newCon.ShowDialog();
            newCon.Close();
            _refrechDate();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (ClsBorrowingsBusiness.ClsBorrowingsBusiness.Delete(Convert.ToInt32(dataGridViewMainBorrowing.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("تم مسح و إرجاع الكتاب بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ClsBooksBussines.ClsBooksBussines.increaseCopiesAvailable(Convert.ToInt32(dataGridViewMainBorrowing.CurrentRow.Cells["BookID"].Value)))
                {
                    MessageBox.Show(Convert.ToString(dataGridViewMainBorrowing.CurrentRow.Cells["BookID"].Value));

                }
                _refrechDate(); 
            }
            else
            {
                MessageBox.Show("فشل في تحديث حالة الكتاب ❌", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _refrechDate();

        }
    }
}
