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
    public partial class fAccountProfile : Form
    {
        AccountService account = new AccountService();

        public fAccountProfile(string userName,string passWord)
        {
            InitializeComponent();
            txbUserName.Text = userName;
            txbPassword.Text = passWord;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateAccount()
        {
            string UserName = txbUserName.Text;
            string PassWord = txbPassword.Text;
            string NewPassWord = txbNewPass.Text;
            string ConfirmPass = txbConfirmPass.Text;
            if(!NewPassWord.Equals(ConfirmPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đúng với mật khẩu mới");
            }
            else
            {
                if(NewPassWord.Length==0)
                {
                    MessageBox.Show("Mật khẩu không được để rỗng");
                }

                bool test=account.UpdateAccount(UserName, NewPassWord);
                if(test==true)
                {
                    MessageBox.Show("Cập nhật thành công");

                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}
