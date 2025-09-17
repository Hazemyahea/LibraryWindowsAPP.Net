namespace Library
{
    partial class ControlBorrowes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LabelAvailCopis = new System.Windows.Forms.Label();
            this.LabelCopies = new System.Windows.Forms.Label();
            this.LabelBookName = new System.Windows.Forms.Label();
            this.LabelBorrowDate = new System.Windows.Forms.Label();
            this.LabelReutrnDate = new System.Windows.Forms.Label();
            this.LabelMemberName = new System.Windows.Forms.Label();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(183, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 190);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // LabelAvailCopis
            // 
            this.LabelAvailCopis.AutoSize = true;
            this.LabelAvailCopis.Location = new System.Drawing.Point(210, 41);
            this.LabelAvailCopis.Name = "LabelAvailCopis";
            this.LabelAvailCopis.Size = new System.Drawing.Size(73, 13);
            this.LabelAvailCopis.TabIndex = 4;
            this.LabelAvailCopis.Text = "Avail Copis = ";
            // 
            // LabelCopies
            // 
            this.LabelCopies.AutoSize = true;
            this.LabelCopies.Location = new System.Drawing.Point(289, 41);
            this.LabelCopies.Name = "LabelCopies";
            this.LabelCopies.Size = new System.Drawing.Size(13, 13);
            this.LabelCopies.TabIndex = 5;
            this.LabelCopies.Text = "0";
            // 
            // LabelBookName
            // 
            this.LabelBookName.AutoSize = true;
            this.LabelBookName.Location = new System.Drawing.Point(12, 9);
            this.LabelBookName.Name = "LabelBookName";
            this.LabelBookName.Size = new System.Drawing.Size(60, 13);
            this.LabelBookName.TabIndex = 6;
            this.LabelBookName.Text = "Book Name";
            // 
            // LabelBorrowDate
            // 
            this.LabelBorrowDate.AutoSize = true;
            this.LabelBorrowDate.Location = new System.Drawing.Point(12, 119);
            this.LabelBorrowDate.Name = "LabelBorrowDate";
            this.LabelBorrowDate.Size = new System.Drawing.Size(69, 13);
            this.LabelBorrowDate.TabIndex = 7;
            this.LabelBorrowDate.Text = "Borrowe Day";
            // 
            // LabelReutrnDate
            // 
            this.LabelReutrnDate.AutoSize = true;
            this.LabelReutrnDate.Location = new System.Drawing.Point(12, 174);
            this.LabelReutrnDate.Name = "LabelReutrnDate";
            this.LabelReutrnDate.Size = new System.Drawing.Size(66, 13);
            this.LabelReutrnDate.TabIndex = 8;
            this.LabelReutrnDate.Text = "Return Date";
            // 
            // LabelMemberName
            // 
            this.LabelMemberName.AutoSize = true;
            this.LabelMemberName.Location = new System.Drawing.Point(12, 70);
            this.LabelMemberName.Name = "LabelMemberName";
            this.LabelMemberName.Size = new System.Drawing.Size(75, 13);
            this.LabelMemberName.TabIndex = 9;
            this.LabelMemberName.Text = "Member Name";
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.Location = new System.Drawing.Point(12, 242);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(120, 40);
            this.btnAddBorrow.TabIndex = 10;
            this.btnAddBorrow.Text = "Add";
            this.btnAddBorrow.UseVisualStyleBackColor = true;
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            // 
            // ControlBorrowes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddBorrow);
            this.Controls.Add(this.LabelMemberName);
            this.Controls.Add(this.LabelReutrnDate);
            this.Controls.Add(this.LabelBorrowDate);
            this.Controls.Add(this.LabelBookName);
            this.Controls.Add(this.LabelCopies);
            this.Controls.Add(this.LabelAvailCopis);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "ControlBorrowes";
            this.Text = "ControlBorrowes";
            this.Load += new System.EventHandler(this.ControlBorrowes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LabelAvailCopis;
        private System.Windows.Forms.Label LabelCopies;
        private System.Windows.Forms.Label LabelBookName;
        private System.Windows.Forms.Label LabelBorrowDate;
        private System.Windows.Forms.Label LabelReutrnDate;
        private System.Windows.Forms.Label LabelMemberName;
        private System.Windows.Forms.Button btnAddBorrow;
    }
}