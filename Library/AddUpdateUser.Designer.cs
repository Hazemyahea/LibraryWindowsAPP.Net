namespace Library
{
    partial class AddUpdateUser
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
            this.LabeMainAddUpdateUser = new System.Windows.Forms.Label();
            this.LabelUserId = new System.Windows.Forms.Label();
            this.LabelNumerUserID = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.btnAddUpdateUser = new System.Windows.Forms.Button();
            this.btnCloseUserAddForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabeMainAddUpdateUser
            // 
            this.LabeMainAddUpdateUser.AutoSize = true;
            this.LabeMainAddUpdateUser.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabeMainAddUpdateUser.Location = new System.Drawing.Point(354, 9);
            this.LabeMainAddUpdateUser.Name = "LabeMainAddUpdateUser";
            this.LabeMainAddUpdateUser.Size = new System.Drawing.Size(96, 27);
            this.LabeMainAddUpdateUser.TabIndex = 0;
            this.LabeMainAddUpdateUser.Text = "AddUser";
            // 
            // LabelUserId
            // 
            this.LabelUserId.AutoSize = true;
            this.LabelUserId.Location = new System.Drawing.Point(12, 61);
            this.LabelUserId.Name = "LabelUserId";
            this.LabelUserId.Size = new System.Drawing.Size(43, 13);
            this.LabelUserId.TabIndex = 1;
            this.LabelUserId.Text = "User ID";
            // 
            // LabelNumerUserID
            // 
            this.LabelNumerUserID.AutoSize = true;
            this.LabelNumerUserID.Location = new System.Drawing.Point(73, 61);
            this.LabelNumerUserID.Name = "LabelNumerUserID";
            this.LabelNumerUserID.Size = new System.Drawing.Size(17, 13);
            this.LabelNumerUserID.TabIndex = 2;
            this.LabelNumerUserID.Text = "??";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Location = new System.Drawing.Point(12, 103);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(59, 13);
            this.LabelUserName.TabIndex = 3;
            this.LabelUserName.Text = "User Name";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(12, 145);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(92, 103);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 6;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(92, 142);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserPassword.TabIndex = 7;
            // 
            // btnAddUpdateUser
            // 
            this.btnAddUpdateUser.Location = new System.Drawing.Point(234, 274);
            this.btnAddUpdateUser.Name = "btnAddUpdateUser";
            this.btnAddUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdateUser.TabIndex = 8;
            this.btnAddUpdateUser.Text = "Add";
            this.btnAddUpdateUser.UseVisualStyleBackColor = true;
            this.btnAddUpdateUser.Click += new System.EventHandler(this.btnAddUpdateUser_Click);
            // 
            // btnCloseUserAddForm
            // 
            this.btnCloseUserAddForm.Location = new System.Drawing.Point(404, 274);
            this.btnCloseUserAddForm.Name = "btnCloseUserAddForm";
            this.btnCloseUserAddForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseUserAddForm.TabIndex = 9;
            this.btnCloseUserAddForm.Text = "Close";
            this.btnCloseUserAddForm.UseVisualStyleBackColor = true;
            this.btnCloseUserAddForm.Click += new System.EventHandler(this.btnCloseUserAddForm_Click);
            // 
            // AddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseUserAddForm);
            this.Controls.Add(this.btnAddUpdateUser);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.LabelNumerUserID);
            this.Controls.Add(this.LabelUserId);
            this.Controls.Add(this.LabeMainAddUpdateUser);
            this.Name = "AddUpdateUser";
            this.Text = "AddUpdateUser";
            this.Load += new System.EventHandler(this.AddUpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabeMainAddUpdateUser;
        private System.Windows.Forms.Label LabelUserId;
        private System.Windows.Forms.Label LabelNumerUserID;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Button btnAddUpdateUser;
        private System.Windows.Forms.Button btnCloseUserAddForm;
    }
}