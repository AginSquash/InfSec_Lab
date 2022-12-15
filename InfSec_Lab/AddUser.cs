using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSec_Lab
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string login = username.Text;
            bool restriction = passwordRestriction.Checked;

            UserJSON newUser = new UserJSON(login, restriction);

            List<UserJSON>  Users = IODriver.ReadUsersData();

            if (Users.FindIndex(item => (item.Login == login)) > -1 )
            {
                MessageBox.Show("Пользователь с таким именем уже есть", "Успешно");
                return;
            }

            Users.Add(newUser);

            IODriver.WriteUsersData(Users);

            MessageBox.Show("Пользователь добавлен", "Успешно");
            this.Close();
        }

        private void passwordRestriction_CheckedChanged(object sender, EventArgs e)
        {
            fillPassRestBox(passwordRestriction.Checked);
        }

        private void fillPassRestBox(bool isCheked)
        {
            String text = "Ограничение на пароль:\n";
            if (isCheked)
            {
                passRestBox.Text = text + "Наличие букв и знаков препинания.";
            }
            else
            {
                passRestBox.Text = text + "не заданны.";
            }
        }
    }
}
