﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace InfSec_Lab
{
    public partial class LoginForm : Form
    {

        List<UserJSON> Users = new List<UserJSON>();
        int errorCount = 0;

        public LoginForm()
        {
            InitializeComponent();

            string curFile = "users.json";
            if (!File.Exists(curFile))
            {
                Console.WriteLine("Cannot found users.json. Creating...");
                UserJSON admin = new UserJSON("ADMIN");
                Users.Add(admin);
                IODriver.WriteUsersData(Users);
            } else
            {
                Console.WriteLine("users.json founded");
                Users = IODriver.ReadUsersData();
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string pass = passwordTextBox.Text;

            UserJSON entered = new UserJSON(login, pass);
            int index = Users.FindIndex(item => (item.Login == login));
            if (index > -1)
            {
                UserJSON currentUser = Users[index];

                if (Users[index].Password == pass) { 
                    Console.WriteLine("Successful");

                    if (pass == "")
                    {
                        ChangePassForm cpf = new ChangePassForm(currentUser, true);
                        cpf.ShowDialog();

                        Users = IODriver.ReadUsersData();
                        currentUser = Users.Find(item => (item.Login == login));
                    }


                    if (currentUser.isBlocked)
                    {
                        showError("Учетная запись заблокированна");
                        return;
                    }

                    MainForm main = this.Owner as MainForm;
                    if (main != null)
                    {
                        this.Hide();
                        main.currentUser = currentUser;
                        main.updateUserToolStrip();
                        main.Show();
                    }
                 
                } else
                {
                    showError("Неправильный пароль");
                }

            } else
            {
                Console.WriteLine("Error");
                showError("Такого пользователя не существует");
            }
      
        }

        private void showError(String errorString)
        {
            MessageBox.Show(errorString, "login error");
            if (errorCount == 3)
            {
                Application.Exit();
            } else
            {
                errorCount++;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
