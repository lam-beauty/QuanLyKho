namespace QuanLyKho
{
    partial class ucLoaiSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLoaiSanPham));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.02236F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.97764F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.20527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.79473F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1383, 845);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai,
            this.MoTa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(71, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 627);
            this.dataGridView1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnTaoMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.lblMoTa);
            this.groupBox1.Controls.Add(this.txtTenLoai);
            this.groupBox1.Controls.Add(this.lblTenLoai);
            this.groupBox1.Controls.Add(this.lblMaLoai);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(727, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 627);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN LOẠI SẢN PHẨM";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(249, 561);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(50, 50);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoMoi.BackColor = System.Drawing.Color.White;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoMoi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTaoMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoMoi.Image")));
            this.btnTaoMoi.Location = new System.Drawing.Point(333, 561);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(50, 50);
            this.btnTaoMoi.TabIndex = 23;
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(417, 561);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 50);
            this.btnSua.TabIndex = 22;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(501, 561);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 50);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMoTa.Location = new System.Drawing.Point(178, 275);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(314, 34);
            this.txtMoTa.TabIndex = 7;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(74, 280);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(66, 25);
            this.lblMoTa.TabIndex = 6;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLoai.Location = new System.Drawing.Point(178, 211);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(314, 34);
            this.txtTenLoai.TabIndex = 5;
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Location = new System.Drawing.Point(74, 218);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(82, 25);
            this.lblTenLoai.TabIndex = 4;
            this.lblTenLoai.Text = "Tên Loại";
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Location = new System.Drawing.Point(74, 156);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(84, 25);
            this.lblMaLoai.TabIndex = 3;
            this.lblMaLoai.Text = "Mã Loại ";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLoai.Location = new System.Drawing.Point(178, 147);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(314, 34);
            this.txtMaLoai.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnDau);
            this.panel1.Controls.Add(this.btnSau);
            this.panel1.Controls.Add(this.btnCuoi);
            this.panel1.Controls.Add(this.btnTruoc);
            this.panel1.Location = new System.Drawing.Point(292, 724);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 100);
            this.panel1.TabIndex = 21;
            // 
            // btnDau
            // 
            this.btnDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDau.BackColor = System.Drawing.Color.White;
            this.btnDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDau.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDau.Image = ((System.Drawing.Image)(resources.GetObject("btnDau.Image")));
            this.btnDau.Location = new System.Drawing.Point(32, 27);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(50, 50);
            this.btnDau.TabIndex = 26;
            this.btnDau.UseVisualStyleBackColor = false;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnSau
            // 
            this.btnSau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSau.BackColor = System.Drawing.Color.White;
            this.btnSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSau.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSau.Image = ((System.Drawing.Image)(resources.GetObject("btnSau.Image")));
            this.btnSau.Location = new System.Drawing.Point(174, 27);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(50, 50);
            this.btnSau.TabIndex = 25;
            this.btnSau.UseVisualStyleBackColor = false;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCuoi.BackColor = System.Drawing.Color.White;
            this.btnCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCuoi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCuoi.Image = ((System.Drawing.Image)(resources.GetObject("btnCuoi.Image")));
            this.btnCuoi.Location = new System.Drawing.Point(245, 27);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(50, 50);
            this.btnCuoi.TabIndex = 24;
            this.btnCuoi.UseVisualStyleBackColor = false;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruoc.BackColor = System.Drawing.Color.White;
            this.btnTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTruoc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTruoc.Image = ((System.Drawing.Image)(resources.GetObject("btnTruoc.Image")));
            this.btnTruoc.Location = new System.Drawing.Point(103, 27);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(50, 50);
            this.btnTruoc.TabIndex = 23;
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại Sản Phẩm";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên Loại Sản Phẩm";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            // 
            // ucLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucLoaiSanPham";
            this.Size = new System.Drawing.Size(1383, 845);
            this.Load += new System.EventHandler(this.ucLoaiSanPham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
    }
}
