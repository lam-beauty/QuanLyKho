namespace QuanLyKho
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuanLyDanhMuc = new System.Windows.Forms.Button();
            this.fpQuanLyDanhMuc = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDonVi = new System.Windows.Forms.Button();
            this.btnLoaiSanPham = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnQuanLyNghiepVu = new System.Windows.Forms.Button();
            this.fpQuanLyNghiepVu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.btnPhieuXuat = new System.Windows.Forms.Button();
            this.btnDieuChinh = new System.Windows.Forms.Button();
            this.btnNguoiDung = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panelmain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fpQuanLyDanhMuc.SuspendLayout();
            this.fpQuanLyNghiepVu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btnQuanLyDanhMuc);
            this.flowLayoutPanel1.Controls.Add(this.fpQuanLyDanhMuc);
            this.flowLayoutPanel1.Controls.Add(this.btnQuanLyNghiepVu);
            this.flowLayoutPanel1.Controls.Add(this.fpQuanLyNghiepVu);
            this.flowLayoutPanel1.Controls.Add(this.btnNguoiDung);
            this.flowLayoutPanel1.Controls.Add(this.btnBaoCao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 1055);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 85);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHO";
            // 
            // btnQuanLyDanhMuc
            // 
            this.btnQuanLyDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnQuanLyDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyDanhMuc.Location = new System.Drawing.Point(3, 94);
            this.btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            this.btnQuanLyDanhMuc.Size = new System.Drawing.Size(240, 72);
            this.btnQuanLyDanhMuc.TabIndex = 18;
            this.btnQuanLyDanhMuc.Text = "Quản lý danh mục";
            this.btnQuanLyDanhMuc.UseVisualStyleBackColor = true;
            this.btnQuanLyDanhMuc.Click += new System.EventHandler(this.btnQuanLyDanhMuc_Click);
            // 
            // fpQuanLyDanhMuc
            // 
            this.fpQuanLyDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpQuanLyDanhMuc.Controls.Add(this.btnDonVi);
            this.fpQuanLyDanhMuc.Controls.Add(this.btnLoaiSanPham);
            this.fpQuanLyDanhMuc.Controls.Add(this.btnSanPham);
            this.fpQuanLyDanhMuc.Controls.Add(this.btnKhachHang);
            this.fpQuanLyDanhMuc.Controls.Add(this.btnNhaCungCap);
            this.fpQuanLyDanhMuc.Controls.Add(this.btnKho);
            this.fpQuanLyDanhMuc.ForeColor = System.Drawing.Color.White;
            this.fpQuanLyDanhMuc.Location = new System.Drawing.Point(3, 172);
            this.fpQuanLyDanhMuc.Name = "fpQuanLyDanhMuc";
            this.fpQuanLyDanhMuc.Size = new System.Drawing.Size(246, 456);
            this.fpQuanLyDanhMuc.TabIndex = 19;
            this.fpQuanLyDanhMuc.Visible = false;
            // 
            // btnDonVi
            // 
            this.btnDonVi.FlatAppearance.BorderSize = 0;
            this.btnDonVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonVi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDonVi.ForeColor = System.Drawing.Color.White;
            this.btnDonVi.Location = new System.Drawing.Point(3, 3);
            this.btnDonVi.Name = "btnDonVi";
            this.btnDonVi.Size = new System.Drawing.Size(242, 69);
            this.btnDonVi.TabIndex = 9;
            this.btnDonVi.Text = "Đơn vị";
            this.btnDonVi.UseVisualStyleBackColor = true;
            this.btnDonVi.Click += new System.EventHandler(this.btnDonVi_Click);
            // 
            // btnLoaiSanPham
            // 
            this.btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnLoaiSanPham.Location = new System.Drawing.Point(3, 78);
            this.btnLoaiSanPham.Name = "btnLoaiSanPham";
            this.btnLoaiSanPham.Size = new System.Drawing.Size(242, 69);
            this.btnLoaiSanPham.TabIndex = 10;
            this.btnLoaiSanPham.Text = "Loại sản phẩm";
            this.btnLoaiSanPham.UseVisualStyleBackColor = true;
            this.btnLoaiSanPham.Click += new System.EventHandler(this.btnLoaiSanPham_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Location = new System.Drawing.Point(3, 153);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(242, 69);
            this.btnSanPham.TabIndex = 11;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(3, 228);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(242, 72);
            this.btnKhachHang.TabIndex = 8;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btnNhaCungCap.Location = new System.Drawing.Point(3, 306);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(236, 69);
            this.btnNhaCungCap.TabIndex = 7;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnKho
            // 
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ForeColor = System.Drawing.Color.White;
            this.btnKho.Location = new System.Drawing.Point(3, 381);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(242, 75);
            this.btnKho.TabIndex = 13;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnQuanLyNghiepVu
            // 
            this.btnQuanLyNghiepVu.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNghiepVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNghiepVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyNghiepVu.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNghiepVu.Location = new System.Drawing.Point(3, 634);
            this.btnQuanLyNghiepVu.Name = "btnQuanLyNghiepVu";
            this.btnQuanLyNghiepVu.Size = new System.Drawing.Size(240, 69);
            this.btnQuanLyNghiepVu.TabIndex = 21;
            this.btnQuanLyNghiepVu.Text = "Quản lý nghiệp vụ";
            this.btnQuanLyNghiepVu.UseVisualStyleBackColor = true;
            this.btnQuanLyNghiepVu.Click += new System.EventHandler(this.btnQuanLyNghiepVu_Click);
            // 
            // fpQuanLyNghiepVu
            // 
            this.fpQuanLyNghiepVu.AutoSize = true;
            this.fpQuanLyNghiepVu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fpQuanLyNghiepVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpQuanLyNghiepVu.Controls.Add(this.btnPhieuNhap);
            this.fpQuanLyNghiepVu.Controls.Add(this.btnPhieuXuat);
            this.fpQuanLyNghiepVu.Controls.Add(this.btnDieuChinh);
            this.fpQuanLyNghiepVu.Location = new System.Drawing.Point(3, 709);
            this.fpQuanLyNghiepVu.Name = "fpQuanLyNghiepVu";
            this.fpQuanLyNghiepVu.Size = new System.Drawing.Size(250, 227);
            this.fpQuanLyNghiepVu.TabIndex = 20;
            this.fpQuanLyNghiepVu.Visible = false;
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btnPhieuNhap.Location = new System.Drawing.Point(3, 3);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(242, 69);
            this.btnPhieuNhap.TabIndex = 14;
            this.btnPhieuNhap.Text = "Phiếu Nhập";
            this.btnPhieuNhap.UseVisualStyleBackColor = true;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.FlatAppearance.BorderSize = 0;
            this.btnPhieuXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhieuXuat.ForeColor = System.Drawing.Color.White;
            this.btnPhieuXuat.Location = new System.Drawing.Point(3, 78);
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Size = new System.Drawing.Size(236, 69);
            this.btnPhieuXuat.TabIndex = 15;
            this.btnPhieuXuat.Text = "Phiếu Xuất";
            this.btnPhieuXuat.UseVisualStyleBackColor = true;
            this.btnPhieuXuat.Click += new System.EventHandler(this.btnPhieuXuat_Click);
            // 
            // btnDieuChinh
            // 
            this.btnDieuChinh.FlatAppearance.BorderSize = 0;
            this.btnDieuChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDieuChinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDieuChinh.ForeColor = System.Drawing.Color.White;
            this.btnDieuChinh.Location = new System.Drawing.Point(3, 153);
            this.btnDieuChinh.Name = "btnDieuChinh";
            this.btnDieuChinh.Size = new System.Drawing.Size(236, 69);
            this.btnDieuChinh.TabIndex = 17;
            this.btnDieuChinh.Text = "Điều Chỉnh Tồn Kho";
            this.btnDieuChinh.UseVisualStyleBackColor = true;
            this.btnDieuChinh.Click += new System.EventHandler(this.btnDieuChinh_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnNguoiDung.Location = new System.Drawing.Point(3, 942);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(246, 69);
            this.btnNguoiDung.TabIndex = 16;
            this.btnNguoiDung.Text = "Người Dùng";
            this.btnNguoiDung.UseVisualStyleBackColor = true;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnNguoiDung_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(3, 1017);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(246, 69);
            this.btnBaoCao.TabIndex = 22;
            this.btnBaoCao.Text = "Báo cáo - Thống Kê";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(249, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 59);
            this.panel1.TabIndex = 3;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(1161, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(71, 59);
            this.btnDangXuat.TabIndex = 19;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // panelmain
            // 
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(249, 59);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1232, 996);
            this.panelmain.TabIndex = 4;
            this.panelmain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmain_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 1055);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý kho";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fpQuanLyDanhMuc.ResumeLayout(false);
            this.fpQuanLyNghiepVu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnDonVi;
        private System.Windows.Forms.Button btnLoaiSanPham;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.Button btnPhieuXuat;
        private System.Windows.Forms.Button btnNguoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDieuChinh;
        private System.Windows.Forms.Button btnQuanLyDanhMuc;
        private System.Windows.Forms.FlowLayoutPanel fpQuanLyDanhMuc;
        private System.Windows.Forms.Button btnQuanLyNghiepVu;
        private System.Windows.Forms.FlowLayoutPanel fpQuanLyNghiepVu;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button btnBaoCao;
    }
}

