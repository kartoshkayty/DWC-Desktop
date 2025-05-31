namespace DWC_Desktop.Forms.Water.Data
{
    partial class AddReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressCB = new System.Windows.Forms.ComboBox();
            this.addressDatasourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.impuritiesTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chlorineTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PHTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tempTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDatasourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addressCB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.impuritiesTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chlorineTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PHTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tempTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(107, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дані";
            // 
            // addressCB
            // 
            this.addressCB.DataSource = this.addressDatasourceBindingSource;
            this.addressCB.DisplayMember = "address";
            this.addressCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressCB.FormattingEnabled = true;
            this.addressCB.Location = new System.Drawing.Point(197, 241);
            this.addressCB.Name = "addressCB";
            this.addressCB.Size = new System.Drawing.Size(208, 21);
            this.addressCB.TabIndex = 10;
            this.addressCB.ValueMember = "id";
            // 
            // addressDatasourceBindingSource
            // 
            this.addressDatasourceBindingSource.DataSource = typeof(DWC_Desktop.Classes.Datasource.AddressDatasource);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Адреса";
            // 
            // impuritiesTB
            // 
            this.impuritiesTB.Location = new System.Drawing.Point(197, 169);
            this.impuritiesTB.Name = "impuritiesTB";
            this.impuritiesTB.Size = new System.Drawing.Size(208, 20);
            this.impuritiesTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Домішки";
            // 
            // chlorineTB
            // 
            this.chlorineTB.Location = new System.Drawing.Point(197, 131);
            this.chlorineTB.Name = "chlorineTB";
            this.chlorineTB.Size = new System.Drawing.Size(208, 20);
            this.chlorineTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рівень хлора";
            // 
            // PHTB
            // 
            this.PHTB.Location = new System.Drawing.Point(197, 89);
            this.PHTB.Name = "PHTB";
            this.PHTB.Size = new System.Drawing.Size(208, 20);
            this.PHTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рівень PH";
            // 
            // tempTB
            // 
            this.tempTB.Location = new System.Drawing.Point(197, 49);
            this.tempTB.Name = "tempTB";
            this.tempTB.Size = new System.Drawing.Size(208, 20);
            this.tempTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Температура";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(467, 353);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Створити";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // AddReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 453);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddReport";
            this.Text = "Додавання звіту";
            this.Load += new System.EventHandler(this.AddReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressDatasourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox addressCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox impuritiesTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chlorineTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PHTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tempTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource addressDatasourceBindingSource;
        private System.Windows.Forms.Button createBtn;
    }
}