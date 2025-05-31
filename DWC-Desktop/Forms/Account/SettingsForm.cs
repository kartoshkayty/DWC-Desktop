using DWC_Desktop.Classes;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.Account;
using DWC_Desktop.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Forms.Account
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private async void changePassBtn_Click(object sender, System.EventArgs e)
        {
            string oldPass = oldPassTB.Text;

            string newPass = newPassTB.Text;
            string retryPass = retryPassTB.Text;

            if (oldPass.Length == 0 || newPass.Length == 0 || retryPass.Length == 0)
            {
                MessageBox.Show("Заполните все поля!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (newPass != retryPass)
            {
                MessageBox.Show("Пароли не совпадают!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            changePassBtn.Enabled = false;
            foreach (Control control in this.Controls) 
            {
                if (control.Name.EndsWith("PassTB"))
                {
                    control.Enabled = false;
                }
            }

            SuccessResponse response = null;

            await Task.Run(async () =>
            {
                try
                {
                    PasswordRequest body = new PasswordRequest() 
                    { 
                        old_password = oldPass,
                        new_password = newPass,
                    };

                    response = await Client.Post<SuccessResponse, PasswordRequest>("/account/password", body, true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show(ex.message[0], "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null) 
            {
                MessageBox.Show("Вы успешно изменили пароль!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Users.DeleteUser(Config.Token);

                Application.Exit();

                return;
            }

            changePassBtn.Enabled = true;
            foreach (Control control in this.Controls)
            {
                if (control.Name.EndsWith("PassTB"))
                {
                    control.Enabled = true;
                }
            }
        }

        private async void SettingsForm_Load(object sender, System.EventArgs e)
        {
            List<Session> sessions = null;

            await Task.Run(async () =>
            {
                try
                {
                    sessions = await Client.Get<List<Session>>("/sessions", true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не удалось загрузить список сессий: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (sessions != null)
            {
                sessions.ForEach(session => sessionBindingSource.Add(session));
            }
        }

        private async void revokeBtn_Click(object sender, System.EventArgs e)
        {
            object selected = sessionsDataGrid.CurrentRow;

            if (selected == null)
            {
                MessageBox.Show("Выберите сессию!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Session session = sessionsDataGrid.CurrentRow.DataBoundItem as Session;

            SuccessResponse response = null;

            await Task.Run(async () =>
            {
                try
                {
                    response = await Client.Delete<SuccessResponse>($"/sessions/{session.id}", true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не удалось завершить сессию: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null)
            {
                sessionBindingSource.Remove(session);
            }
        }
    }
}
