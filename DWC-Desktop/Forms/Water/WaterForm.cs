using DWC_Desktop.Classes;
using DWC_Desktop.Classes.Datasource;
using DWC_Desktop.Enums;
using DWC_Desktop.Forms.Water.Data;
using DWC_Desktop.Http;
using DWC_Desktop.Http.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace DWC_Desktop.Forms.Water
{
    public partial class WaterForm : Form
    {
        public WaterForm()
        {
            InitializeComponent();
        }

        public void addReport(ReportDatasource report)
        {
            reportDatasourceBindingSource.Add(report);

            reportDataGrid.Refresh();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddReport form = new AddReport(this);

            form.ShowDialog();
        }

        private async void WaterForm_Load(object sender, EventArgs e)
        {
            tempGauge.To = 80;
            tempGauge.FromColor = (Color)ColorConverter.ConvertFromString("#09ff00");
            tempGauge.ToColor = (Color)ColorConverter.ConvertFromString("#ff0000");

            PHGauge.To = 14;
            PHGauge.FromColor = (Color)ColorConverter.ConvertFromString("#09ff00");
            PHGauge.ToColor = (Color)ColorConverter.ConvertFromString("#ff0000");

            impuritiesGauge.To = 500;
            impuritiesGauge.FromColor = (Color)ColorConverter.ConvertFromString("#09ff00");
            impuritiesGauge.ToColor = (Color)ColorConverter.ConvertFromString("#ff0000");

            chlorineGauge.To = 4;
            chlorineGauge.ToColor = (Color)ColorConverter.ConvertFromString("#ff0000");

            if (Config.user.role == Role.Operator)
            {
                reportDataGrid.Visible = false;
                label1.Visible = true;
                deleteBtn.Enabled = false;
                label8.Visible = true;

                tempGauge.Visible = false;
                chlorineGauge.Visible = false;
                PHGauge.Visible = false;
                impuritiesGauge.Visible = false;

                addressCB.Visible = false;
                label7.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

                exportBtn.Enabled = false;

                return;
            }

            List<Report> response = null;

            await Task.Run(async () =>
            {
                try
                {
                    response = await Client.Get<List<Report>>("/report", true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не удалось загрузить отчеты: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null)
            {
                foreach (Report report in response)
                {
                    reportDatasourceBindingSource.Add(new ReportDatasource()
                    {
                        id = report.id,
                        temperature = report.temperature,
                        PH = report.PH,
                        chlorine_level = report.chlorine_level,
                        impurities = report.impurities,
                        created_at = report.created_at,
                        address = $"{report.address.city}, {report.address.street}, {report.address.house}"
                    });
                }
            }

            List<Address> addresses = null;

            await Task.Run(async () =>
            {
                try
                {
                    addresses = await Client.Get<List<Address>>("/address", true);
                }
                catch(HttpError ex)
                {
                    MessageBox.Show($"Не удалось загрузить адреса: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            addresses.ForEach((address) => addressDatasourceBindingSource.Add(new AddressDatasource()
            {
                id = address.id,
                address = $"{address.city}, {address.street}, {address.house}"
            }));

            AddressDatasource selectdAddress = addressCB.SelectedItem as AddressDatasource;

            if (selectdAddress != null) 
            {
                Report report = null;

                await Task.Run(async () =>
                {
                    try
                    {
                        report = await Client.Get<Report>($"/report/address/{selectdAddress.id}", true);
                    }
                    catch (HttpError ex)
                    {
                        MessageBox.Show($"Не удалось загрузить данные по адресу: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });

                if (report != null)
                {
                    tempGauge.Value = report.temperature;
                    PHGauge.Value = report.PH;
                    impuritiesGauge.Value = report.impurities;
                    chlorineGauge.Value = report.chlorine_level;
                }
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            ReportDatasource report = reportDataGrid.CurrentRow?.DataBoundItem as ReportDatasource;

            if (report == null)
            {
                MessageBox.Show("Выберите отчет!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SuccessResponse response = null;

            await Task.Run(async () =>
            {
                try
                {
                    response = await Client.Delete<SuccessResponse>($"/report/{report.id}", true);
                }
                catch (HttpError ex)
                {
                    MessageBox.Show($"Не удалось удалить отчет: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            if (response != null) 
            {
                reportDatasourceBindingSource.Remove(report);
            }
        }

        private async void addressCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddressDatasource selectdAddress = addressCB.SelectedItem as AddressDatasource;

            if (selectdAddress != null)
            {
                Report report = null;

                await Task.Run(async () =>
                {
                    try
                    {
                        report = await Client.Get<Report>($"/report/address/{selectdAddress.id}", true);
                    }
                    catch (HttpError ex)
                    {
                        MessageBox.Show($"Не удалось загрузить данные по адресу: {ex.message[0]}", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });

                if (report != null)
                {
                    tempGauge.Value = report.temperature;
                    PHGauge.Value = report.PH;
                    impuritiesGauge.Value = report.impurities;
                    chlorineGauge.Value = report.chlorine_level;
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            ReportDatasource report = reportDataGrid.CurrentRow?.DataBoundItem as ReportDatasource;

            if (report == null)
            {
                MessageBox.Show("Выберите отчет!", "DWC", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() != DialogResult.OK) return;

            string filePath = dialog.FileName;

            string data = $"Температура: {report.temperature}\nУровень PH: {report.PH}\nУровень хлора: {report.chlorine_level}\nПримеси: {report.impurities}\nДата: {report.created_at}\nАдрес: {report.address}";

            File.WriteAllText(filePath, data);
        }
    }
}
