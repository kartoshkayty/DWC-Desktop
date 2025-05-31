using DWC_Desktop.Classes;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.Auth;
using DWC_Desktop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Forms.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string password = passwordTB.Text;

            if (email.Length == 0 || password.Length == 0) 
            {
                MessageBox.Show("Вы не указали почту или пароль!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            emailTB.Enabled = false;
            passwordTB.Enabled = false;
            loginBtn.Enabled = false;

            LocalUser user = Users.GetUser(email);

            if (user != null) 
            {
                MessageBox.Show("Пользователь с таким адресом электронной почты уже есть в системе!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                emailTB.Enabled = true;
                passwordTB.Enabled = true;
                loginBtn.Enabled = true;

                return;
            }

            LoginResponse response = null;

            await Task.Run(async () =>
            {
                try
                {
                    LoginRequest request = new LoginRequest() 
                    { 
                        email = email,
                        password = password,
                    };

                    response = await Client.Post<LoginResponse, LoginRequest>("/auth/login", request);
                } 
                catch (HttpError ex)
                {
                    MessageBox.Show(ex.message[0], "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null) 
            {
                MessageBox.Show(response.message, "DWC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CodeForm form = new CodeForm();

                form.Show();

                this.Hide();

                return;
            }

            emailTB.Enabled = true;
            passwordTB.Enabled = true;
            loginBtn.Enabled = true;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
