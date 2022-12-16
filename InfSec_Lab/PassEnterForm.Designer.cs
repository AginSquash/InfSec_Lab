
namespace InfSec_Lab
{
    partial class PassEnterForm
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
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.Расшифровать = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите парольную фразу";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(70, 72);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(140, 20);
            this.passTextBox.TabIndex = 1;
            // 
            // Расшифровать
            // 
            this.Расшифровать.Location = new System.Drawing.Point(70, 106);
            this.Расшифровать.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Расшифровать.Name = "Расшифровать";
            this.Расшифровать.Size = new System.Drawing.Size(138, 43);
            this.Расшифровать.TabIndex = 2;
            this.Расшифровать.Text = "Расшифровать";
            this.Расшифровать.UseVisualStyleBackColor = true;
            this.Расшифровать.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // PassEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 197);
            this.Controls.Add(this.Расшифровать);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PassEnterForm";
            this.Text = "PassEnterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassEnterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button Расшифровать;
    }
}