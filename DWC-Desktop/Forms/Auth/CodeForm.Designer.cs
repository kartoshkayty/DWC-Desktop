namespace DWC_Desktop.Forms.Auth
{
    partial class CodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeForm));
            this.codeTB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.codeTB2 = new System.Windows.Forms.TextBox();
            this.codeTB3 = new System.Windows.Forms.TextBox();
            this.codeTB4 = new System.Windows.Forms.TextBox();
            this.codeTB5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codeTB1
            // 
            this.codeTB1.Location = new System.Drawing.Point(127, 117);
            this.codeTB1.MaxLength = 1;
            this.codeTB1.Name = "codeTB1";
            this.codeTB1.Size = new System.Drawing.Size(17, 20);
            this.codeTB1.TabIndex = 0;
            this.codeTB1.TextChanged += new System.EventHandler(this.codeTB1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть код для авторизації";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(146, 161);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Увійти";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // codeTB2
            // 
            this.codeTB2.Location = new System.Drawing.Point(150, 117);
            this.codeTB2.MaxLength = 1;
            this.codeTB2.Name = "codeTB2";
            this.codeTB2.Size = new System.Drawing.Size(17, 20);
            this.codeTB2.TabIndex = 6;
            this.codeTB2.TextChanged += new System.EventHandler(this.codeTB2_TextChanged);
            // 
            // codeTB3
            // 
            this.codeTB3.Location = new System.Drawing.Point(173, 117);
            this.codeTB3.MaxLength = 1;
            this.codeTB3.Name = "codeTB3";
            this.codeTB3.Size = new System.Drawing.Size(17, 20);
            this.codeTB3.TabIndex = 7;
            this.codeTB3.TextChanged += new System.EventHandler(this.codeTB3_TextChanged);
            // 
            // codeTB4
            // 
            this.codeTB4.Location = new System.Drawing.Point(199, 117);
            this.codeTB4.MaxLength = 1;
            this.codeTB4.Name = "codeTB4";
            this.codeTB4.Size = new System.Drawing.Size(17, 20);
            this.codeTB4.TabIndex = 8;
            this.codeTB4.TextChanged += new System.EventHandler(this.codeTB4_TextChanged);
            // 
            // codeTB5
            // 
            this.codeTB5.Location = new System.Drawing.Point(222, 117);
            this.codeTB5.MaxLength = 1;
            this.codeTB5.Name = "codeTB5";
            this.codeTB5.Size = new System.Drawing.Size(17, 20);
            this.codeTB5.TabIndex = 9;
            this.codeTB5.TextChanged += new System.EventHandler(this.codeTB5_TextChanged);
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 268);
            this.Controls.Add(this.codeTB5);
            this.Controls.Add(this.codeTB4);
            this.Controls.Add(this.codeTB3);
            this.Controls.Add(this.codeTB2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeTB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Увійти";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox codeTB2;
        private System.Windows.Forms.TextBox codeTB3;
        private System.Windows.Forms.TextBox codeTB4;
        private System.Windows.Forms.TextBox codeTB5;
    }
}