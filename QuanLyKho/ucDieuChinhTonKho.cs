using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class ucDieuChinhTonKho : UserControl
    {
        public ucDieuChinhTonKho()
        {
            InitializeComponent();
        }

        KetNoiCSDL kn = new KetNoiCSDL();
        int viTri = 0;

        private void ucDieuChinhTonKho_Load(object sender, EventArgs e)
        {
            NAP_COMBOBOX();
            BANGDIEUCHINH();
            HIENTHIDULIEU();
        }

        private void NAP_COMBOBOX()
        {
            cbSanPham.DataSource = kn.LayBang("Select MaSanPham, TenSanPham from SanPham");
            cbSanPham.DisplayMember = "TenSanPham";
            cbSanPham.ValueMember = "MaSanPham";

            cbKho.DataSource = kn.LayBang("Select MaKho, TenKho from Kho");
            cbKho.DisplayMember = "TenKho";
            cbKho.ValueMember = "MaKho";

            cbNguoiThucHien.DataSource = kn.LayBang("Select TenDangNhap, HoTen from NguoiDung");
            cbNguoiThucHien.DisplayMember = "HoTen";
            cbNguoiThucHien.ValueMember = "TenDangNhap";
        }

        private void BANGDIEUCHINH()
        {
            dataGridView1.DataSource = kn.LayBang("SELECT * FROM DieuChinhTonKho");
        }

        private void HIENTHIDULIEU()
        {
            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0) return;

            txtSoChungTu.DataBindings.Clear();
            txtSoChungTu.DataBindings.Add("Text", dataGridView1.DataSource, "SoChungTu");

            dtpNgayDieuChinh.DataBindings.Clear();
            dtpNgayDieuChinh.DataBindings.Add("Value", dataGridView1.DataSource, "NgayDieuChinh");

            txtSoLuongTruoc.DataBindings.Clear();
            txtSoLuongTruoc.DataBindings.Add("Text", dataGridView1.DataSource, "SoLuongTruoc");

            txtSoLuongSau.DataBindings.Clear();
            txtSoLuongSau.DataBindings.Add("Text", dataGridView1.DataSource, "SoLuongSau");
            txtLyDo.DataBindings.Clear();
            txtLyDo.DataBindings.Add("Text", dataGridView1.DataSource, "LyDo");

            cbSanPham.DataBindings.Clear();
            cbSanPham.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "MaSanPham");

            cbKho.DataBindings.Clear();
            cbKho.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "MaKho");

            cbNguoiThucHien.DataBindings.Clear();
            cbNguoiThucHien.DataBindings.Add("SelectedValue", dataGridView1.DataSource, "TenDangNhap");
        }

        private void DiChuyen()
        {
            if (dataGridView1.Rows.Count == 0) return;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[viTri].Selected = true;
            this.BindingContext[dataGridView1.DataSource].Position = viTri;
        }


        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtSoChungTu.Clear();
            dtpNgayDieuChinh.Value = DateTime.Now;
            cbSanPham.SelectedIndex = 0;
            cbKho.SelectedIndex = 0;
            txtSoLuongTruoc.Text = "0";
            txtSoLuongSau.Text = "0";
            txtLyDo.Clear();
            cbNguoiThucHien.SelectedIndex = 0;
            txtSoChungTu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql_luu = string.Format(
                "INSERT INTO DieuChinhTonKho(SoChungTu, NgayDieuChinh, MaSanPham, MaKho, SoLuongTruoc, SoLuongSau, LyDo, TenDangNhap) " +
                "VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5}, N'{6}', '{7}')",
                txtSoChungTu.Text, dtpNgayDieuChinh.Value.ToString("yyyy-MM-dd"),
                cbSanPham.SelectedValue, cbKho.SelectedValue, txtSoLuongTruoc.Text,
                txtSoLuongSau.Text, txtLyDo.Text, cbNguoiThucHien.SelectedValue);

            kn.ThucThi(sql_luu);
            BANGDIEUCHINH();
            HIENTHIDULIEU();
            MessageBox.Show("Đã lưu chứng từ thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = string.Format(
                "UPDATE DieuChinhTonKho SET NgayDieuChinh='{0}', MaSanPham='{1}', MaKho='{2}', SoLuongTruoc={3}, SoLuongSau={4}, LyDo=N'{5}', TenDangNhap='{6}' WHERE SoChungTu='{7}'",
                dtpNgayDieuChinh.Value.ToString("yyyy-MM-dd"), cbSanPham.SelectedValue,
                cbKho.SelectedValue, txtSoLuongTruoc.Text, txtSoLuongSau.Text,
                txtLyDo.Text, cbNguoiThucHien.SelectedValue, txtSoChungTu.Text);

            kn.ThucThi(sql_sua);
            BANGDIEUCHINH();
            HIENTHIDULIEU();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoChungTu.Text)) return;

            string sql_xoa = "DELETE FROM DieuChinhTonKho WHERE SoChungTu = '" + txtSoChungTu.Text + "'";
            kn.ThucThi(sql_xoa);

            BANGDIEUCHINH();
            HIENTHIDULIEU();

            MessageBox.Show("Đã xóa phiếu thành công!");
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            viTri = 0;
            DiChuyen();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (viTri > 0)
            {
                viTri--;
                DiChuyen();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (viTri < dataGridView1.Rows.Count - 2)
            {
                viTri++;
                DiChuyen();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                viTri = dataGridView1.Rows.Count - 2;
                DiChuyen();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0 && viTri < dataGridView1.Rows.Count - 1) DiChuyen();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
    }
}