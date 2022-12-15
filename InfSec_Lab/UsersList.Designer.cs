
namespace InfSec_Lab
{
    partial class UsersList
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
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openUserProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 25;
            this.usersListBox.Location = new System.Drawing.Point(45, 46);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(440, 229);
            this.usersListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openUserProfile
            // 
            this.openUserProfile.Location = new System.Drawing.Point(305, 322);
            this.openUserProfile.Name = "openUserProfile";
            this.openUserProfile.Size = new System.Drawing.Size(139, 74);
            this.openUserProfile.TabIndex = 2;
            this.openUserProfile.Text = "Изменить";
            this.openUserProfile.UseVisualStyleBackColor = true;
            this.openUserProfile.Click += new System.EventHandler(this.openUserProfile_Click);
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 447);
            this.Controls.Add(this.openUserProfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usersListBox);
            this.Name = "UsersList";
            this.Text = "UsersList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openUserProfile;
    }
}