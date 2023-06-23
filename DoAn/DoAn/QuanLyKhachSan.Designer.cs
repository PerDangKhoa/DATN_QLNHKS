namespace DoAn
{
    partial class frmQLKS
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
            this.tabKhachSan = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.grpDanhSachPhong = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpPhong = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.cboLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.tabKhachSan.SuspendLayout();
            this.tabPhong.SuspendLayout();
            this.grpDanhSachPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKhachSan
            // 
            this.tabKhachSan.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabKhachSan.Controls.Add(this.tabPhong);
            this.tabKhachSan.Controls.Add(this.tabDichVu);
            this.tabKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKhachSan.ItemSize = new System.Drawing.Size(180, 40);
            this.tabKhachSan.Location = new System.Drawing.Point(0, 0);
            this.tabKhachSan.Name = "tabKhachSan";
            this.tabKhachSan.SelectedIndex = 0;
            this.tabKhachSan.Size = new System.Drawing.Size(922, 689);
            this.tabKhachSan.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabKhachSan.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabKhachSan.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabKhachSan.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabKhachSan.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabKhachSan.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabKhachSan.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabKhachSan.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabKhachSan.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabKhachSan.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabKhachSan.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabKhachSan.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabKhachSan.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabKhachSan.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabKhachSan.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabKhachSan.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabKhachSan.TabIndex = 1;
            this.tabKhachSan.TabMenuBackColor = System.Drawing.Color.Cyan;
            // 
            // tabPhong
            // 
            this.tabPhong.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPhong.Controls.Add(this.grpDanhSachPhong);
            this.tabPhong.Controls.Add(this.grpPhong);
            this.tabPhong.Location = new System.Drawing.Point(184, 4);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(734, 681);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Phòng";
            // 
            // grpDanhSachPhong
            // 
            this.grpDanhSachPhong.Controls.Add(this.btnSua);
            this.grpDanhSachPhong.Controls.Add(this.btnXoa);
            this.grpDanhSachPhong.Controls.Add(this.btnThem);
            this.grpDanhSachPhong.Controls.Add(this.dataGridView1);
            this.grpDanhSachPhong.FillColor = System.Drawing.Color.Aquamarine;
            this.grpDanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpDanhSachPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpDanhSachPhong.Location = new System.Drawing.Point(26, 277);
            this.grpDanhSachPhong.Name = "grpDanhSachPhong";
            this.grpDanhSachPhong.Size = new System.Drawing.Size(686, 371);
            this.grpDanhSachPhong.TabIndex = 1;
            this.grpDanhSachPhong.Text = "Danh Sách Phòng";
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
            // grpPhong
            // 
            this.grpPhong.BackColor = System.Drawing.Color.Transparent;
            this.grpPhong.Controls.Add(this.textBox5);
            this.grpPhong.Controls.Add(this.lblSucChua);
            this.grpPhong.Controls.Add(this.textBox2);
            this.grpPhong.Controls.Add(this.lblMoTa);
            this.grpPhong.Controls.Add(this.cboLoaiPhong);
            this.grpPhong.Controls.Add(this.textBox4);
            this.grpPhong.Controls.Add(this.textBox3);
            this.grpPhong.Controls.Add(this.textBox1);
            this.grpPhong.Controls.Add(this.lblGia);
            this.grpPhong.Controls.Add(this.lblSoPhong);
            this.grpPhong.Controls.Add(this.lblLoaiPhong);
            this.grpPhong.Controls.Add(this.lblMaPhong);
            this.grpPhong.FillColor = System.Drawing.Color.Aquamarine;
            this.grpPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grpPhong.Location = new System.Drawing.Point(26, 21);
            this.grpPhong.Name = "grpPhong";
            this.grpPhong.Size = new System.Drawing.Size(686, 225);
            this.grpPhong.TabIndex = 0;
            this.grpPhong.Text = "Thông Tin Phòng";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(440, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 31);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(440, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 31);
            this.textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 31);
            this.textBox1.TabIndex = 4;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(372, 100);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(37, 25);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Giá";
            this.lblGia.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(344, 53);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(90, 25);
            this.lblSoPhong.TabIndex = 2;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(27, 95);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(101, 25);
            this.lblLoaiPhong.TabIndex = 1;
            this.lblLoaiPhong.Text = "Loại Phòng";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(27, 53);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(94, 25);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã Phòng";
            // 
            // tabDichVu
            // 
            this.tabDichVu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabDichVu.Location = new System.Drawing.Point(184, 4);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(734, 681);
            this.tabDichVu.TabIndex = 1;
            this.tabDichVu.Text = "Dịch Vụ";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiPhong.ItemHeight = 30;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Thường",
            "VIP"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(141, 95);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(191, 36);
            this.cboLoaiPhong.TabIndex = 9;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(42, 149);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(62, 25);
            this.lblMoTa.TabIndex = 10;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 146);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 54);
            this.textBox2.TabIndex = 11;
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(347, 149);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(87, 25);
            this.lblSucChua.TabIndex = 12;
            this.lblSucChua.Text = "Sức Chứa";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(440, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 31);
            this.textBox5.TabIndex = 13;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSua.BorderRadius = 15;
            this.btnSua.BorderThickness = 2;
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
            this.btnXoa.BackColor = System.Drawing.Color.Aquamarine;
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.BorderThickness = 2;
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
            this.btnThem.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThem.BorderRadius = 15;
            this.btnThem.BorderThickness = 2;
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
            // frmQLKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 689);
            this.Controls.Add(this.tabKhachSan);
            this.Name = "frmQLKS";
            this.Text = "Quản Lý Khách Sạn";
            this.tabKhachSan.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.grpDanhSachPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpPhong.ResumeLayout(false);
            this.grpPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabKhachSan;
        private System.Windows.Forms.TabPage tabPhong;
        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachPhong;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GroupBox grpPhong;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TabPage tabDichVu;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiPhong;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblMoTa;
    }
}