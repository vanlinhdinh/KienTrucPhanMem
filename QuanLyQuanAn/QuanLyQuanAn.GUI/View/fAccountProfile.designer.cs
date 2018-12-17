namespace QuanLyQuanAn
{
    partial class fAccountProfile
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 42);
            this.panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(144, 13);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(200, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 42);
            this.panel1.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(143, 13);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(201, 20);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbNewPass);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 42);
            this.panel3.TabIndex = 3;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(143, 13);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(201, 20);
            this.txbNewPass.TabIndex = 1;
            this.txbNewPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbConfirmPass);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 42);
            this.panel4.TabIndex = 4;
            // 
            // txbConfirmPass
            // 
            this.txbConfirmPass.Location = new System.Drawing.Point(143, 13);
            this.txbConfirmPass.Name = "txbConfirmPass";
            this.txbConfirmPass.Size = new System.Drawing.Size(201, 20);
            this.txbConfirmPass.TabIndex = 1;
            this.txbConfirmPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Pass";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 216);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(243, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fAccountProfile
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(373, 256);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "fAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAccountProfile";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}