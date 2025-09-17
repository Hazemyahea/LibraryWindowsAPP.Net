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
using ClsMembersBusiness;
using ClsBorrowingsBusiness;
using System.Data.SqlTypes;
namespace Library
{
    public partial class ControlBorrowes : Form
    {
        DataTable dtBooks = ClsBooksBussines.ClsBooksBussines.GetAllBooks();
        DataTable dtMember = ClsMembersBusiness.ClsMembersBusiness.GetAllMembers();
        int beforBoodID = 0;
        ClsBorrowingsBusiness.ClsBorrowingsBusiness NewBorrow = new ClsBorrowingsBusiness.ClsBorrowingsBusiness();
       public int borrowid {  get; set; }
        public enum enMode
        {
            add = 0,
            update =1
        }
        public enMode mode {  get; set; }
        public ControlBorrowes(int borrowID)
        {
            InitializeComponent();
            this.borrowid = borrowID;
            if (this.borrowid >-1)
            {
                this.mode = enMode.update;
                NewBorrow = ClsBorrowingsBusiness.ClsBorrowingsBusiness.Find(borrowID);
               

            }
        }

        private void ControlBorrowes_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dtBooks;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "BookID";

            // تحميل الأعضاء
            comboBox2.DataSource = dtMember;
            comboBox2.DisplayMember = "FullName";
            comboBox2.ValueMember = "MemberID";



            // لو في وضع Update
            if (mode == enMode.update)
            {
                if (NewBorrow != null) // ✅ اتأكد انه مش null
                {
                    comboBox1.SelectedValue = NewBorrow.BookID;
                    comboBox2.SelectedValue = NewBorrow.MemberID;
                    dateTimePicker1.Value = NewBorrow.BorrowDate;
                    dateTimePicker2.Value = NewBorrow.DueDate;
                    beforBoodID = NewBorrow.BookID;
                }
                else
                {
                    MessageBox.Show("Borrow record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // أو اعمل أي handling مناسب
                }
            }

            if (mode == enMode.add)
            {
                comboBox1.SelectedValue = -1;
                comboBox2.SelectedValue = -1;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is DataRowView)
                return;

            int bookID = Convert.ToInt32(comboBox1.SelectedValue);

            int availableCopies = ClsBooksBussines.ClsBooksBussines.AvailCopiesCount(bookID);

            LabelCopies.Text =  availableCopies.ToString();
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                NewBorrow.BookID = Convert.ToInt32(comboBox1.SelectedValue);
                NewBorrow.MemberID = Convert.ToInt32(comboBox2.SelectedValue);
                NewBorrow.BorrowDate = dateTimePicker1.Value;
                NewBorrow.DueDate = dateTimePicker2.Value;
                if (ClsBooksBussines.ClsBooksBussines.AvailCopiesCount(NewBorrow.BookID) <1)
                {
                    MessageBox.Show("Error: " + "لايوجد نسخ متاحه ");

                }
                else
                {
                    if (NewBorrow.Save())
                    {
                        // لو في وضع Update و الكتاب اتغير
                        if (mode == enMode.update && beforBoodID != NewBorrow.BookID)
                        {
                            ClsBooksBussines.ClsBooksBussines.DecreaseCopiesAvailable(NewBorrow.BookID);
                        }

                        // لو في وضع AddNew
                        if (mode == enMode.add)
                        {
                            ClsBooksBussines.ClsBooksBussines.DecreaseCopiesAvailable(NewBorrow.BookID);
                        }

                        MessageBox.Show("تم الحفظ بنجاح ✅");
                    }
                    else
                    {
                        MessageBox.Show(
                            $"لم يتم الحفظ ❌\nBookID = {NewBorrow.BookID}, MemberID = {NewBorrow.MemberID}, BorrowDate = {NewBorrow.BorrowDate}, DueDate = {NewBorrow.DueDate}"
                        );
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
