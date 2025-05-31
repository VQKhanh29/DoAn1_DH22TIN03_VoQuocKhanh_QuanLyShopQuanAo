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
    public partial class frmDanhMucSP: Form
    {
        DataTable tblCL; // Chứa dữ liệu bảng DanhMucSP
        public frmDanhMucSP()
        {
            InitializeComponent();
        }

        private void frmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            txtMadanhmuc.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblDanhmuc
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaDanhMuc, TenDanhMuc FROM tbl_DanhMucSP";
            tblCL =Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvDanhmuc.DataSource = tblCL; //Nguồn dữ liệu            
            dgvDanhmuc.Columns[0].HeaderText = "Mã danh mục";
            dgvDanhmuc.Columns[1].HeaderText = "Mã danh mục";
            dgvDanhmuc.Columns[0].Width = 100;
            dgvDanhmuc.Columns[1].Width = 300;
            dgvDanhmuc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvDanhmuc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvDanhmuc_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadanhmuc.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMadanhmuc.Text = dgvDanhmuc.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            txtTendanhmuc.Text = dgvDanhmuc.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
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
            ResetValue(); //Xoá trắng các textbox
            txtMadanhmuc.Enabled = true; //cho phép nhập mới
            txtMadanhmuc.Focus();
        }

        private void ResetValue()
        {
            txtMadanhmuc.Text = "";
            txtTendanhmuc.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMadanhmuc.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadanhmuc.Focus();
                return;
            }
            if (txtTendanhmuc.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTendanhmuc.Focus();
                return;
            }
            sql = "Select MaDanhMuc From tbl_DanhMucSP where MaDanhMuc=N'" + txtMadanhmuc.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã danh mục này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMadanhmuc.Focus();
                return;
            }

            sql = "INSERT INTO tbl_DanhMucSP VALUES(N'" +
                txtMadanhmuc.Text + "',N'" + txtTendanhmuc.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMadanhmuc.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadanhmuc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTendanhmuc.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tbl_DanhMucSP SET TenDanhMuc=N'" +
                txtTendanhmuc.Text.ToString() +
                "' WHERE MaDanhMuc=N'" + txtMadanhmuc.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadanhmuc.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tbl_DanhMucSP WHERE MaDanhMuc=N'" + txtMadanhmuc.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMadanhmuc.Enabled = false;
        }

        private void txtMadanhmuc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
