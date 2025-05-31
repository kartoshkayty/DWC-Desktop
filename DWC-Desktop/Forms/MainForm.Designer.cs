namespace DWC_Desktop.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loadBar = new System.Windows.Forms.ProgressBar();
            this.userManagePBtn = new System.Windows.Forms.Button();
            this.addressPBtn = new System.Windows.Forms.Button();
            this.waterBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(53, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Вітаю";
            this.welcomeLabel.Visible = false;
            // 
            // loadBar
            // 
            this.loadBar.Location = new System.Drawing.Point(158, 201);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(240, 23);
            this.loadBar.TabIndex = 1;
            this.loadBar.Value = 10;
            // 
            // userManagePBtn
            // 
            this.userManagePBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagePBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userManagePBtn.Location = new System.Drawing.Point(145, 71);
            this.userManagePBtn.Name = "userManagePBtn";
            this.userManagePBtn.Size = new System.Drawing.Size(266, 32);
            this.userManagePBtn.TabIndex = 2;
            this.userManagePBtn.Text = "Управління користувачами";
            this.userManagePBtn.UseVisualStyleBackColor = true;
            this.userManagePBtn.Visible = false;
            this.userManagePBtn.Click += new System.EventHandler(this.userManagePBtn_Click);
            // 
            // addressPBtn
            // 
            this.addressPBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressPBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addressPBtn.Location = new System.Drawing.Point(145, 113);
            this.addressPBtn.Name = "addressPBtn";
            this.addressPBtn.Size = new System.Drawing.Size(266, 32);
            this.addressPBtn.TabIndex = 4;
            this.addressPBtn.Text = "Управління адресами";
            this.addressPBtn.UseVisualStyleBackColor = true;
            this.addressPBtn.Visible = false;
            this.addressPBtn.Click += new System.EventHandler(this.addressPBtn_Click);
            // 
            // waterBtn
            // 
            this.waterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.waterBtn.Location = new System.Drawing.Point(145, 157);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(266, 32);
            this.waterBtn.TabIndex = 5;
            this.waterBtn.Text = "Вода";
            this.waterBtn.UseVisualStyleBackColor = true;
            this.waterBtn.Visible = false;
            this.waterBtn.Click += new System.EventHandler(this.waterBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = global::DWC_Desktop.Properties.Resources.Settings;
            this.settingsBtn.Location = new System.Drawing.Point(13, 382);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(32, 30);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Visible = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 424);
            this.Controls.Add(this.waterBtn);
            this.Controls.Add(this.addressPBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.userManagePBtn);
            this.Controls.Add(this.loadBar);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DWC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ProgressBar loadBar;
        private System.Windows.Forms.Button userManagePBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button addressPBtn;
        private System.Windows.Forms.Button waterBtn;
    }
}

