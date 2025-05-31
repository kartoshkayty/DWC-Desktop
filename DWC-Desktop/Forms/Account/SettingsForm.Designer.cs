namespace DWC_Desktop.Forms.Account
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.account = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.retryPassTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newPassTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oldPassTB = new System.Windows.Forms.TextBox();
            this.sessions = new System.Windows.Forms.TabPage();
            this.revokeBtn = new System.Windows.Forms.Button();
            this.sessionsDataGrid = new System.Windows.Forms.DataGridView();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.account.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.account);
            this.tabControl1.Controls.Add(this.sessions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // account
            // 
            this.account.Controls.Add(this.groupBox1);
            this.account.Location = new System.Drawing.Point(4, 22);
            this.account.Name = "account";
            this.account.Padding = new System.Windows.Forms.Padding(3);
            this.account.Size = new System.Drawing.Size(581, 371);
            this.account.TabIndex = 0;
            this.account.Text = "Акаунт";
            this.account.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changePassBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.retryPassTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newPassTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.oldPassTB);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Змінити пороль";
            // 
            // changePassBtn
            // 
            this.changePassBtn.Location = new System.Drawing.Point(145, 169);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(117, 23);
            this.changePassBtn.TabIndex = 6;
            this.changePassBtn.Text = "Змінити пороль";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повтор пороля";
            // 
            // retryPassTB
            // 
            this.retryPassTB.Location = new System.Drawing.Point(96, 120);
            this.retryPassTB.Name = "retryPassTB";
            this.retryPassTB.Size = new System.Drawing.Size(167, 20);
            this.retryPassTB.TabIndex = 4;
            this.retryPassTB.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Новий пороль";
            // 
            // newPassTB
            // 
            this.newPassTB.Location = new System.Drawing.Point(96, 89);
            this.newPassTB.Name = "newPassTB";
            this.newPassTB.Size = new System.Drawing.Size(167, 20);
            this.newPassTB.TabIndex = 2;
            this.newPassTB.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Старий пороль";
            // 
            // oldPassTB
            // 
            this.oldPassTB.Location = new System.Drawing.Point(96, 47);
            this.oldPassTB.Name = "oldPassTB";
            this.oldPassTB.Size = new System.Drawing.Size(167, 20);
            this.oldPassTB.TabIndex = 0;
            this.oldPassTB.UseSystemPasswordChar = true;
            // 
            // sessions
            // 
            this.sessions.Controls.Add(this.revokeBtn);
            this.sessions.Controls.Add(this.sessionsDataGrid);
            this.sessions.Location = new System.Drawing.Point(4, 22);
            this.sessions.Name = "sessions";
            this.sessions.Padding = new System.Windows.Forms.Padding(3);
            this.sessions.Size = new System.Drawing.Size(581, 371);
            this.sessions.TabIndex = 1;
            this.sessions.Text = "Сесії";
            this.sessions.UseVisualStyleBackColor = true;
            // 
            // revokeBtn
            // 
            this.revokeBtn.Location = new System.Drawing.Point(500, 6);
            this.revokeBtn.Name = "revokeBtn";
            this.revokeBtn.Size = new System.Drawing.Size(75, 23);
            this.revokeBtn.TabIndex = 1;
            this.revokeBtn.Text = "Завершити";
            this.revokeBtn.UseVisualStyleBackColor = true;
            this.revokeBtn.Click += new System.EventHandler(this.revokeBtn_Click);
            // 
            // sessionsDataGrid
            // 
            this.sessionsDataGrid.AllowUserToAddRows = false;
            this.sessionsDataGrid.AllowUserToDeleteRows = false;
            this.sessionsDataGrid.AutoGenerateColumns = false;
            this.sessionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sessionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ipDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
            this.sessionsDataGrid.DataSource = this.sessionBindingSource;
            this.sessionsDataGrid.Location = new System.Drawing.Point(6, 6);
            this.sessionsDataGrid.Name = "sessionsDataGrid";
            this.sessionsDataGrid.ReadOnly = true;
            this.sessionsDataGrid.Size = new System.Drawing.Size(488, 359);
            this.sessionsDataGrid.TabIndex = 0;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(DWC_Desktop.Classes.Session);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "ip";
            this.ipDataGridViewTextBoxColumn.HeaderText = "IP Адреса";
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            this.ipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Дата створення";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 397);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.account.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage account;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPassTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPassTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox retryPassTB;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.TabPage sessions;
        private System.Windows.Forms.Button revokeBtn;
        private System.Windows.Forms.DataGridView sessionsDataGrid;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
    }
}