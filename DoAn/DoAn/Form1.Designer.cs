namespace DoAn
{
    partial class frmMain
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
            this.pnlLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.btnKhachSan = new System.Windows.Forms.Button();
            this.btnNhaHang = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnDoanhSo = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlLeft.Controls.Add(this.pnlLogo);
            this.pnlLeft.Controls.Add(this.btnKhachSan);
            this.pnlLeft.Controls.Add(this.btnNhaHang);
            this.pnlLeft.Controls.Add(this.btnTaiKhoan);
            this.pnlLeft.Controls.Add(this.btnNhanVien);
            this.pnlLeft.Controls.Add(this.btnKhachHang);
            this.pnlLeft.Controls.Add(this.btnDoanhSo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(262, 728);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(260, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(262, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(805, 80);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(262, 80);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(805, 648);
            this.pnlDesktop.TabIndex = 2;
            // 
            // btnKhachSan
            // 
            this.btnKhachSan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachSan.FlatAppearance.BorderSize = 0;
            this.btnKhachSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachSan.Image = global::DoAn.Properties.Resources.hotel__4___1_;
            this.btnKhachSan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachSan.Location = new System.Drawing.Point(3, 89);
            this.btnKhachSan.Name = "btnKhachSan";
            this.btnKhachSan.Size = new System.Drawing.Size(260, 100);
            this.btnKhachSan.TabIndex = 1;
            this.btnKhachSan.Text = "Khách Sạn";
            this.btnKhachSan.UseVisualStyleBackColor = true;
            this.btnKhachSan.Click += new System.EventHandler(this.btnKhachSan_Click);
            // 
            // btnNhaHang
            // 
            this.btnNhaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhaHang.FlatAppearance.BorderSize = 0;
            this.btnNhaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaHang.Image = global::DoAn.Properties.Resources.cutlery__1_;
            this.btnNhaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaHang.Location = new System.Drawing.Point(3, 195);
            this.btnNhaHang.Name = "btnNhaHang";
            this.btnNhaHang.Size = new System.Drawing.Size(260, 100);
            this.btnNhaHang.TabIndex = 2;
            this.btnNhaHang.Text = "Nhà Hàng";
            this.btnNhaHang.UseVisualStyleBackColor = true;
            this.btnNhaHang.Click += new System.EventHandler(this.btnNhaHang_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Image = global::DoAn.Properties.Resources.account__4___1_;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(3, 301);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(260, 100);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Image = global::DoAn.Properties.Resources.customer_support__1_;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 407);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(260, 100);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Image = global::DoAn.Properties.Resources.customer_service__2___1_;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(3, 513);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(260, 100);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnDoanhSo
            // 
            this.btnDoanhSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhSo.FlatAppearance.BorderSize = 0;
            this.btnDoanhSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhSo.Image = global::DoAn.Properties.Resources.increase__2___1_;
            this.btnDoanhSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhSo.Location = new System.Drawing.Point(3, 619);
            this.btnDoanhSo.Name = "btnDoanhSo";
            this.btnDoanhSo.Size = new System.Drawing.Size(260, 100);
            this.btnDoanhSo.TabIndex = 6;
            this.btnDoanhSo.Text = "Doanh Số";
            this.btnDoanhSo.UseVisualStyleBackColor = true;
            this.btnDoanhSo.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 728);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Main";
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlLeft;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnKhachSan;
        private System.Windows.Forms.Button btnNhaHang;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnDoanhSo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlDesktop;
    }
}

