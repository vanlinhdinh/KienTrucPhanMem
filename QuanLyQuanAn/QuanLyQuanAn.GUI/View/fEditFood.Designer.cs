namespace QuanLyQuanAn.GUI.View
{
    partial class fEditFood
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.txbnameFood = new System.Windows.Forms.TextBox();
            this.txbprice = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.txbprice);
            this.panel1.Controls.Add(this.txbnameFood);
            this.panel1.Controls.Add(this.btnEditFood);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 198);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Food";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(25, 56);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 1;
            this.Price.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(28, 128);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(75, 23);
            this.btnEditFood.TabIndex = 3;
            this.btnEditFood.Text = "Edit";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // txbnameFood
            // 
            this.txbnameFood.Location = new System.Drawing.Point(130, 25);
            this.txbnameFood.Name = "txbnameFood";
            this.txbnameFood.Size = new System.Drawing.Size(155, 20);
            this.txbnameFood.TabIndex = 4;
            // 
            // txbprice
            // 
            this.txbprice.Location = new System.Drawing.Point(130, 56);
            this.txbprice.Name = "txbprice";
            this.txbprice.Size = new System.Drawing.Size(155, 20);
            this.txbprice.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(130, 91);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(155, 21);
            this.cbCategory.TabIndex = 6;
            // 
            // fEditFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 202);
            this.Controls.Add(this.panel1);
            this.Name = "fEditFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Food";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txbprice;
        private System.Windows.Forms.TextBox txbnameFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label1;
    }
}