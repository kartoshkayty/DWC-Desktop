namespace DWC_Desktop.Forms.Admin.Addresses
{
    partial class CreateAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAddress));
            this.cityTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.houseTB = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(186, 69);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(203, 20);
            this.cityTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Улица";
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(186, 105);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(203, 20);
            this.streetTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер дома";
            // 
            // houseTB
            // 
            this.houseTB.Location = new System.Drawing.Point(186, 145);
            this.houseTB.Name = "houseTB";
            this.houseTB.Size = new System.Drawing.Size(203, 20);
            this.houseTB.TabIndex = 4;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(202, 211);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Создать";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // CreateAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 279);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.houseTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.streetTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAddress";
            this.Text = "Создать адрес";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox houseTB;
        private System.Windows.Forms.Button createBtn;
    }
}