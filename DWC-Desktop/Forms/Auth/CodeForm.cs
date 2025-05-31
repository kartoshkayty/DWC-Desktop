using DWC_Desktop.Database;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.Auth;
using System;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Forms.Auth
{
    public partial class CodeForm : Form
    {
        public CodeForm()
        {
            InitializeComponent();
        }

        private void codeTB1_TextChanged(object sender, EventArgs e)
        {
            if (codeTB1.Text.Length > 0) 
            { 
                codeTB2.Select();
            }
        }

        private void codeTB2_TextChanged(object sender, EventArgs e)
        {
            if (codeTB2.Text.Length > 0)
            { 
                codeTB3.Select();

                return;
            }

            codeTB1.Select();
        }

        private void codeTB3_TextChanged(object sender, EventArgs e)
        {
            if (codeTB3.Text.Length > 0)
            {
                codeTB4.Select();

                return;
            }

            codeTB2.Select();
        }

        private void codeTB4_TextChanged(object sender, EventArgs e)
        {
            if (codeTB4.Text.Length > 0)
            {
                codeTB5.Select();

                return;
            }

            codeTB3.Select();
        }

        private void codeTB5_TextChanged(object sender, EventArgs e)
        {
            if (codeTB5.Text.Length == 0)
            {
                codeTB4.Select();
            }
        }

        private void CodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            loginBtn.Enabled = false;
            codeTB1.Enabled = false;
            codeTB2.Enabled = false;
            codeTB3.Enabled = false;
            codeTB4.Enabled = false;
            codeTB5.Enabled = false;

            string rawCode = codeTB1.Text + codeTB2.Text + codeTB3.Text + codeTB4.Text + codeTB5.Text;

            if (rawCode.Length < 5)
            {
                MessageBox.Show("Введите код полностью!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int code;

            try
            {
                code = Convert.ToInt32(rawCode);
            }
            catch (Exception) 
            {
                MessageBox.Show("Код должен содержать в себе только цифры!");

                return;
            }

            CodeResponse response = null;

            await Task.Run(async () =>
            {
                try
                {
                    CodeRequest body = new CodeRequest() 
                    { 
                        code = code,
                    };

                    response = await Client.Post<CodeResponse, CodeRequest>("/auth/code", body);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show(ex.message[0], "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null) 
            {
                Config.Token = response.token;

                SQLiteConnection connection = DB.GetConnection();
                SQLiteCommand cmd = connection.CreateCommand();

                cmd.CommandText = $"INSERT INTO Users (token,email) VALUES (\"{response.token}\",\"{response.email}\")";
                cmd.ExecuteNonQuery();

                this.Hide();

                MainForm form = new MainForm();

                form.Show();

                return;
            }

            loginBtn.Enabled = true;
            codeTB1.Enabled = true;
            codeTB2.Enabled = true;
            codeTB3.Enabled = true;
            codeTB4.Enabled = true;
            codeTB5.Enabled = true;
        }
    }
}
