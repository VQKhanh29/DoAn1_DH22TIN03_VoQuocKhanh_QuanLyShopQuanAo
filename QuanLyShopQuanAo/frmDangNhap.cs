using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
    public partial class frmDangNhap: Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if ((txtTaikhoang.Text == "") || (txtMatkhau.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo");
            }
            else
            {
                if ((txtTaikhoang.Text == "admin") || (txtMatkhau.Text == "123"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    {
                        frmMain f = new frmMain();
                        f.Show();
                        this.Hide();
                        f.DangXuat += F_DangXuat;
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo");
                }
            }
        }

        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as frmMain).Close();
            (sender as frmMain).isThoat = false;
            this.Show();
        }

        private void txtTaikhoang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMatkhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDangnhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
