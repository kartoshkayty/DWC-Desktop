using DWC_Desktop.Classes;
using DWC_Desktop.Database;
using DWC_Desktop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Forms.Auth
{
    public partial class AccountsForm : Form
    {
        public AccountsForm()
        {
            InitializeComponent();
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            List <LocalUser> users = Users.GetUsers();

            users.ForEach((user) => accountsList.Items.Add(user.Email));
        }

        private void AccountsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            object email = accountsList.SelectedItem;

            if (email == null) {
                MessageBox.Show("Выберите аккаунт!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            LocalUser user = Users.GetUser(email.ToString());

            if (user == null) 
            {
                MessageBox.Show("Не удалось найти пользователя!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Config.Token = user.Token;

            this.Hide();

            MainForm form = new MainForm();

            form.Show();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm form = new LoginForm();

            form.Show();
        }
    }
}
