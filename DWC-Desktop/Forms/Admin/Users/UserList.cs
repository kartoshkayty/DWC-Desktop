using DWC_Desktop.Classes;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Forms.Admin.Users
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        public void addUser(User user)
        {
            userBindingSource.Add(user);

            usersDataGrid.Refresh();
        }

        private async void UserList_Load(object sender, EventArgs e)
        {
            List<User> users = null;

            await Task.Run(async () =>
            {
                try
                {
                    users = await Client.Get<List<User>>("/user/all", true);
                }
                catch (HttpError ex) 
                {
                    MessageBox.Show($"Не вдалося отримати список користувачів: {ex.message[0]}");
                }
            });

            if (users == null)
            {
                return;
            }

            users.ForEach((user) => userBindingSource.Add(user));
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            CreateUser form = new CreateUser(this);

            form.ShowDialog();
        }

        private async void deleteUserBtn_Click(object sender, EventArgs e)
        {
            object Selected = usersDataGrid.CurrentRow;

            if (Selected == null)
            {
                MessageBox.Show("Оберіть користувача!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            User user = usersDataGrid.CurrentRow.DataBoundItem as User;

            bool success = false;

            await Task.Run(async () =>
            {
                try
                {
                    DeleteResponse response = await Client.Delete<DeleteResponse>($"/user/{user.id}", true);

                    success = response.success;
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не вдалося видалити користувача: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (success)
            {
                userBindingSource.Remove(user);
            }
        }
    }
}
