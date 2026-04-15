using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class ucPhieuXuat : UserControl
    {
        public ucPhieuXuat()
        {
            InitializeComponent();
        }

        KetNoiCSDL kn = new KetNoiCSDL();
        int viTri = 0;

        private void ucPhieuXuat_Load(object sender, EventArgs e)
        {
            NAP_COMBOBOX();
            BANGPHIEUXUAT();
            HIENTHIDULIEU();
            HIENTHICHITIET();
        }

        private void NAP_COMBOBOX()
        {
            cbKhachHang.DataSource = kn.LayBang("Select MaKH, TenKH from KhachHang");
            cbKhachHang.DisplayMember = "TenKH";
            cbKhachHang.ValueMember = "MaKH";

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

        private void BANGPHIEUXUAT()
        {
            string sql = @"SELECT SoPhieu, NgayXuat, MaKH, MaKho, TongTien, TenDangNhap, GhiChu, 
                           CASE WHEN TrangThai = 1 THEN N'Hoạt động' ELSE N'Khóa' END AS TrangThai 
                           FROM PhieuXuat";
            dataGridView1.DataSource = kn.LayBang(sql);
        }

        private void HIENTHICHITIET()
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text)) return;
            string sql = "Select MaSanPham, SoLuong, DonGiaXuat, ThanhTien from ChiTietPhieuXuat where SoPhieu = '" + txtSoPhieu.Text + "'";
            dataGridView2.DataSource = kn.LayBang(sql);
        }

        private void HIENTHIDULIEU()
        {
            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0) return;

            txtSoPhieu.DataBindings.Clear();
            txtSoPhieu.DataBindings.Add("Text", dataGridView1.DataSource, "SoPhieu");

            dtpNgayXuat.DataBindings.Clear();
            dtpNgayXuat.DataBindings.Add("Value", dataGridView1.DataSource, "NgayXuat");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dataGridView1.DataSource, "TongTien");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");

            cbKhachHang.DataBindings.Clear();
            cbKhachHang.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "MaKH");

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
            if (viTri >= 0 && viTri < dataGridView1.Rows.Count - 1) DiChuyen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;
            string sql_luu = string.Format(
                "Insert into PhieuXuat(SoPhieu, NgayXuat, MaKH, MaKho, TongTien, TenDangNhap, GhiChu, TrangThai) " +
                "values('{0}', '{1}', '{2}', '{3}', 0, '{4}', N'{5}', {6})",
                txtSoPhieu.Text, dtpNgayXuat.Value.ToString("yyyy-MM-dd"),
                cbKhachHang.SelectedValue, cbKho.SelectedValue, cbNguoiLap.SelectedValue,
                txtGhiChu.Text, trangThai);

            kn.ThucThi(sql_luu);
            BANGPHIEUXUAT();
            HIENTHIDULIEU();
            HIENTHICHITIET();
            MessageBox.Show("Lưu phiếu xuất thành công!");

        }

        private void btnTaoMoi_Click_1(object sender, EventArgs e)
        {
            txtSoPhieu.Text = "";
            dtpNgayXuat.Value = DateTime.Now;
            cbKhachHang.SelectedIndex = 0;
            cbKho.SelectedIndex = 0;
            txtTongTien.Text = "0";
            cbNguoiLap.SelectedIndex = 0;
            txtGhiChu.Text = "";
            cbTrangThai.SelectedIndex = 0;
            txtSoPhieu.Focus();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text)) return;

            string sql_xoa = "DELETE FROM PhieuXuat WHERE SoPhieu = '" + txtSoPhieu.Text + "'";
            kn.ThucThi(sql_xoa);

            BANGPHIEUXUAT();
            HIENTHIDULIEU();
            HIENTHICHITIET();

            MessageBox.Show("Đã xóa phiếu thành công!");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoPhieu.Text)) return;
            int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;
            string sql_sua = string.Format(
                "UPDATE PhieuXuat SET NgayXuat='{0}', MaKH='{1}', MaKho='{2}', TongTien='{3}', TenDangNhap='{4}', GhiChu=N'{5}', TrangThai={6} WHERE SoPhieu='{7}'",
                dtpNgayXuat.Value.ToString("yyyy-MM-dd"),
                cbKhachHang.SelectedValue, cbKho.SelectedValue, txtTongTien.Text,
                cbNguoiLap.SelectedValue, txtGhiChu.Text, trangThai, txtSoPhieu.Text
            );
            kn.ThucThi(sql_sua);
            BANGPHIEUXUAT();
            HIENTHIDULIEU();
            MessageBox.Show("Cập nhật phiếu xuất thành công!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (viTri > 0)
            {
                viTri--; DiChuyen();
            }
            ;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (viTri < dataGridView1.Rows.Count - 2)
            {
                viTri++; DiChuyen();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            viTri = dataGridView1.Rows.Count - 2; DiChuyen();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            viTri = 0; DiChuyen();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("EXEC sp_TimPhieuXuat @TuKhoa = N'{0}'", txtTimKiem.Text);

            DataTable dt = kn.LayBang(sql);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                HIENTHIDULIEU();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu xuất nào!");
                BANGPHIEUXUAT();
            }
        }
    }
}
