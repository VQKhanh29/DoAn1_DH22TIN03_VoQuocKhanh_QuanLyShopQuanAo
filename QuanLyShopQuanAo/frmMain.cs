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
    public partial class frmMain: Form
    {
        public bool isThoat = true;
        
        public frmMain()
        {
            InitializeComponent();
        }

        public event EventHandler DangXuat;
        private void mnuDangxuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnDanhmucSP_Click(object sender, EventArgs e)
        {
            frmDanhMucSP frm = new frmDanhMucSP();
            frm.ShowDialog();
        }

        private void mnuSanpham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.MdiParent = this; // Thiết lập frmSanPham là con của frmMain
            frm.Show();
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this; // Thiết lập frmNhanVien là con của frmMain
            frm.Show();
        }
    }
}
