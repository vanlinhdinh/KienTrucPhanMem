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
    public partial class fAddCategory : Form
    {
        private readonly FoodCategoryService category = new FoodCategoryService();//chỉ có thể sử dụng ko thể edit lại trong class Service 
        fAdmin fadmin;
        public fAddCategory(fAdmin fAdmin)
        {
            InitializeComponent();
            fadmin = fAdmin;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txbNameCategory.Text != null)
            {
                category.InsertCategory(txbNameCategory.Text);
                fadmin.LoadCategoryGrid();
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Name Category is empty");
            }
            
        }
    }
}
