using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class ucSanPham : UserControl
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        int viTri = 0;

        public ucSanPham()
        {
            InitializeComponent();
        }

        private void ucSanPham_Load(object sender, EventArgs e)
        {
            NAP_COMBOBOX();
            BANGSANPHAM();
            HIENTHIDULIEU();
        }

        private void NAP_COMBOBOX()
        {
            cbLoaiSP.DataSource = kn.LayBang("Select * from LoaiSanPham");
            cbLoaiSP.DisplayMember = "TenLoai";
            cbLoaiSP.ValueMember = "MaLoai";
            cbDonVi.DataSource = kn.LayBang("Select * from DonViTinh");
            cbDonVi.DisplayMember = "TenDonVi";
            cbDonVi.ValueMember = "MaDonVi";
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Đang kinh doanh");
            cbTrangThai.Items.Add("Ngừng kinh doanh");
            cbTrangThai.SelectedIndex = 0;
        }

        private void BANGSANPHAM()
        {
            string sql = @"SELECT sp.*, l.TenLoai, d.TenDonVi 
                           FROM SanPham sp 
                           LEFT JOIN LoaiSanPham l ON sp.MaLoai = l.MaLoai 
                           LEFT JOIN DonViTinh d ON sp.MaDonVi = d.MaDonVi";
            dataGridView1.DataSource = kn.LayBang(sql);
        }

        private void HIENTHIDULIEU()
        {
            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0) return;

            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", dataGridView1.DataSource, "MaSanPham");

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", dataGridView1.DataSource, "TenSanPham");

            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("Text", dataGridView1.DataSource, "GiaNhapMacDinh");

            txtGiaXuat.DataBindings.Clear();
            txtGiaXuat.DataBindings.Add("Text", dataGridView1.DataSource, "GiaXuatMacDinh");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");

            cbLoaiSP.SelectedValue = dataGridView1.CurrentRow.Cells["MaLoai"].Value;
            cbDonVi.SelectedValue = dataGridView1.CurrentRow.Cells["MaDonVi"].Value;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaNhap.Text = "0";
            txtGiaXuat.Text = "0";
            txtGhiChu.Text = "";
            txtMaSP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;

            string sql_luu = string.Format(
                "INSERT INTO SanPham VALUES('{0}', N'{1}', '{2}', '{3}', {4}, {5}, N'{6}', {7})",
                txtMaSP.Text, txtTenSP.Text, cbLoaiSP.SelectedValue, cbDonVi.SelectedValue,
                txtGiaNhap.Text, txtGiaXuat.Text, txtGhiChu.Text, trangThai);

            kn.ThucThi(sql_luu);
            BANGSANPHAM();
            HIENTHIDULIEU();
            MessageBox.Show("Thêm sản phẩm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int trangThai = (cbTrangThai.SelectedIndex == 0) ? 1 : 0;

            string sql_sua = string.Format(
                "UPDATE SanPham SET TenSanPham=N'{0}', MaLoai='{1}', MaDonVi='{2}', GiaNhapMacDinh={3}, GiaXuatMacDinh={4}, GhiChu=N'{5}', TrangThai={6} WHERE MaSanPham='{7}'",
                txtTenSP.Text, cbLoaiSP.SelectedValue, cbDonVi.SelectedValue,
                txtGiaNhap.Text, txtGiaXuat.Text, txtGhiChu.Text, trangThai, txtMaSP.Text);

            kn.ThucThi(sql_sua);
            BANGSANPHAM();
            HIENTHIDULIEU();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql_xoa = "DELETE FROM SanPham WHERE MaSanPham = '" + txtMaSP.Text + "'";
                kn.ThucThi(sql_xoa);
                BANGSANPHAM();
                HIENTHIDULIEU();
            }
        }


        private void DiChuyen()
        {
            if (dataGridView1.Rows.Count == 0) return;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[viTri].Selected = true;
            this.BindingContext[dataGridView1.DataSource].Position = viTri;
            cbLoaiSP.SelectedValue = dataGridView1.Rows[viTri].Cells["MaLoai"].Value;
            cbDonVi.SelectedValue = dataGridView1.Rows[viTri].Cells["MaDonVi"].Value;
        }

        private void btnDau_Click(object sender, EventArgs e) { viTri = 0; DiChuyen(); } 
        private void btnCuoi_Click(object sender, EventArgs e) { viTri = dataGridView1.Rows.Count - 2; DiChuyen(); } 
        private void btnTruoc_Click(object sender, EventArgs e) { if (viTri > 0) { viTri--; DiChuyen(); } } 
        private void btnSau_Click(object sender, EventArgs e) { if (viTri < dataGridView1.Rows.Count - 2) { viTri++; DiChuyen(); } } 

      
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT sp.*, l.TenLoai, d.TenDonVi FROM SanPham sp " +
                         "LEFT JOIN LoaiSanPham l ON sp.MaLoai = l.MaLoai " +
                         "LEFT JOIN DonViTinh d ON sp.MaDonVi = d.MaDonVi " +
                         "WHERE sp.TenSanPham LIKE N'%" + txtTimKiem.Text + "%' OR sp.MaSanPham LIKE '%" + txtTimKiem.Text + "%'";
            dataGridView1.DataSource = kn.LayBang(sql);
        }
    }
}