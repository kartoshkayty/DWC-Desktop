using DWC_Desktop.Classes;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.User;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWC_Desktop.Enums;

namespace DWC_Desktop.Forms.Admin.Users
{
    public partial class CreateUser : Form
    {
        private UserList usersForm;

        public CreateUser(UserList usersForm)
        {
            InitializeComponent();

            this.usersForm = usersForm;
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string password = passTB.Text;
            string first_name = firstNameTB.Text;
            string last_name = lastNameTB.Text;
            object role = roleCB.SelectedItem;

            if (email.Length == 0 || password.Length == 0 || first_name.Length == 0 || last_name.Length == 0 || role == null) 
            {
                MessageBox.Show("Заполните все поля для создания!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            foreach (Control child in this.Controls)
            {
                child.Enabled = false;
            }

            User response = null;

            await Task.Run(async () =>
            {
                try
                {
                    CreateRequest request = new CreateRequest()
                    {
                        email = email,
                        password = password,
                        first_name = first_name,
                        last_name = last_name,
                        role = role.ToString() == "Администратор" ? Role.Admin : role.ToString()  == "Инженер" ? Role.Engineer : Role.Operator,
                    };

                    response = await Client.Post<User, CreateRequest>("/user", request, true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не удалось создать пользователя: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null)
            {
                usersForm.addUser(response);

                this.Close();

                return;
            }

            foreach (Control child in this.Controls)
            {
                child.Enabled = true;
            }
        }
    }
}
