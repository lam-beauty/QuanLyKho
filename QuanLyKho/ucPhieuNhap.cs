using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class ucPhieuNhap : UserControl
    {
        public ucPhieuNhap()
        {
            InitializeComponent();
        }

        KetNoiCSDL kn = new KetNoiCSDL();
        int viTri = 0;

        private void ucPhieuNhap_Load(object sender, EventArgs e)
        {
            NAP_COMBOBOX();
            BANGPHIEUNHAP();
            HIENTHIDULIEU();
            HIENTHICHITIET();
            NAP_COMBOBOX_CHITIET();
        }

        private void NAP_COMBOBOX()
        {
            cbNCC.DataSource = kn.LayBang("Select MaNCC, TenNCC from NhaCungCap");
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";

            cbKho.DataSource = kn.LayBang("Select MaKho, TenKho from Kho");
            cbKho.DisplayMember = "TenKho";
            cbKho.ValueMember = "MaKho";

            cbNguoiLap.DataSource = kn.LayBang("Select TenDangNhap, HoTen from NguoiDung");
            cbNguoiLap.DisplayMember = "HoTen";
            cbNguoiLap.ValueMember = "TenDangNhap";

            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Hoạt động");
            cbTrangThai.Items.Add("Khóa");
            cbTrangThai.SelectedIndex = 0;
        }
        private void NAP_COMBOBOX_CHITIET()
        {
            // Kiểm tra xem lưới có cột tên là "MaSanPham" không để tránh lỗi Index
            if (dataGridView2.Columns.Contains("MaSanPham"))
            {
                DataGridViewComboBoxColumn colSP = (DataGridViewComboBoxColumn)dataGridView2.Columns["MaSanPham"];
                colSP.DataSource = kn.LayBang("Select MaSanPham, TenSanPham from SanPham");
                colSP.DisplayMember = "TenSanPham";
                colSP.ValueMember = "MaSanPham";
                // Liên kết với tên cột trong DataTable tạm
                colSP.DataPropertyName = "MaSanPham";
            }
        }
        private void BANGPHIEUNHAP()
        {
            string sql = @"SELECT SoPhieu, NgayNhap, MaNCC, MaKho, TongTien, TenDangNhap, GhiChu, 
                   CASE WHEN TrangThai = 1 THEN N'Hoạt động' ELSE N'Khóa' END AS TrangThai 
                   FROM PhieuNhap";

            dataGridView1.DataSource = kn.LayBang(sql);
        }

        private void HIENTHICHITIET()
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text)) return;

            string sql = "Select MaSanPham, SoLuong, DonGiaNhap, (SoLuong * DonGiaNhap) as ThanhTien from ChiTietPhieuNhap where SoPhieu = '" + txtSoPhieu.Text + "'";
            DataTable dt = kn.LayBang(sql);

            // Gán dữ liệu mà không làm mất cấu trúc cột trong Designer
            dataGridView2.DataSource = dt;

            // Nếu có dữ liệu cũ thì không cho thêm dòng mới tùy tiện
            dataGridView2.AllowUserToAddRows = false;
        }
        private void HIENTHIDULIEU()
        {
            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0) return;

            txtSoPhieu.DataBindings.Clear();
            txtSoPhieu.DataBindings.Add("Text", dataGridView1.DataSource, "SoPhieu");

            dtpNgayNhap.DataBindings.Clear();
            dtpNgayNhap.DataBindings.Add("Value", dataGridView1.DataSource, "NgayNhap");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dataGridView1.DataSource, "TongTien");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");


            cbNCC.DataBindings.Clear();
            cbNCC.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "MaNCC");

            cbKho.DataBindings.Clear();
            cbKho.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "MaKho");

            cbNguoiLap.DataBindings.Clear();
            cbNguoiLap.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "TenDangNhap");

            cbTrangThai.DataBindings.Clear();
            cbTrangThai.DataBindings.Add("Text", dataGridView1.DataSource, "TrangThai");
        }

        private void DiChuyen()
        {
            if (dataGridView1.Rows.Count == 0) return;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[viTri].Selected = true;

            this.BindingContext[dataGridView1.DataSource].Position = viTri;

            HIENTHICHITIET();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0 && viTri < dataGridView1.Rows.Count - 1)
            {
                DiChuyen();
            }
        }
    
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu thay đổi ở cột Số lượng (index 1) hoặc Đơn giá (index 2)
            // Bạn thay đổi index (0, 1, 2...) cho đúng thứ tự cột của bạn
            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                try
                {
                    double soLuong = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[1].Value ?? 0);
                    double donGia = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells[2].Value ?? 0);

                    // Tính thành tiền và gán vào cột thứ 3
                    dataGridView2.Rows[e.RowIndex].Cells[3].Value = soLuong * donGia;

                    // Tính lại tổng tiền cho toàn bộ phiếu
                    TinhTongTienPhieu();
                }
                catch { }
            }
        }

        private void TinhTongTienPhieu()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                tong += Convert.ToDouble(row.Cells[3].Value ?? 0);
            }
            txtTongTien.Text = tong.ToString();
        }
     
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            // 1. Xóa trắng các ô thông tin
            txtSoPhieu.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
            txtTongTien.Text = "0";
            txtGhiChu.Text = "";

            // 2. Tạo bảng tạm khớp với Tên cột (DataPropertyName) trong Designer
            DataTable dtEmpty = new DataTable();
            dtEmpty.Columns.Add("MaSanPham");
            dtEmpty.Columns.Add("SoLuong", typeof(int));
            dtEmpty.Columns.Add("DonGiaNhap", typeof(int));
            dtEmpty.Columns.Add("ThanhTien", typeof(int));

            // 3. Quan trọng: Thiết lập lại lưới để chấp nhận nhập liệu
            dataGridView2.DataSource = dtEmpty;
            dataGridView2.AllowUserToAddRows = true;

            // 4. Khóa cột thành tiền vì nó sẽ tự tính
            if (dataGridView2.Columns.Contains("ThanhTien"))
                dataGridView2.Columns["ThanhTien"].ReadOnly = true;

            txtSoPhieu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text)) return;

            int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;

            string sql_sua = string.Format(
                "UPDATE PhieuNhap SET NgayNhap='{0}', MaNCC='{1}', MaKho='{2}', TongTien='{3}', TenDangNhap='{4}', GhiChu=N'{5}', TrangThai={6} WHERE SoPhieu='{7}'",
                dtpNgayNhap.Value.ToString("yyyy-MM-dd"),
                cbNCC.SelectedValue,
                cbKho.SelectedValue,
                txtTongTien.Text,
                cbNguoiLap.SelectedValue,
                txtGhiChu.Text,
                trangThai,
                txtSoPhieu.Text
            );

            kn.ThucThi(sql_sua);

            BANGPHIEUNHAP();
            HIENTHIDULIEU();

            MessageBox.Show("Cập nhật thông tin phiếu thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text)) return;
            
            string sql_xoa = "DELETE FROM PhieuNhap WHERE SoPhieu = '" + txtSoPhieu.Text + "'";
            kn.ThucThi(sql_xoa);

            BANGPHIEUNHAP();
            HIENTHIDULIEU();
            HIENTHICHITIET();

            MessageBox.Show("Đã xóa phiếu thành công!");
            
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Lưu thông tin chung vào bảng PhieuNhap
                int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;
                string sql_phieu = string.Format(
                    "Insert into PhieuNhap(SoPhieu, NgayNhap, MaNCC, MaKho, TongTien, TenDangNhap, GhiChu, TrangThai) " +
                    "values('{0}', '{1}', '{2}', '{3}', {4}, '{5}', N'{6}', {7})",
                    txtSoPhieu.Text, dtpNgayNhap.Value.ToString("yyyy-MM-dd"),
                    cbNCC.SelectedValue, cbKho.SelectedValue, txtTongTien.Text, cbNguoiLap.SelectedValue,
                    txtGhiChu.Text, trangThai);

                kn.ThucThi(sql_phieu);

                // 2. Lưu từng dòng chi tiết từ DataGridView2 vào bảng ChiTietPhieuNhap
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng trống cuối cùng của lưới

                    string maSP = row.Cells[0].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells[1].Value);
                    int donGia = Convert.ToInt32(row.Cells[2].Value);

                    string sql_chitiet = string.Format(
                        "Insert into ChiTietPhieuNhap(SoPhieu, MaSanPham, SoLuong, DonGiaNhap) " +
                        "values('{0}', '{1}', {2}, {3})",
                        txtSoPhieu.Text, maSP, soLuong, donGia);

                    kn.ThucThi(sql_chitiet);
                }

                MessageBox.Show("Lưu phiếu nhập và chi tiết thành công!");
                BANGPHIEUNHAP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (viTri > 0)
            {
                viTri--; DiChuyen();
            };

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (viTri < dataGridView1.Rows.Count - 2) 
            { 
                viTri++; DiChuyen(); 
            }
        }

        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            viTri = dataGridView1.Rows.Count - 2; DiChuyen();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        { 
            viTri = 0; DiChuyen(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = string.Format("EXEC sp_TimPhieuNhap @TuKhoa = N'{0}'", txtTimKiem.Text);

            DataTable dt = kn.LayBang(sql);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                HIENTHIDULIEU();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu nhập thỏa mãn!");
                BANGPHIEUNHAP();
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuNhap frm = new frmChiTietPhieuNhap();
            frm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
