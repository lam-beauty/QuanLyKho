using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            fpQuanLyDanhMuc.Visible = !fpQuanLyDanhMuc.Visible;
        }

        private void btnQuanLyNghiepVu_Click(object sender, EventArgs e)
        {
            fpQuanLyNghiepVu.Visible = !fpQuanLyNghiepVu.Visible;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill; // Đổ đầy UserControl vào panel chính
            panelmain.Controls.Clear();       // Xóa UserControl cũ đang hiển thị
            panelmain.Controls.Add(userControl); // Thêm UserControl mới vào
            userControl.BringToFront();       // Đưa lên lớp trên cùng
        }

        private void btnDonVi_Click(object sender, EventArgs e)
        {
            ucDonVi uc = new ucDonVi();
            addUserControl(uc);
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            ucLoaiSanPham uc = new ucLoaiSanPham();
            addUserControl(uc);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ucSanPham uc = new ucSanPham();
            addUserControl(uc);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ucKhachHang uc = new ucKhachHang();
            addUserControl(uc);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ucNhaCungCap uc = new ucNhaCungCap();
            addUserControl(uc);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            ucKho uc = new ucKho();
            addUserControl(uc);
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            ucPhieuNhap uc = new ucPhieuNhap();
            addUserControl(uc);
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            ucPhieuXuat uc = new ucPhieuXuat();
            addUserControl(uc);
        }

        private void btnDieuChinh_Click(object sender, EventArgs e)
        {
            ucDieuChinhTonKho uc = new ucDieuChinhTonKho();
            addUserControl(uc);
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            ucNguoiDung uc = new ucNguoiDung();
            addUserControl(uc);
        }
    }
}
