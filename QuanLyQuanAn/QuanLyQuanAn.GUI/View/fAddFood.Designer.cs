namespace QuanLyQuanAn.GUI.View
{
    partial class fAddFood
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
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txbpriceFood = new System.Windows.Forms.TextBox();
            this.txbnameFood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.cbFoodCategory);
            this.panel1.Controls.Add(this.txbpriceFood);
            this.panel1.Controls.Add(this.txbnameFood);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 165);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(27, 134);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(102, 93);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(155, 21);
            this.cbFoodCategory.TabIndex = 5;
            // 
            // txbpriceFood
            // 
            this.txbpriceFood.Location = new System.Drawing.Point(102, 59);
            this.txbpriceFood.Name = "txbpriceFood";
            this.txbpriceFood.Size = new System.Drawing.Size(155, 20);
            this.txbpriceFood.TabIndex = 4;
            // 
            // txbnameFood
            // 
            this.txbnameFood.Location = new System.Drawing.Point(102, 20);
            this.txbnameFood.Name = "txbnameFood";
            this.txbnameFood.Size = new System.Drawing.Size(155, 20);
            this.txbnameFood.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Food";
            // 
            // fFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 171);
            this.Controls.Add(this.panel1);
            this.Name = "fFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Food";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbpriceFood;
        private System.Windows.Forms.TextBox txbnameFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Button btnAddFood;
    }
}