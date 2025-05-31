using DWC_Desktop.Classes;
using DWC_Desktop.Enums;
using DWC_Desktop.Forms.Account;
using DWC_Desktop.Forms.Admin.Addresses;
using DWC_Desktop.Forms.Admin.Users;
using DWC_Desktop.Forms.Water;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.User;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void MainForm_Shown(object sender, System.EventArgs e)
        {
            await Task.Run(async () =>
            {
                MeResponse response;

                try
                {
                    response = await Client.Get<MeResponse>("/user/@me", true);
                }
                catch (HttpError)
                {
                    MessageBox.Show("Сталася непередбачена помилка!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();

                    return;
                }

                User user = new User()
                {
                    role = response.role,
                    first_name = response.first_name,
                    last_name = response.last_name,
                    id = response.id,
                    email = response.email,
                };

                Config.user = user;
            });

            loadBar.Value = 100;
            welcomeLabel.Text = $"Вітаю {Config.user.first_name} {Config.user.last_name}!";

            foreach (Control child in Controls)
            {
                if (child.Name.EndsWith("PBtn"))
                {
                    continue;
                }

                if (child.Name == "loadBar")
                {
                    child.Visible = false;
                    continue;
                }

                child.Visible = true;
            }

            switch (Config.user.role)
            {
                case Role.Admin:
                    userManagePBtn.Visible = true;
                    addressPBtn.Visible = true;
                    break;
            }
        }

        private void userManagePBtn_Click(object sender, System.EventArgs e)
        {
            UserList form = new UserList();

            form.ShowDialog();
        }

        private void settingsBtn_Click(object sender, System.EventArgs e)
        {
            SettingsForm form = new SettingsForm();

            form.ShowDialog();
        }

        private void addressPBtn_Click(object sender, System.EventArgs e)
        {
            AddressList form = new AddressList();

            form.ShowDialog();
        }

        private void waterBtn_Click(object sender, System.EventArgs e)
        {
            WaterForm form = new WaterForm();

            form.ShowDialog();
        }
    }
}
