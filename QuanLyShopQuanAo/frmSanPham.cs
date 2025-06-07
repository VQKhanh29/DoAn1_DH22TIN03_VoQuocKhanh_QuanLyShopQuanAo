using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyShopQuanAo.Class;

namespace QuanLyShopQuanAo
{
    public partial class frmSanPham: Form
    {
        DataTable tblSP; // Bảng sản phẩm
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from tbl_DanhMucSP";
            txtMasanpham.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cbMadanhmuc, "MaDanhMuc", "TenDanhMuc");
            cbMadanhmuc.SelectedIndex = -1;
            ResetValues();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from tbl_SanPham";
            tblSP = Functions.GetDataToTable(sql);
            dgvSanpham.DataSource = tblSP;
            dgvSanpham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanpham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanpham.Columns[2].HeaderText = "Danh mục";
            dgvSanpham.Columns[3].HeaderText = "Số lượng";
            dgvSanpham.Columns[4].HeaderText = "Đơn giá nhập";
            dgvSanpham.Columns[5].HeaderText = "Đơn giá bán";
            dgvSanpham.Columns[6].HeaderText = "Ảnh";
            dgvSanpham.Columns[7].HeaderText = "Ghi chú";
            dgvSanpham.Columns[0].Width = 80;
            dgvSanpham.Columns[1].Width = 140;
            dgvSanpham.Columns[2].Width = 80;
            dgvSanpham.Columns[3].Width = 80;
            dgvSanpham.Columns[4].Width = 100;
            dgvSanpham.Columns[5].Width = 100;
            dgvSanpham.Columns[6].Width = 200;
            dgvSanpham.Columns[7].Width = 300;
            dgvSanpham.AllowUserToAddRows = false;
            dgvSanpham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //Khởi tạo lại giá trị
        private void ResetValues()
        {
            txtMasanpham.Text = "";
            txtTensanpham.Text = "";
            cbMadanhmuc.Text = "";
            txtSoluong.Text = "0";
            txtDongianhap.Text = "0";
            txtDongiaban.Text = "0";
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = false;
            txtDongiaban.Enabled = false;
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhichu.Text = "";
        }

        private void dgvSanpham_Click(object sender, EventArgs e)
        {
            string MaDanhMuc;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMasanpham.Text = dgvSanpham.CurrentRow.Cells["MaSanPham"].Value.ToString();
            txtTensanpham.Text = dgvSanpham.CurrentRow.Cells["TenSanPham"].Value.ToString();
            MaDanhMuc = dgvSanpham.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            sql = "SELECT TenDanhMuc FROM tbl_DanhMucSP WHERE MaDanhMuc=N'" + MaDanhMuc + "'";
            cbMadanhmuc.Text = Functions.GetFieldValues(sql);
            txtSoluong.Text = dgvSanpham.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDongianhap.Text = dgvSanpham.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDongiaban.Text = dgvSanpham.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            sql = "SELECT Anh FROM tbl_SanPham WHERE MaSanPham=N'" + txtMasanpham.Text + "'";
            txtAnh.Text = Functions.GetFieldValues(sql);
            picAnh.Image = Image.FromFile(txtAnh.Text);
            sql = "SELECT GhiChu FROM tbl_SanPham WHERE MaSanPham = N'" + txtMasanpham.Text + "'";
            txtGhichu.Text = Functions.GetFieldValues(sql);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMasanpham.Enabled = true;
            txtMasanpham.Focus();
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMasanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (txtTensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTensanpham.Focus();
                return;
            }
            if (cbMadanhmuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMadanhmuc.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            sql = "SELECT MaSanPham FROM tbl_SanPham WHERE MaSanPham=N'" + txtMasanpham.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại, bạn phải chọn mã sản phẩm khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            sql = "INSERT INTO tbl_SanPham(MaSanPham,TenSanPham,MaDanhMuc,SoLuong,DonGiaNhap, DonGiaBan,Anh,GhiChu) VALUES(N'"
                + txtMasanpham.Text.Trim() + "',N'" + txtTensanpham.Text.Trim() +
                "',N'" + cbMadanhmuc.SelectedValue.ToString() +
                "'," + txtSoluong.Text.Trim() + "," + txtDongianhap.Text +
                "," + txtDongiaban.Text + ",'" + txtAnh.Text + "',N'" + txtGhichu.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMasanpham.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (txtTensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTensanpham.Focus();
                return;
            }
            if (cbMadanhmuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMadanhmuc.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE tbl_SanPham SET TenSanPham=N'" + txtTensanpham.Text.Trim().ToString() +
                "',MaDanhMuc=N'" + cbMadanhmuc.SelectedValue.ToString() +
                "',SoLuong=" + txtSoluong.Text +
                ",Anh='" + txtAnh.Text + "',GhiChu=N'" + txtGhichu.Text + "' WHERE MaSanPham=N'" + txtMasanpham.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tbl_SanPham WHERE MaSanPham=N'" + txtMasanpham.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMasanpham.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienthiDS_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaSanPham,TenSanPham,MaDanhMuc,SoLuong,DonGiaNhap,DonGiaBan,Anh,GhiChu FROM tbl_SanPham";
            tblSP = Functions.GetDataToTable(sql);
            dgvSanpham.DataSource = tblSP;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMasanpham.Text == "") && (txtTensanpham.Text == "") && (cbMadanhmuc.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tbl_SanPham WHERE 1=1";
            if (txtMasanpham.Text != "")
                sql += " AND MaSanPham LIKE N'%" + txtMasanpham.Text + "%'";
            if (txtTensanpham.Text != "")
                sql += " AND TenSanPham LIKE N'%" + txtTensanpham.Text + "%'";
            if (cbMadanhmuc.Text != "")
                sql += " AND MaDanhMuc LIKE N'%" + cbMadanhmuc.SelectedValue + "%'";
            tblSP = Functions.GetDataToTable(sql);
            if (tblSP.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblSP.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSanpham.DataSource = tblSP;
            ResetValues();
        }
    }
}
