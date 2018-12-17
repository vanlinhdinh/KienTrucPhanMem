using QuanLyQuanAn.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.GUI.View
{
    public partial class fAddFood : Form
    {
        FoodService food = new FoodService();
        FoodCategoryService category = new FoodCategoryService();
        fAdmin fadmin;
        public fAddFood(fAdmin fAdmin)
        {
            InitializeComponent();
            fadmin = fAdmin;
            LoadCategory();
        }

        private void LoadCategory()
        {
            var listCate = category.GetFoodCategories();
            cbFoodCategory.Items.Clear();
            
            foreach(var item in listCate)
            {
                cbFoodCategory.Items.Add(item.nameFoodCategory);
            }
            cbFoodCategory.SelectedIndex = 0;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int idCategory = category.GetIDCategoryByName(cbFoodCategory.SelectedItem.ToString());
            food.InsertFood(txbnameFood.Text, int.Parse(txbpriceFood.Text), idCategory);
            if (MessageBox.Show("Bạn Thêm Thành Công.", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
            {
                fadmin.LoadFoodGrid();
                this.Close();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
