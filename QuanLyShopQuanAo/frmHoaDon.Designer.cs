namespace QuanLyShopQuanAo
{
    partial class frmHoaDon
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
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.lblMahoadon = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblNgayban = new System.Windows.Forms.Label();
            this.lblManhanvien = new System.Windows.Forms.Label();
            this.lblTennhanvien = new System.Windows.Forms.Label();
            this.lblMakhachhang = new System.Windows.Forms.Label();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dtpNgayban = new System.Windows.Forms.DateTimePicker();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.cbManhanvien = new System.Windows.Forms.ComboBox();
            this.mtbSdt = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.txtMakhachhang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMasanpham = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTensanpham = new System.Windows.Forms.Label();
            this.lblGiamgia = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.cbMasanpham = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.txtGiamgia = new System.Windows.Forms.TextBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.cbMaHD);
            this.panel1.Controls.Add(this.lblMahoadon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(298, 9);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm:";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(100, 11);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(149, 21);
            this.cbMaHD.TabIndex = 1;
            // 
            // lblMahoadon
            // 
            this.lblMahoadon.AutoSize = true;
            this.lblMahoadon.Location = new System.Drawing.Point(13, 14);
            this.lblMahoadon.Name = "lblMahoadon";
            this.lblMahoadon.Size = new System.Drawing.Size(68, 13);
            this.lblMahoadon.TabIndex = 0;
            this.lblMahoadon.Text = "Mã hóa đơn:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Enabled = false;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Enabled = false;
            this.splitContainer1.Size = new System.Drawing.Size(800, 410);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbSdt);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTenkhachhang);
            this.groupBox1.Controls.Add(this.txtMakhachhang);
            this.groupBox1.Controls.Add(this.cbManhanvien);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.dtpNgayban);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.lblSdt);
            this.groupBox1.Controls.Add(this.lblDiachi);
            this.groupBox1.Controls.Add(this.lblTenkhachhang);
            this.groupBox1.Controls.Add(this.lblMakhachhang);
            this.groupBox1.Controls.Add(this.lblTennhanvien);
            this.groupBox1.Controls.Add(this.lblManhanvien);
            this.groupBox1.Controls.Add(this.lblNgayban);
            this.groupBox1.Controls.Add(this.lblMaHD);
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(13, 20);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(68, 13);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // lblNgayban
            // 
            this.lblNgayban.AutoSize = true;
            this.lblNgayban.Location = new System.Drawing.Point(13, 48);
            this.lblNgayban.Name = "lblNgayban";
            this.lblNgayban.Size = new System.Drawing.Size(56, 13);
            this.lblNgayban.TabIndex = 1;
            this.lblNgayban.Text = "Ngày bán:";
            // 
            // lblManhanvien
            // 
            this.lblManhanvien.AutoSize = true;
            this.lblManhanvien.Location = new System.Drawing.Point(13, 76);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(75, 13);
            this.lblManhanvien.TabIndex = 2;
            this.lblManhanvien.Text = "Mã nhân viên:";
            // 
            // lblTennhanvien
            // 
            this.lblTennhanvien.AutoSize = true;
            this.lblTennhanvien.Location = new System.Drawing.Point(13, 104);
            this.lblTennhanvien.Name = "lblTennhanvien";
            this.lblTennhanvien.Size = new System.Drawing.Size(79, 13);
            this.lblTennhanvien.TabIndex = 3;
            this.lblTennhanvien.Text = "Tên nhân viên:";
            // 
            // lblMakhachhang
            // 
            this.lblMakhachhang.AutoSize = true;
            this.lblMakhachhang.Location = new System.Drawing.Point(410, 20);
            this.lblMakhachhang.Name = "lblMakhachhang";
            this.lblMakhachhang.Size = new System.Drawing.Size(85, 13);
            this.lblMakhachhang.TabIndex = 4;
            this.lblMakhachhang.Text = "Mã khách hàng:";
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Location = new System.Drawing.Point(410, 48);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(89, 13);
            this.lblTenkhachhang.TabIndex = 5;
            this.lblTenkhachhang.Text = "Tên khách hàng:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(410, 76);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(43, 13);
            this.lblDiachi.TabIndex = 6;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(410, 104);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(58, 13);
            this.lblSdt.TabIndex = 7;
            this.lblSdt.Text = "Điện thoại:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(88, 17);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(200, 20);
            this.txtMaHD.TabIndex = 8;
            // 
            // dtpNgayban
            // 
            this.dtpNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayban.Location = new System.Drawing.Point(88, 42);
            this.dtpNgayban.Name = "dtpNgayban";
            this.dtpNgayban.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayban.TabIndex = 9;
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(88, 101);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(200, 20);
            this.txtTennhanvien.TabIndex = 11;
            // 
            // cbManhanvien
            // 
            this.cbManhanvien.FormattingEnabled = true;
            this.cbManhanvien.Location = new System.Drawing.Point(88, 73);
            this.cbManhanvien.Name = "cbManhanvien";
            this.cbManhanvien.Size = new System.Drawing.Size(200, 21);
            this.cbManhanvien.TabIndex = 12;
            // 
            // mtbSdt
            // 
            this.mtbSdt.Location = new System.Drawing.Point(509, 101);
            this.mtbSdt.Mask = "(999) 000-0000";
            this.mtbSdt.Name = "mtbSdt";
            this.mtbSdt.Size = new System.Drawing.Size(191, 20);
            this.mtbSdt.TabIndex = 28;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(509, 73);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(191, 20);
            this.txtDiachi.TabIndex = 27;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(509, 45);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(191, 20);
            this.txtTenkhachhang.TabIndex = 26;
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Location = new System.Drawing.Point(509, 17);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.Size = new System.Drawing.Size(191, 20);
            this.txtMakhachhang.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoadon);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(16, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 207);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 29);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtThanhtien);
            this.panel3.Controls.Add(this.txtDongia);
            this.panel3.Controls.Add(this.txtGiamgia);
            this.panel3.Controls.Add(this.txtTensanpham);
            this.panel3.Controls.Add(this.txtSoluong);
            this.panel3.Controls.Add(this.cbMasanpham);
            this.panel3.Controls.Add(this.lblThanhtien);
            this.panel3.Controls.Add(this.lblDongia);
            this.panel3.Controls.Add(this.lblGiamgia);
            this.panel3.Controls.Add(this.lblTensanpham);
            this.panel3.Controls.Add(this.lblSoluong);
            this.panel3.Controls.Add(this.lblMasanpham);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 56);
            this.panel3.TabIndex = 1;
            // 
            // lblMasanpham
            // 
            this.lblMasanpham.AutoSize = true;
            this.lblMasanpham.Location = new System.Drawing.Point(4, 4);
            this.lblMasanpham.Name = "lblMasanpham";
            this.lblMasanpham.Size = new System.Drawing.Size(74, 13);
            this.lblMasanpham.TabIndex = 0;
            this.lblMasanpham.Text = "Mã sản phẩm:";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(4, 37);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(52, 13);
            this.lblSoluong.TabIndex = 1;
            this.lblSoluong.Text = "Số lượng:";
            // 
            // lblTensanpham
            // 
            this.lblTensanpham.AutoSize = true;
            this.lblTensanpham.Location = new System.Drawing.Point(249, 4);
            this.lblTensanpham.Name = "lblTensanpham";
            this.lblTensanpham.Size = new System.Drawing.Size(78, 13);
            this.lblTensanpham.TabIndex = 2;
            this.lblTensanpham.Text = "Tên sản phẩm:";
            // 
            // lblGiamgia
            // 
            this.lblGiamgia.AutoSize = true;
            this.lblGiamgia.Location = new System.Drawing.Point(249, 37);
            this.lblGiamgia.Name = "lblGiamgia";
            this.lblGiamgia.Size = new System.Drawing.Size(59, 13);
            this.lblGiamgia.TabIndex = 3;
            this.lblGiamgia.Text = "Giảm giá%:";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(506, 4);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(47, 13);
            this.lblDongia.TabIndex = 5;
            this.lblDongia.Text = "Đơn giá:";
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.Location = new System.Drawing.Point(506, 37);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.Size = new System.Drawing.Size(61, 13);
            this.lblThanhtien.TabIndex = 6;
            this.lblThanhtien.Text = "Thành tiền:";
            // 
            // cbMasanpham
            // 
            this.cbMasanpham.FormattingEnabled = true;
            this.cbMasanpham.Location = new System.Drawing.Point(85, 4);
            this.cbMasanpham.Name = "cbMasanpham";
            this.cbMasanpham.Size = new System.Drawing.Size(121, 21);
            this.cbMasanpham.TabIndex = 7;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(85, 33);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(121, 20);
            this.txtSoluong.TabIndex = 8;
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(333, 3);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(117, 20);
            this.txtTensanpham.TabIndex = 9;
            // 
            // txtGiamgia
            // 
            this.txtGiamgia.Location = new System.Drawing.Point(333, 33);
            this.txtGiamgia.Name = "txtGiamgia";
            this.txtGiamgia.Size = new System.Drawing.Size(117, 20);
            this.txtGiamgia.TabIndex = 10;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(580, 33);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(117, 20);
            this.txtThanhtien.TabIndex = 12;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(580, 3);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(117, 20);
            this.txtDongia.TabIndex = 11;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(629, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(437, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(243, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(63, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTongtien);
            this.panel4.Controls.Add(this.lblTongtien);
            this.panel4.Controls.Add(this.lblBangchu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(766, 33);
            this.panel4.TabIndex = 2;
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoadon.Location = new System.Drawing.Point(3, 72);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.Size = new System.Drawing.Size(766, 70);
            this.dgvHoadon.TabIndex = 3;
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.Location = new System.Drawing.Point(13, 7);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(56, 13);
            this.lblBangchu.TabIndex = 0;
            this.lblBangchu.Text = "Bằng chữ:";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(414, 7);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(55, 13);
            this.lblTongtien.TabIndex = 1;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(487, 4);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(217, 20);
            this.txtTongtien.TabIndex = 2;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDon";
            this.Text = "Hóa Đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.Label lblMahoadon;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.Label lblMakhachhang;
        private System.Windows.Forms.Label lblTennhanvien;
        private System.Windows.Forms.Label lblManhanvien;
        private System.Windows.Forms.Label lblNgayban;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.ComboBox cbManhanvien;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.DateTimePicker dtpNgayban;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.MaskedTextBox mtbSdt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.TextBox txtMakhachhang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMasanpham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtGiamgia;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.ComboBox cbMasanpham;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblGiamgia;
        private System.Windows.Forms.Label lblTensanpham;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblBangchu;
    }
}