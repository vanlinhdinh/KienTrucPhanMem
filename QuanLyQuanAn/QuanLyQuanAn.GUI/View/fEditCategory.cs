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
    public partial class fEditCategory : Form
    {
        private fAdmin fadmin;   string idCate;
        private readonly FoodCategoryService category = new FoodCategoryService();
        public fEditCategory(string id, string name, fAdmin fAdmin)
        {
            InitializeComponent();
            txbnameCate.Text = name;
            this.idCate = id;
            this.fadmin = fAdmin;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            category.UpdateCategory(int.Parse(idCate), txbnameCate.Text);
            fadmin.LoadCategoryGrid();
            this.Close();
            MessageBox.Show("Update thành công");
        }
    }
}
