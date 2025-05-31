namespace DWC_Desktop.Forms.Admin.Addresses
{
    partial class AddressList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addAddressBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteAddressBtn = new System.Windows.Forms.ToolStripButton();
            this.addressDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.addressDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(797, 436);
            this.splitContainer1.SplitterDistance = 27;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAddressBtn,
            this.deleteAddressBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addAddressBtn
            // 
            this.addAddressBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addAddressBtn.Image = global::DWC_Desktop.Properties.Resources.plus;
            this.addAddressBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addAddressBtn.Name = "addAddressBtn";
            this.addAddressBtn.Size = new System.Drawing.Size(23, 22);
            this.addAddressBtn.Text = "Добавить";
            this.addAddressBtn.Click += new System.EventHandler(this.addAddressBtn_Click);
            // 
            // deleteAddressBtn
            // 
            this.deleteAddressBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteAddressBtn.Image = global::DWC_Desktop.Properties.Resources.trash_2;
            this.deleteAddressBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteAddressBtn.Name = "deleteAddressBtn";
            this.deleteAddressBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteAddressBtn.Text = "Удалить";
            this.deleteAddressBtn.Click += new System.EventHandler(this.deleteAddressBtn_Click);
            // 
            // addressDataGrid
            // 
            this.addressDataGrid.AllowUserToAddRows = false;
            this.addressDataGrid.AllowUserToDeleteRows = false;
            this.addressDataGrid.AutoGenerateColumns = false;
            this.addressDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addressDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn});
            this.addressDataGrid.DataSource = this.addressBindingSource;
            this.addressDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressDataGrid.Location = new System.Drawing.Point(0, 0);
            this.addressDataGrid.Name = "addressDataGrid";
            this.addressDataGrid.ReadOnly = true;
            this.addressDataGrid.Size = new System.Drawing.Size(797, 405);
            this.addressDataGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "house";
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(DWC_Desktop.Classes.Address);
            // 
            // AddressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 436);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddressList";
            this.Text = "Адреса";
            this.Load += new System.EventHandler(this.AddressList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView addressDataGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addAddressBtn;
        private System.Windows.Forms.ToolStripButton deleteAddressBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressBindingSource;
    }
}