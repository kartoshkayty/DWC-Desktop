using DWC_Desktop.Classes;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Forms.Admin.Addresses
{
    public partial class AddressList : Form
    {
        public AddressList()
        {
            InitializeComponent();
        }

        public void addAddress(Address address)
        {
            addressBindingSource.Add(address);

            addressDataGrid.Refresh();
        }

        private async void AddressList_Load(object sender, EventArgs e)
        {
            List<Classes.Address> addresses = null;

            await Task.Run(async () =>
            {
                try
                {
                    addresses = await Client.Get<List<Classes.Address>>("/address", true);
                }
                catch (HttpError ex) 
                {
                    MessageBox.Show($"Ошибка при получении адресов: {ex.message[0]}");
                }
            });

            if (addresses != null) 
            {
                addresses.ForEach((address) => addressBindingSource.Add(address));
            }
        }

        private void addAddressBtn_Click(object sender, EventArgs e)
        {
            CreateAddress form = new CreateAddress(this);

            form.ShowDialog();
        }

        private async void deleteAddressBtn_Click(object sender, EventArgs e)
        {
            object selected = addressDataGrid.CurrentRow;

            if (selected == null)
            {
                MessageBox.Show("Выберите адрес для удаления!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Address address = addressDataGrid.CurrentRow.DataBoundItem as Address;

            SuccessResponse response = null;

            await Task.Run(async () =>
            {
                try
                {
                    response = await Client.Delete<SuccessResponse>($"/address/{address.id}", true);
                }
                catch (HttpError ex) 
                {
                    MessageBox.Show($"Не удалось удалить адрес: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null) 
            { 
                addressBindingSource.Remove(address);
            }
        }
    }
}
