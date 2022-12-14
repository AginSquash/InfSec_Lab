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
        public List<UserJSON> Users = new List<UserJSON>();
        public AddUser()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string login = username.Text;
            bool restriction = passwordRestriction.Checked;

            UserJSON newUser = new UserJSON(login, restriction);

            // Добавиь проверку есть ли пользователь с таким именем
            Users.Add(newUser);

            IODriver.WriteUsersData(Users);

            MessageBox.Show("Пользователь добавлен", "Успешно");
            this.Close();
        }
    }
}
