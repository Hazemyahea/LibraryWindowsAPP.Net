namespace Library
{
    partial class AddUpdateMember
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
            this.LabelAddUpdate = new System.Windows.Forms.Label();
            this.LabelMemberId = new System.Windows.Forms.Label();
            this.labelMebmeIDInt = new System.Windows.Forms.Label();
            this.LabelFullName = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabeJoinDate = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxJoinDate = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAddUpdate
            // 
            this.LabelAddUpdate.AutoSize = true;
            this.LabelAddUpdate.Location = new System.Drawing.Point(277, 25);
            this.LabelAddUpdate.Name = "LabelAddUpdate";
            this.LabelAddUpdate.Size = new System.Drawing.Size(91, 13);
            this.LabelAddUpdate.TabIndex = 0;
            this.LabelAddUpdate.Text = "Add New Member";
            // 
            // LabelMemberId
            // 
            this.LabelMemberId.AutoSize = true;
            this.LabelMemberId.Location = new System.Drawing.Point(23, 77);
            this.LabelMemberId.Name = "LabelMemberId";
            this.LabelMemberId.Size = new System.Drawing.Size(61, 13);
            this.LabelMemberId.TabIndex = 1;
            this.LabelMemberId.Text = "Member Id ";
            // 
            // labelMebmeIDInt
            // 
            this.labelMebmeIDInt.AutoSize = true;
            this.labelMebmeIDInt.Location = new System.Drawing.Point(109, 77);
            this.labelMebmeIDInt.Name = "labelMebmeIDInt";
            this.labelMebmeIDInt.Size = new System.Drawing.Size(17, 13);
            this.labelMebmeIDInt.TabIndex = 2;
            this.labelMebmeIDInt.Text = "??";
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Location = new System.Drawing.Point(23, 131);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(50, 13);
            this.LabelFullName.TabIndex = 3;
            this.LabelFullName.Text = "FullName";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Location = new System.Drawing.Point(23, 176);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(37, 13);
            this.LabelPhone.TabIndex = 4;
            this.LabelPhone.Text = "Phone";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(23, 225);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(31, 13);
            this.LabelEmail.TabIndex = 5;
            this.LabelEmail.Text = "Email";
            // 
            // LabeJoinDate
            // 
            this.LabeJoinDate.AutoSize = true;
            this.LabeJoinDate.Location = new System.Drawing.Point(23, 276);
            this.LabeJoinDate.Name = "LabeJoinDate";
            this.LabeJoinDate.Size = new System.Drawing.Size(52, 13);
            this.LabeJoinDate.TabIndex = 6;
            this.LabeJoinDate.Text = "Join Date";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(91, 131);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(161, 20);
            this.textBoxFullName.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(91, 176);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(161, 20);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxJoinDate
            // 
            this.textBoxJoinDate.Location = new System.Drawing.Point(91, 273);
            this.textBoxJoinDate.Name = "textBoxJoinDate";
            this.textBoxJoinDate.Size = new System.Drawing.Size(161, 20);
            this.textBoxJoinDate.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(91, 225);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(161, 20);
            this.textBoxEmail.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(280, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxJoinDate);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.LabeJoinDate);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.LabelFullName);
            this.Controls.Add(this.labelMebmeIDInt);
            this.Controls.Add(this.LabelMemberId);
            this.Controls.Add(this.LabelAddUpdate);
            this.Name = "AddUpdateMember";
            this.Text = "AddUpdateMember";
            this.Load += new System.EventHandler(this.AddUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddUpdate;
        private System.Windows.Forms.Label LabelMemberId;
        private System.Windows.Forms.Label labelMebmeIDInt;
        private System.Windows.Forms.Label LabelFullName;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabeJoinDate;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxJoinDate;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnSave;
    }
}