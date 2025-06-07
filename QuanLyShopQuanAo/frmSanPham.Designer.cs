namespace QuanLyShopQuanAo
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.cbMadanhmuc = new System.Windows.Forms.ComboBox();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.txtMasanpham = new System.Windows.Forms.TextBox();
            this.lblGhichu = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.lblDongiaban = new System.Windows.Forms.Label();
            this.lbldongianhap = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblMadanhmuc = new System.Windows.Forms.Label();
            this.lblTensanpham = new System.Windows.Forms.Label();
            this.lblMasanpham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHienthiDS = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnHienthiDS);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.picAnh);
            this.panel2.Controls.Add(this.txtGhichu);
            this.panel2.Controls.Add(this.txtAnh);
            this.panel2.Controls.Add(this.txtDongiaban);
            this.panel2.Controls.Add(this.txtDongianhap);
            this.panel2.Controls.Add(this.txtSoluong);
            this.panel2.Controls.Add(this.cbMadanhmuc);
            this.panel2.Controls.Add(this.txtTensanpham);
            this.panel2.Controls.Add(this.txtMasanpham);
            this.panel2.Controls.Add(this.lblGhichu);
            this.panel2.Controls.Add(this.lblAnh);
            this.panel2.Controls.Add(this.lblDongiaban);
            this.panel2.Controls.Add(this.lbldongianhap);
            this.panel2.Controls.Add(this.lblSoluong);
            this.panel2.Controls.Add(this.lblMadanhmuc);
            this.panel2.Controls.Add(this.lblTensanpham);
            this.panel2.Controls.Add(this.lblMasanpham);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 234);
            this.panel2.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOpen.Location = new System.Drawing.Point(540, 76);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(59, 23);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Mở";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(605, 65);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(182, 157);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 17;
            this.picAnh.TabStop = false;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(362, 155);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(172, 67);
            this.txtGhichu.TabIndex = 16;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(362, 62);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(172, 80);
            this.txtAnh.TabIndex = 15;
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(122, 203);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(121, 20);
            this.txtDongiaban.TabIndex = 14;
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(122, 177);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(121, 20);
            this.txtDongianhap.TabIndex = 13;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(122, 149);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(121, 20);
            this.txtSoluong.TabIndex = 12;
            // 
            // cbMadanhmuc
            // 
            this.cbMadanhmuc.FormattingEnabled = true;
            this.cbMadanhmuc.Location = new System.Drawing.Point(122, 121);
            this.cbMadanhmuc.Name = "cbMadanhmuc";
            this.cbMadanhmuc.Size = new System.Drawing.Size(121, 21);
            this.cbMadanhmuc.TabIndex = 11;
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(122, 92);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(121, 20);
            this.txtTensanpham.TabIndex = 10;
            // 
            // txtMasanpham
            // 
            this.txtMasanpham.Location = new System.Drawing.Point(122, 62);
            this.txtMasanpham.Name = "txtMasanpham";
            this.txtMasanpham.Size = new System.Drawing.Size(121, 20);
            this.txtMasanpham.TabIndex = 9;
            // 
            // lblGhichu
            // 
            this.lblGhichu.AutoSize = true;
            this.lblGhichu.Location = new System.Drawing.Point(303, 155);
            this.lblGhichu.Name = "lblGhichu";
            this.lblGhichu.Size = new System.Drawing.Size(47, 13);
            this.lblGhichu.TabIndex = 8;
            this.lblGhichu.Text = "Ghi chú:";
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(303, 65);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(29, 13);
            this.lblAnh.TabIndex = 7;
            this.lblAnh.Text = "Ảnh:";
            // 
            // lblDongiaban
            // 
            this.lblDongiaban.AutoSize = true;
            this.lblDongiaban.Location = new System.Drawing.Point(41, 180);
            this.lblDongiaban.Name = "lblDongiaban";
            this.lblDongiaban.Size = new System.Drawing.Size(68, 13);
            this.lblDongiaban.TabIndex = 6;
            this.lblDongiaban.Text = "Đơn giá bán:";
            // 
            // lbldongianhap
            // 
            this.lbldongianhap.AutoSize = true;
            this.lbldongianhap.Location = new System.Drawing.Point(41, 206);
            this.lbldongianhap.Name = "lbldongianhap";
            this.lbldongianhap.Size = new System.Drawing.Size(74, 13);
            this.lbldongianhap.TabIndex = 5;
            this.lbldongianhap.Text = "Đơn giá nhập:";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(41, 152);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(52, 13);
            this.lblSoluong.TabIndex = 4;
            this.lblSoluong.Text = "Số lượng:";
            // 
            // lblMadanhmuc
            // 
            this.lblMadanhmuc.AutoSize = true;
            this.lblMadanhmuc.Location = new System.Drawing.Point(41, 124);
            this.lblMadanhmuc.Name = "lblMadanhmuc";
            this.lblMadanhmuc.Size = new System.Drawing.Size(75, 13);
            this.lblMadanhmuc.TabIndex = 3;
            this.lblMadanhmuc.Text = "Mã danh mục:";
            // 
            // lblTensanpham
            // 
            this.lblTensanpham.AutoSize = true;
            this.lblTensanpham.Location = new System.Drawing.Point(41, 95);
            this.lblTensanpham.Name = "lblTensanpham";
            this.lblTensanpham.Size = new System.Drawing.Size(78, 13);
            this.lblTensanpham.TabIndex = 2;
            this.lblTensanpham.Text = "Tên sản phẩm:";
            // 
            // lblMasanpham
            // 
            this.lblMasanpham.AutoSize = true;
            this.lblMasanpham.Location = new System.Drawing.Point(41, 65);
            this.lblMasanpham.Name = "lblMasanpham";
            this.lblMasanpham.Size = new System.Drawing.Size(74, 13);
            this.lblMasanpham.TabIndex = 1;
            this.lblMasanpham.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(281, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanpham.Location = new System.Drawing.Point(0, 234);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.Size = new System.Drawing.Size(800, 163);
            this.dgvSanpham.TabIndex = 2;
            this.dgvSanpham.Click += new System.EventHandler(this.dgvSanpham_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDong.Location = new System.Drawing.Point(689, 15);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBoqua.Location = new System.Drawing.Point(405, 15);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 17;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(306, 15);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(212, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(121, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(31, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHienthiDS
            // 
            this.btnHienthiDS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHienthiDS.Location = new System.Drawing.Point(594, 15);
            this.btnHienthiDS.Name = "btnHienthiDS";
            this.btnHienthiDS.Size = new System.Drawing.Size(75, 23);
            this.btnHienthiDS.TabIndex = 20;
            this.btnHienthiDS.Text = "Hiển thị DS";
            this.btnHienthiDS.UseVisualStyleBackColor = false;
            this.btnHienthiDS.Click += new System.EventHandler(this.btnHienthiDS_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem.Location = new System.Drawing.Point(499, 15);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 19;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGhichu;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblDongiaban;
        private System.Windows.Forms.Label lbldongianhap;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblMadanhmuc;
        private System.Windows.Forms.Label lblTensanpham;
        private System.Windows.Forms.Label lblMasanpham;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.ComboBox cbMadanhmuc;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.TextBox txtMasanpham;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHienthiDS;
        private System.Windows.Forms.Button btnTimkiem;
    }
}