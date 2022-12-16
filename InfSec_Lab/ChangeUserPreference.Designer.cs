
namespace InfSec_Lab
{
    partial class ChangeUserPreference
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
            this.SaveUserPrefButton = new System.Windows.Forms.Button();
            this.passwordRestriction = new System.Windows.Forms.CheckBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isBlocked = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SaveUserPrefButton
            // 
            this.SaveUserPrefButton.Location = new System.Drawing.Point(24, 225);
            this.SaveUserPrefButton.Name = "SaveUserPrefButton";
            this.SaveUserPrefButton.Size = new System.Drawing.Size(275, 71);
            this.SaveUserPrefButton.TabIndex = 13;
            this.SaveUserPrefButton.Text = "Сохранить";
            this.SaveUserPrefButton.UseVisualStyleBackColor = true;
            this.SaveUserPrefButton.Click += new System.EventHandler(this.SaveUserPrefButton_Click);
            // 
            // passwordRestriction
            // 
            this.passwordRestriction.AutoSize = true;
            this.passwordRestriction.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordRestriction.Location = new System.Drawing.Point(12, 105);
            this.passwordRestriction.Name = "passwordRestriction";
            this.passwordRestriction.Size = new System.Drawing.Size(287, 29);
            this.passwordRestriction.TabIndex = 12;
            this.passwordRestriction.Text = "Парольное ограничение";
            this.passwordRestriction.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(19, 55);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(287, 31);
            this.username.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя пользователя";
            // 
            // isBlocked
            // 
            this.isBlocked.AutoSize = true;
            this.isBlocked.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isBlocked.Location = new System.Drawing.Point(19, 157);
            this.isBlocked.Name = "isBlocked";
            this.isBlocked.Size = new System.Drawing.Size(163, 29);
            this.isBlocked.TabIndex = 15;
            this.isBlocked.Text = "Блокировка";
            this.isBlocked.UseVisualStyleBackColor = true;
            // 
            // ChangeUserPreference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 353);
            this.Controls.Add(this.isBlocked);
            this.Controls.Add(this.SaveUserPrefButton);
            this.Controls.Add(this.passwordRestriction);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "ChangeUserPreference";
            this.Text = "ChangeUserPreference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveUserPrefButton;
        private System.Windows.Forms.CheckBox passwordRestriction;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isBlocked;
    }
}