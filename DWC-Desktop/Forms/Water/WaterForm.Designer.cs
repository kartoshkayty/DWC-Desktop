namespace DWC_Desktop.Forms.Water
{
    partial class WaterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.reportDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chlorinelevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuritiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDatasourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addressCB = new System.Windows.Forms.ComboBox();
            this.addressDatasourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.impuritiesGauge = new LiveCharts.WinForms.SolidGauge();
            this.label5 = new System.Windows.Forms.Label();
            this.chlorineGauge = new LiveCharts.WinForms.SolidGauge();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PHGauge = new LiveCharts.WinForms.SolidGauge();
            this.tempGauge = new LiveCharts.WinForms.SolidGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDatasourceBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDatasourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1364, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.reportDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1356, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Управление данными";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы не можете просматривать отчеты";
            this.label1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exportBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(1264, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(6, 48);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(74, 23);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(6, 19);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(74, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // reportDataGrid
            // 
            this.reportDataGrid.AllowUserToAddRows = false;
            this.reportDataGrid.AllowUserToDeleteRows = false;
            this.reportDataGrid.AutoGenerateColumns = false;
            this.reportDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.pHDataGridViewTextBoxColumn,
            this.chlorinelevelDataGridViewTextBoxColumn,
            this.impuritiesDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.reportDataGrid.DataSource = this.reportDatasourceBindingSource;
            this.reportDataGrid.Location = new System.Drawing.Point(6, 6);
            this.reportDataGrid.Name = "reportDataGrid";
            this.reportDataGrid.ReadOnly = true;
            this.reportDataGrid.Size = new System.Drawing.Size(1252, 523);
            this.reportDataGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Температура";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHDataGridViewTextBoxColumn
            // 
            this.pHDataGridViewTextBoxColumn.DataPropertyName = "PH";
            this.pHDataGridViewTextBoxColumn.HeaderText = "PH";
            this.pHDataGridViewTextBoxColumn.Name = "pHDataGridViewTextBoxColumn";
            this.pHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chlorinelevelDataGridViewTextBoxColumn
            // 
            this.chlorinelevelDataGridViewTextBoxColumn.DataPropertyName = "chlorine_level";
            this.chlorinelevelDataGridViewTextBoxColumn.HeaderText = "Уровень хлора (мг/л)";
            this.chlorinelevelDataGridViewTextBoxColumn.Name = "chlorinelevelDataGridViewTextBoxColumn";
            this.chlorinelevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // impuritiesDataGridViewTextBoxColumn
            // 
            this.impuritiesDataGridViewTextBoxColumn.DataPropertyName = "impurities";
            this.impuritiesDataGridViewTextBoxColumn.HeaderText = "Примеси (мг/л)";
            this.impuritiesDataGridViewTextBoxColumn.Name = "impuritiesDataGridViewTextBoxColumn";
            this.impuritiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Дата отчета";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDatasourceBindingSource
            // 
            this.reportDatasourceBindingSource.DataSource = typeof(DWC_Desktop.Classes.Datasource.ReportDatasource);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.addressCB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.impuritiesGauge);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.chlorineGauge);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.PHGauge);
            this.tabPage2.Controls.Add(this.tempGauge);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1356, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Последний отчет";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(438, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Вы не можете просматривать эту информацию";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Адрес";
            // 
            // addressCB
            // 
            this.addressCB.DataSource = this.addressDatasourceBindingSource;
            this.addressCB.DisplayMember = "address";
            this.addressCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressCB.FormattingEnabled = true;
            this.addressCB.Location = new System.Drawing.Point(622, 359);
            this.addressCB.Name = "addressCB";
            this.addressCB.Size = new System.Drawing.Size(189, 21);
            this.addressCB.TabIndex = 9;
            this.addressCB.ValueMember = "id";
            this.addressCB.SelectedIndexChanged += new System.EventHandler(this.addressCB_SelectedIndexChanged);
            // 
            // addressDatasourceBindingSource
            // 
            this.addressDatasourceBindingSource.DataSource = typeof(DWC_Desktop.Classes.Datasource.AddressDatasource);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(986, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Примеси";
            // 
            // impuritiesGauge
            // 
            this.impuritiesGauge.Location = new System.Drawing.Point(912, 118);
            this.impuritiesGauge.Name = "impuritiesGauge";
            this.impuritiesGauge.Size = new System.Drawing.Size(200, 100);
            this.impuritiesGauge.TabIndex = 7;
            this.impuritiesGauge.Text = "solidGauge4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Уровень хлора";
            // 
            // chlorineGauge
            // 
            this.chlorineGauge.Location = new System.Drawing.Point(688, 118);
            this.chlorineGauge.Name = "chlorineGauge";
            this.chlorineGauge.Size = new System.Drawing.Size(200, 100);
            this.chlorineGauge.TabIndex = 5;
            this.chlorineGauge.Text = "solidGauge3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Уровень PH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Температура";
            // 
            // PHGauge
            // 
            this.PHGauge.Location = new System.Drawing.Point(469, 118);
            this.PHGauge.Name = "PHGauge";
            this.PHGauge.Size = new System.Drawing.Size(200, 100);
            this.PHGauge.TabIndex = 2;
            this.PHGauge.Text = "solidGauge2";
            // 
            // tempGauge
            // 
            this.tempGauge.Location = new System.Drawing.Point(245, 118);
            this.tempGauge.Name = "tempGauge";
            this.tempGauge.Size = new System.Drawing.Size(200, 100);
            this.tempGauge.TabIndex = 1;
            this.tempGauge.Text = "solidGauge1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Последний отчет";
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(6, 203);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(74, 23);
            this.exportBtn.TabIndex = 2;
            this.exportBtn.Text = "Экспорт";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // WaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaterForm";
            this.Text = "Контроль воды";
            this.Load += new System.EventHandler(this.WaterForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDatasourceBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDatasourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView reportDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chlorinelevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuritiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportDatasourceBindingSource;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.SolidGauge PHGauge;
        private LiveCharts.WinForms.SolidGauge tempGauge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox addressCB;
        private System.Windows.Forms.Label label6;
        private LiveCharts.WinForms.SolidGauge impuritiesGauge;
        private System.Windows.Forms.Label label5;
        private LiveCharts.WinForms.SolidGauge chlorineGauge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource addressDatasourceBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exportBtn;
    }
}