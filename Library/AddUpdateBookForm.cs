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
    public partial class AddUpdateBookForm : Form
    {   
        ClsBooksBussines.ClsBooksBussines ClsBook = new ClsBooksBussines.ClsBooksBussines();
        public enum enMode
        {
            addBook=0,
            updateBook=1
        }
        public int BookId {  get; set; }
        public enMode Mode { get; set; }
        public AddUpdateBookForm(int bookId)
        {
            InitializeComponent();
            BookId = bookId;
            if (bookId > 0)
            {
                this.Mode = enMode.updateBook;
            }
        }

        private void AddUpdateBookForm_Load(object sender, EventArgs e)
        {
            if (this.Mode == enMode.updateBook)
            {
                ClsBook = ClsBooksBussines.ClsBooksBussines.Find(this.BookId);
                if (ClsBook != null)
                {
                    LabelAddUpdateBook.Text = "Update Book";
                    LabelBookIdInt.Text = this.BookId.ToString();
                    textBoxAuthor.Text = ClsBook.Author;
                    textBoxTitle.Text = ClsBook.Title;
                    textBoxCategory.Text = ClsBook.Category;
                    textBoxCopies.Text = ClsBook.CopiesAvailable.ToString();
                    textBoxPublishYear.Text =ClsBook.PublishYear.ToString();
                }
                else
                {
                    LabelAddUpdateBook.Text = "Add Book";

                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // التحقق من البيانات
            if (string.IsNullOrEmpty(textBoxTitle.Text) ||
                string.IsNullOrEmpty(textBoxAuthor.Text))
            {
                MessageBox.Show("الرجاء إدخال العنوان والمؤلف على الأقل");
                return;
            }

            // لو Add جديد
          
            // تعبئة البيانات
            ClsBook.Title = textBoxTitle.Text.Trim();
            ClsBook.Author = textBoxAuthor.Text.Trim();
            ClsBook.Category = textBoxCategory.Text.Trim();
            ClsBook.PublishYear = Convert.ToInt32(textBoxPublishYear.Text);
            ClsBook.CopiesAvailable = Convert.ToInt32(textBoxCopies.Text);



            // حفظ
            bool result = ClsBook.Save();

            if (result)
            {
                MessageBox.Show("تم الحفظ بنجاح ✅");
                this.Close();
            }
            else
            {
                MessageBox.Show("فشل في الحفظ ❌");
            }
        }
    }
}
