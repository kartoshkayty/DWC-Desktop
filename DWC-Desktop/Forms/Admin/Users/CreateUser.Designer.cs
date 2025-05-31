namespace DWC_Desktop.Forms.Admin.Users
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.label1 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Почта";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(184, 84);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(249, 20);
            this.emailTB.TabIndex = 1;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(225, 354);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Создать";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // roleCB
            // 
            this.roleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Items.AddRange(new object[] {
            "Администратор",
            "Инженер",
            "Оператор"});
            this.roleCB.Location = new System.Drawing.Point(184, 132);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(249, 21);
            this.roleCB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Должность";
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(184, 179);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(249, 20);
            this.passTB.TabIndex = 6;
            this.passTB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(184, 226);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(249, 20);
            this.firstNameTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(184, 274);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(249, 20);
            this.lastNameTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фамилия";
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 448);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roleCB);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateUser";
            this.Text = "Создать пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label label5;
    }
}