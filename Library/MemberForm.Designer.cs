namespace Library
{
    partial class MemberForm
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
            this.dataGridViewMebmer = new System.Windows.Forms.DataGridView();
            this.contextMenuMember = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMebmer)).BeginInit();
            this.contextMenuMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMebmer
            // 
            this.dataGridViewMebmer.AllowUserToAddRows = false;
            this.dataGridViewMebmer.AllowUserToDeleteRows = false;
            this.dataGridViewMebmer.AllowUserToOrderColumns = true;
            this.dataGridViewMebmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMebmer.ContextMenuStrip = this.contextMenuMember;
            this.dataGridViewMebmer.Location = new System.Drawing.Point(13, 73);
            this.dataGridViewMebmer.Name = "dataGridViewMebmer";
            this.dataGridViewMebmer.ReadOnly = true;
            this.dataGridViewMebmer.Size = new System.Drawing.Size(783, 266);
            this.dataGridViewMebmer.TabIndex = 0;
            // 
            // contextMenuMember
            // 
            this.contextMenuMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuMember.Name = "contextMenuMember";
            this.contextMenuMember.Size = new System.Drawing.Size(181, 70);
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
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(639, 12);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(122, 37);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.dataGridViewMebmer);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMebmer)).EndInit();
            this.contextMenuMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMebmer;
        private System.Windows.Forms.ContextMenuStrip contextMenuMember;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnAddMember;
    }
}