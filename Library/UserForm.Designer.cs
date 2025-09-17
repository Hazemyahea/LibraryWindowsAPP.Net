namespace Library
{
    partial class UserForm
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
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.UserMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.UserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToOrderColumns = true;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.ContextMenuStrip = this.UserMenu;
            this.dataGridUsers.Location = new System.Drawing.Point(-1, 97);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.Size = new System.Drawing.Size(990, 349);
            this.dataGridUsers.TabIndex = 0;
            // 
            // UserMenu
            // 
            this.UserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(181, 70);
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
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(815, 24);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(136, 39);
            this.BtnAddUser.TabIndex = 2;
            this.BtnAddUser.Text = "Add User";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.dataGridUsers);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.UserMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.ContextMenuStrip UserMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button BtnAddUser;
    }
}