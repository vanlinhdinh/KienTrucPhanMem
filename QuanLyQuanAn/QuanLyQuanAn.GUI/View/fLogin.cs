using QuanLyQuanAn.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class fLogin : Form
    {
        AccountService account = new AccountService();
        public fLogin()
        {
            InitializeComponent();
            txbUserName.Text = "TriDo113";
            txbPassword.Text = "123456";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát.","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(Login(txbUserName.Text,txbPassword.Text))
            {
                //AccountService account = new AccountService();
                //account.GetAccountByUserName(txbUserName.Text);
                //int temp = 0;
                //if (txbUserName.Text == "trido123")
                //{
                //    temp = 1;
                //}

                bool style = account.GetAccountByUserName(txbUserName.Text).style;
                

                fTableManager table = new fTableManager(txbUserName.Text,txbPassword.Text,style);
                this.Hide();
                table.ShowDialog();
                this.Show();
            }
            else
            {
                txbUserName.Text = "";
                txbPassword.Text = "";
                MessageBox.Show("UserName or Password isn't valid");
            }
        }

        private bool Login(string userName,string password)
        {
            return account.Login(userName,password);
        }
    }
}
