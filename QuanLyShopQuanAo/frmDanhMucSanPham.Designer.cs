namespace QuanLyShopQuanAo
{
    partial class frmDanhMucSP
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTendanhmuc = new System.Windows.Forms.TextBox();
            this.txtMadanhmuc = new System.Windows.Forms.TextBox();
            this.lblTendanhmuc = new System.Windows.Forms.Label();
            this.lblMadanhmuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhmuc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDong.Location = new System.Drawing.Point(682, 32);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBoqua.Location = new System.Drawing.Point(560, 32);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 4;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(438, 32);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(310, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(183, 32);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(55, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtTendanhmuc);
            this.panel2.Controls.Add(this.txtMadanhmuc);
            this.panel2.Controls.Add(this.lblTendanhmuc);
            this.panel2.Controls.Add(this.lblMadanhmuc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 155);
            this.panel2.TabIndex = 1;
            // 
            // txtTendanhmuc
            // 
            this.txtTendanhmuc.Location = new System.Drawing.Point(163, 118);
            this.txtTendanhmuc.Name = "txtTendanhmuc";
            this.txtTendanhmuc.Size = new System.Drawing.Size(172, 20);
            this.txtTendanhmuc.TabIndex = 5;
            // 
            // txtMadanhmuc
            // 
            this.txtMadanhmuc.Location = new System.Drawing.Point(163, 73);
            this.txtMadanhmuc.Name = "txtMadanhmuc";
            this.txtMadanhmuc.Size = new System.Drawing.Size(172, 20);
            this.txtMadanhmuc.TabIndex = 6;
            this.txtMadanhmuc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMadanhmuc_KeyUp);
            // 
            // lblTendanhmuc
            // 
            this.lblTendanhmuc.AutoSize = true;
            this.lblTendanhmuc.Location = new System.Drawing.Point(55, 121);
            this.lblTendanhmuc.Name = "lblTendanhmuc";
            this.lblTendanhmuc.Size = new System.Drawing.Size(79, 13);
            this.lblTendanhmuc.TabIndex = 4;
            this.lblTendanhmuc.Text = "Tên danh mục:";
            // 
            // lblMadanhmuc
            // 
            this.lblMadanhmuc.AutoSize = true;
            this.lblMadanhmuc.Location = new System.Drawing.Point(55, 76);
            this.lblMadanhmuc.Name = "lblMadanhmuc";
            this.lblMadanhmuc.Size = new System.Drawing.Size(75, 13);
            this.lblMadanhmuc.TabIndex = 3;
            this.lblMadanhmuc.Text = "Mã danh mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDanhmuc
            // 
            this.dgvDanhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhmuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhmuc.Location = new System.Drawing.Point(0, 155);
            this.dgvDanhmuc.Name = "dgvDanhmuc";
            this.dgvDanhmuc.Size = new System.Drawing.Size(800, 214);
            this.dgvDanhmuc.TabIndex = 2;
            this.dgvDanhmuc.Click += new System.EventHandler(this.dgvDanhmuc_Click);
            // 
            // frmDanhMucSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDanhmuc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhMucSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục sản phẩm";
            this.Load += new System.EventHandler(this.frmDanhMucSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhmuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTendanhmuc;
        private System.Windows.Forms.TextBox txtMadanhmuc;
        private System.Windows.Forms.Label lblTendanhmuc;
        private System.Windows.Forms.Label lblMadanhmuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhmuc;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
    }
}