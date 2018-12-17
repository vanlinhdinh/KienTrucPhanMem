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
    public partial class fEditFood : Form
    {
        private fAdmin fadmin;
        private string id; string name; string price; string idCategory;
        private readonly FoodCategoryService category = new FoodCategoryService();
        private readonly FoodService food = new FoodService();
        public fEditFood(string id, string name, string price, string idCategory, fAdmin fAdmin)
        {
            InitializeComponent();
            this.fadmin = fAdmin;
            this.id = id;
            this.name = name;
            this.price = price;
            this.idCategory = idCategory;

            txbnameFood.Text = name;
            txbprice.Text = price;

            var listCategory = category.GetFoodCategories();
            List<string> listName = new List<string>();
            foreach (var item in listCategory)
                listName.Add(item.nameFoodCategory);
            string nameCategory = category.GetNameCategoryById(int.Parse(idCategory));
            cbCategory.DataSource = listName;
            cbCategory.SelectedItem = nameCategory;

            
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            decimal x = decimal.Parse(txbprice.Text);
            string nameCate = cbCategory.SelectedValue.ToString();
            int idCategory = category.GetIDCategoryByName(nameCate);
            food.UpdateFood(int.Parse(id), txbnameFood.Text, x, idCategory);
            fadmin.LoadFoodGrid();
            MessageBox.Show("Updated thành công");
            this.Close();

        }
    }
}
