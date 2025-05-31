using DWC_Desktop.Classes;
using DWC_Desktop.Classes.Datasource;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using DWC_Desktop.Http.Dto.Reports;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWC_Desktop.Forms.Water.Data
{
    public partial class AddReport : Form
    {
        private WaterForm waterForm;

        public AddReport(WaterForm waterForm)
        {
            InitializeComponent();
            this.waterForm = waterForm;
        }

        private async void AddReport_Load(object sender, EventArgs e)
        {
            List<Address> response = null;

            await Task.Run(async () =>
            {
                try
                {
                    response = await Client.Get<List<Address>>("/address", true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не удалось загрузить адреса: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null) 
            {
                response.ForEach((address) =>
                {
                    addressDatasourceBindingSource.Add(new AddressDatasource()
                    {
                        id = address.id,
                        address = $"{address.city}, {address.street}, {address.house}",
                    });
                });
            }
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            string rawTemp = tempTB.Text;
            string rawPH = PHTB.Text;
            string rawChlorine = chlorineTB.Text;
            string rawImpurities = impuritiesTB.Text;
            AddressDatasource address = addressCB.SelectedItem as AddressDatasource;

            if (rawTemp.Length == 0 || rawPH.Length == 0 || rawChlorine.Length == 0 || rawImpurities.Length == 0 || address == null)
            {
                MessageBox.Show("Укажите все данные!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            float temp;
            int PH, chlorine, impurities;

            try
            {
                temp = Convert.ToSingle(rawTemp);

                PH = Convert.ToInt32(rawPH);
                chlorine = Convert.ToInt32(rawChlorine);
                impurities = Convert.ToInt32(rawImpurities);
            }
            catch (Exception)
            {
                MessageBox.Show("Укажите числа!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            foreach (Control control in this.Controls) 
            {
                control.Enabled = false;
            }

            Report response = null;

            await Task.Run(async () =>
            {
                try
                {
                    CreateReportRequest request = new CreateReportRequest()
                    {
                        temperature = temp.ToString().Replace(",", "."),
                        PH = PH,
                        impurities = impurities,
                        chlorine_level = chlorine,
                        address_id = address.id,
                    };

                    response = await Client.Post<Report, CreateReportRequest>("/report", request, true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не удалось создать отчет: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null) 
            {
                waterForm.addReport(new ReportDatasource()
                {
                    id = response.id,
                    temperature = response.temperature,
                    PH = response.PH,
                    impurities = response.impurities,
                    chlorine_level = response.chlorine_level,
                    created_at = response.created_at,
                    address = $"{response.address.city}, {response.address.street}, {response.address.house}"
                });

                this.Hide();
            }

            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }
    }
}
