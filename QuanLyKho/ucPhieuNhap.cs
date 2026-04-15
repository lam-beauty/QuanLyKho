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
            string sql = "Select MaSanPham, SoLuong, DonGiaNhap, ThanhTien from ChiTietPhieuNhap where SoPhieu = '" + txtSoPhieu.Text + "'";
            dataGridView2.DataSource = kn.LayBang(sql);
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

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtSoPhieu.Text = "";
            dtpNgayNhap.Value = DateTime.Now; 
            cbNCC.SelectedIndex = 0;     
            cbKho.SelectedIndex = 0;       
            txtTongTien.Text = "0";
            cbNguoiLap.SelectedIndex = 0;
            txtGhiChu.Text = "";
            cbTrangThai.SelectedIndex = 0;
            dataGridView2.DataSource = null;
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
            int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;
            string sql_luu = string.Format(
                "Insert into PhieuNhap(SoPhieu, NgayNhap, MaNCC, MaKho, TongTien, TenDangNhap, GhiChu, TrangThai) " +
                "values('{0}', '{1}', '{2}', '{3}', 0, '{4}', N'{5}', {6})",
                txtSoPhieu.Text, dtpNgayNhap.Value.ToString("yyyy-MM-dd"),
                cbNCC.SelectedValue, cbKho.SelectedValue, cbNguoiLap.SelectedValue,
                txtGhiChu.Text, trangThai);

            kn.ThucThi(sql_luu);
            BANGPHIEUNHAP();
            HIENTHIDULIEU();
            HIENTHICHITIET();
            MessageBox.Show("Lưu phiếu nhập thành công!");

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
    }
}
