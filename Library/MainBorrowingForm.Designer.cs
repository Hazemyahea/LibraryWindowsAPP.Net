namespace Library
{
    partial class MainBorrowingForm
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
            this.dataGridViewMainBorrowing = new System.Windows.Forms.DataGridView();
            this.contextMenuStripMainBorrowing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainBorrowing)).BeginInit();
            this.contextMenuStripMainBorrowing.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMainBorrowing
            // 
            this.dataGridViewMainBorrowing.AllowUserToAddRows = false;
            this.dataGridViewMainBorrowing.AllowUserToDeleteRows = false;
            this.dataGridViewMainBorrowing.AllowUserToOrderColumns = true;
            this.dataGridViewMainBorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainBorrowing.ContextMenuStrip = this.contextMenuStripMainBorrowing;
            this.dataGridViewMainBorrowing.Location = new System.Drawing.Point(13, 94);
            this.dataGridViewMainBorrowing.Name = "dataGridViewMainBorrowing";
            this.dataGridViewMainBorrowing.ReadOnly = true;
            this.dataGridViewMainBorrowing.Size = new System.Drawing.Size(775, 261);
            this.dataGridViewMainBorrowing.TabIndex = 0;
            // 
            // contextMenuStripMainBorrowing
            // 
            this.contextMenuStripMainBorrowing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripMainBorrowing.Name = "contextMenuStripMainBorrowing";
            this.contextMenuStripMainBorrowing.Size = new System.Drawing.Size(181, 92);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainBorrowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMainBorrowing);
            this.Name = "MainBorrowingForm";
            this.Text = "MainBorrowingForm";
            this.Load += new System.EventHandler(this.MainBorrowingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainBorrowing)).EndInit();
            this.contextMenuStripMainBorrowing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMainBorrowing;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMainBorrowing;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}