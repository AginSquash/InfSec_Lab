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
    public partial class ChangePassForm : Form
    {
        public UserJSON user = new UserJSON();
        public List<UserJSON> Users = new List<UserJSON>();
        public ChangePassForm(bool isFirstLogin = false)
        {
            InitializeComponent();
            if (isFirstLogin)
            {
                oldPass.Enabled = false;
            }
            Users = IODriver.ReadUsersData();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            if (user.Password == oldPass.Text)
            {
                if (newPass.Text == newPass2.Text)
                {
                    if ((user.passwordRestriction) && (PasswordCheck.isOK(newPass.Text) == false))
                    {
                        showError("Пароль не соответсвует ограничению");
                        return;
                        
                    }

                    Users.RemoveAll(item => (item.Login == user.Login));
                    user.Password = newPass.Text;
                    Users.Add(user);

                    IODriver.WriteUsersData(Users);

                    MessageBox.Show("Пароль успешно изменен", "Успешно");
                    this.Close();
                } else
                {
                    showError("Введеные пароли не совпадают");
                }
            }
            else
            {
                showError("Старый пароль введен неправильно");
            }
        }

        private void showError(String errorString)
        {
            MessageBox.Show(errorString, "login error");
            oldPass.Text = "";
            newPass.Text = "";
            newPass2.Text = "";
        }
    }

}
