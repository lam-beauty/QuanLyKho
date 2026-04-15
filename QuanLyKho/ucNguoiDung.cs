using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class ucNguoiDung : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        int viTri = 0;

        public ucNguoiDung()
        {
            InitializeComponent();
        }

        private void ucNguoiDung_Load(object sender, EventArgs e)
        {

            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Hoạt động");
            cbTrangThai.Items.Add("Khóa");
            cbTrangThai.SelectedIndex = 0;

            BANGNGUOIDUNG();
            HIENTHIDULIEU();
        }

        private void BANGNGUOIDUNG()
        {
            DataTable dta = kn.LayBang("Select * from NguoiDung");
            dataGridView1.DataSource = dta;
        }

        private void HIENTHIDULIEU()
        {
            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0) return;

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", dataGridView1.DataSource, "TenDangNhap");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dataGridView1.DataSource, "MatKhau");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dataGridView1.DataSource, "HoTen");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridView1.DataSource, "Email");

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dataGridView1.DataSource, "Dienthoai"); 

            txtVaiTro.DataBindings.Clear();
            txtVaiTro.DataBindings.Add("Text", dataGridView1.DataSource, "VaiTro");
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
            txtVaiTro.Text = "";
            txtTenDangNhap.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Trạng thái Bit trong SQL: Hoạt động = 1, Khóa = 0
            int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;

            string sql_luu = string.Format(
                "Insert into NguoiDung values('{0}', '{1}', N'{2}', '{3}', '{4}', N'{5}', {6})",
                txtTenDangNhap.Text, txtMatKhau.Text, txtHoTen.Text, txtEmail.Text, txtSdt.Text, txtVaiTro.Text, trangThai);

            kn.ThucThi(sql_luu);
            BANGNGUOIDUNG();
            HIENTHIDULIEU();
            MessageBox.Show("Thêm người dùng thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;

            string sql_sua = string.Format(
                "Update NguoiDung set MatKhau='{0}', HoTen=N'{1}', Email='{2}', Dienthoai='{3}', VaiTro=N'{4}', TrangThai={5} where TenDangNhap='{6}'",
                txtMatKhau.Text, txtHoTen.Text, txtEmail.Text, txtSdt.Text, txtVaiTro.Text, trangThai, txtTenDangNhap.Text);

            kn.ThucThi(sql_sua);
            BANGNGUOIDUNG();
            HIENTHIDULIEU();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql_xoa = "Delete from NguoiDung where TenDangNhap = '" + txtTenDangNhap.Text + "'";
                kn.ThucThi(sql_xoa);
                BANGNGUOIDUNG();
                HIENTHIDULIEU();
            }
        }

        // --- Hệ thống nút di chuyển ---
        private void DiChuyen()
        {
            if (dataGridView1.Rows.Count == 0) return;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[viTri].Selected = true;
            this.BindingContext[dataGridView1.DataSource].Position = viTri;
        }

        private void btnDau_Click(object sender, EventArgs e) { viTri = 0; DiChuyen(); } // Về đầu
        private void btnCuoi_Click(object sender, EventArgs e) { viTri = dataGridView1.Rows.Count - 2; if (viTri < 0) viTri = 0; DiChuyen(); } // Về cuối
        private void btnTruoc_Click(object sender, EventArgs e) { if (viTri > 0) { viTri--; DiChuyen(); } } // Lùi
        private void btnSau_Click(object sender, EventArgs e) { if (viTri < dataGridView1.Rows.Count - 2) { viTri++; DiChuyen(); } } // Tiến

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}