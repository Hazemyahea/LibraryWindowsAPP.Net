namespace Library
{
    partial class BooksForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBooksMain = new System.Windows.Forms.DataGridView();
            this.contextMenuBookForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksMain)).BeginInit();
            this.contextMenuBookForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooksMain
            // 
            this.dataGridViewBooksMain.AllowUserToAddRows = false;
            this.dataGridViewBooksMain.AllowUserToDeleteRows = false;
            this.dataGridViewBooksMain.AllowUserToOrderColumns = true;
            this.dataGridViewBooksMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksMain.ContextMenuStrip = this.contextMenuBookForm;
            this.dataGridViewBooksMain.Location = new System.Drawing.Point(13, 84);
            this.dataGridViewBooksMain.Name = "dataGridViewBooksMain";
            this.dataGridViewBooksMain.ReadOnly = true;
            this.dataGridViewBooksMain.Size = new System.Drawing.Size(775, 343);
            this.dataGridViewBooksMain.TabIndex = 0;
            // 
            // contextMenuBookForm
            // 
            this.contextMenuBookForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuBookForm.Name = "contextMenuBookForm";
            this.contextMenuBookForm.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(633, 24);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(111, 44);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dataGridViewBooksMain);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksMain)).EndInit();
            this.contextMenuBookForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooksMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuBookForm;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnAddBook;
    }
}