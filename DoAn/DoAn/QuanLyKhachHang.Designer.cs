namespace DoAn
{
    partial class frmQLKH
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
            this.grpDanhSachNV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpNV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCanCuoc = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblCanCuoc = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblHoKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDanhSachNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDanhSachNV
            // 
            this.grpDanhSachNV.Controls.Add(this.btnSua);
            this.grpDanhSachNV.Controls.Add(this.btnXoa);
            this.grpDanhSachNV.Controls.Add(this.btnThem);
            this.grpDanhSachNV.Controls.Add(this.dataGridView1);
            this.grpDanhSachNV.FillColor = System.Drawing.Color.Aquamarine;
            this.grpDanhSachNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpDanhSachNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpDanhSachNV.Location = new System.Drawing.Point(96, 260);
            this.grpDanhSachNV.Name = "grpDanhSachNV";
            this.grpDanhSachNV.Size = new System.Drawing.Size(748, 378);
            this.grpDanhSachNV.TabIndex = 6;
            this.grpDanhSachNV.Text = "Danh Sách Nhân Viên";
            // 
            // btnSua
            // 
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::DoAn.Properties.Resources.pencil;
            this.btnSua.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSua.Location = new System.Drawing.Point(497, 258);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 71);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "   Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::DoAn.Properties.Resources.cancel;
            this.btnXoa.ImageSize = new System.Drawing.Size(50, 50);
            this.btnXoa.Location = new System.Drawing.Point(497, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 71);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "   Xóa";
            // 
            // btnThem
            // 
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::DoAn.Properties.Resources.plus;
            this.btnThem.ImageSize = new System.Drawing.Size(50, 50);
            this.btnThem.Location = new System.Drawing.Point(497, 77);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 71);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = " Thêm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(448, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpNV
            // 
            this.grpNV.BackColor = System.Drawing.Color.Transparent;
            this.grpNV.Controls.Add(this.txtSDT);
            this.grpNV.Controls.Add(this.label1);
            this.grpNV.Controls.Add(this.radNu);
            this.grpNV.Controls.Add(this.radNam);
            this.grpNV.Controls.Add(this.lblGioiTinh);
            this.grpNV.Controls.Add(this.dtpNgaySinh);
            this.grpNV.Controls.Add(this.lblNgaySinh);
            this.grpNV.Controls.Add(this.txtDiaChi);
            this.grpNV.Controls.Add(this.txtCanCuoc);
            this.grpNV.Controls.Add(this.lblDiaChi);
            this.grpNV.Controls.Add(this.lblCanCuoc);
            this.grpNV.Controls.Add(this.txtTenNV);
            this.grpNV.Controls.Add(this.txtHoNV);
            this.grpNV.Controls.Add(this.txtMaNV);
            this.grpNV.Controls.Add(this.lblTenKH);
            this.grpNV.Controls.Add(this.lblHoKH);
            this.grpNV.Controls.Add(this.lblMaKH);
            this.grpNV.FillColor = System.Drawing.Color.Aquamarine;
            this.grpNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpNV.Location = new System.Drawing.Point(96, 11);
            this.grpNV.Name = "grpNV";
            this.grpNV.Size = new System.Drawing.Size(748, 243);
            this.grpNV.TabIndex = 5;
            this.grpNV.Text = "Thông Tin Nhân Viên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(497, 152);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(236, 39);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtCanCuoc
            // 
            this.txtCanCuoc.Location = new System.Drawing.Point(497, 56);
            this.txtCanCuoc.Name = "txtCanCuoc";
            this.txtCanCuoc.Size = new System.Drawing.Size(164, 31);
            this.txtCanCuoc.TabIndex = 12;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(356, 155);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(68, 25);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblCanCuoc
            // 
            this.lblCanCuoc.AutoSize = true;
            this.lblCanCuoc.Location = new System.Drawing.Point(356, 56);
            this.lblCanCuoc.Name = "lblCanCuoc";
            this.lblCanCuoc.Size = new System.Drawing.Size(88, 25);
            this.lblCanCuoc.TabIndex = 10;
            this.lblCanCuoc.Text = "Căn Cước";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(497, 101);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(164, 31);
            this.txtTenNV.TabIndex = 8;
            // 
            // txtHoNV
            // 
            this.txtHoNV.Location = new System.Drawing.Point(171, 98);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(156, 31);
            this.txtHoNV.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(171, 56);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(156, 31);
            this.txtMaNV.TabIndex = 4;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(356, 101);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(138, 25);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // lblHoKH
            // 
            this.lblHoKH.AutoSize = true;
            this.lblHoKH.Location = new System.Drawing.Point(27, 101);
            this.lblHoKH.Name = "lblHoKH";
            this.lblHoKH.Size = new System.Drawing.Size(110, 25);
            this.lblHoKH.TabIndex = 1;
            this.lblHoKH.Text = "Họ Tên Đệm";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(27, 56);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(137, 25);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã Khách Hàng";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(27, 191);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(93, 25);
            this.lblNgaySinh.TabIndex = 14;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(171, 197);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(156, 31);
            this.dtpNgaySinh.TabIndex = 15;
            this.dtpNgaySinh.Value = new System.DateTime(2023, 5, 26, 13, 17, 17, 0);
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(356, 197);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(81, 25);
            this.lblGioiTinh.TabIndex = 16;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(509, 211);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(75, 29);
            this.radNam.TabIndex = 17;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(625, 211);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(61, 29);
            this.radNu.TabIndex = 18;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(171, 149);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(156, 31);
            this.txtSDT.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số Điện Thoai";
            // 
            // frmQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(941, 648);
            this.Controls.Add(this.grpDanhSachNV);
            this.Controls.Add(this.grpNV);
            this.Name = "frmQLKH";
            this.Text = "Quản Lý Khách Hàng";
            this.grpDanhSachNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpNV.ResumeLayout(false);
            this.grpNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachNV;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GroupBox grpNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCanCuoc;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblCanCuoc;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblHoKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
    }
}