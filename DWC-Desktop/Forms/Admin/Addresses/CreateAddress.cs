using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.Addresses;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWC_Desktop.Classes;

namespace DWC_Desktop.Forms.Admin.Addresses
{
    public partial class CreateAddress : Form
    {
        private AddressList mainForm;

        public CreateAddress(AddressList mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            string city = cityTB.Text;
            string street = streetTB.Text;
            string rawHouse = houseTB.Text;

            if (city.Length == 0 || street.Length == 0 || rawHouse.Length == 0) 
            {
                MessageBox.Show("Заполните все поля!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int house;

            try
            {
                house = Convert.ToInt32(rawHouse);
            }
            catch (Exception)
            {
                MessageBox.Show("Номер дома должен быть числом!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            foreach (Control control in this.Controls) 
            {
                control.Enabled = false;
            }

            Address response = null;

            await Task.Run(async () =>
            {
                try
                {
                    CreateAddressRequest request = new CreateAddressRequest() 
                    { 
                        city = city,
                        street = street,
                        house = house,
                    };

                    response = await Client.Post<Address, CreateAddressRequest>("/address", request, true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не удалось создать адрес: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null)
            {
                mainForm.addAddress(response);

                this.Hide();
            }

            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }
    }
}
