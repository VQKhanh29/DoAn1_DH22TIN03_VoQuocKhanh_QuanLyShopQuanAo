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

       
    }
}
