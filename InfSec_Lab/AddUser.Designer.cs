
namespace InfSec_Lab
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.passwordRestriction = new System.Windows.Forms.CheckBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(301, 46);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(230, 31);
            this.username.TabIndex = 2;
            // 
            // passwordRestriction
            // 
            this.passwordRestriction.AutoSize = true;
            this.passwordRestriction.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordRestriction.Location = new System.Drawing.Point(41, 105);
            this.passwordRestriction.Name = "passwordRestriction";
            this.passwordRestriction.Size = new System.Drawing.Size(287, 29);
            this.passwordRestriction.TabIndex = 3;
            this.passwordRestriction.Text = "Парольное ограничение";
            this.passwordRestriction.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(335, 172);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(171, 71);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(566, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 150);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Ограничение на пароль: \nне заданны";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 274);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.passwordRestriction);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.CheckBox passwordRestriction;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}