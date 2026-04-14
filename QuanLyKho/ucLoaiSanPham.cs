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
    public partial class ucLoaiSanPham : UserControl
    {
        public ucLoaiSanPham()
        {
            InitializeComponent();
        }
        KetNoiCSDL kn = new KetNoiCSDL();

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtMoTa.Text = "";
        }
        private void HIENTHIDULIEU()
        {
            txtMaLoai.DataBindings.Clear();
            txtMaLoai.DataBindings.Add("Text", dataGridView1.DataSource, "MaLoai");
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", dataGridView1.DataSource, "TenLoai");
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", dataGridView1.DataSource, "MoTa");

        }
        private void BANGLOAISANPHAM()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from LoaiSanPham");
            dataGridView1.DataSource = dta;
        }
        private void ucLoaiSanPham_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from LoaiSanPham");
            dataGridView1.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = "Delete from LoaiSanPham where MaLoai = '" + txtMaLoai.Text + "'";
            kn.ThucThi(sql_xoa);
            BANGLOAISANPHAM();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String sql_luu = "Insert into LoaiSanPham values('" + txtMaLoai.Text + "', N'" + txtTenLoai.Text + "', N'" + txtMoTa.Text + "')";
            kn.ThucThi(sql_luu);
            BANGLOAISANPHAM();
            HIENTHIDULIEU();

        }
        int viTri = 0;
        private void DiChuyenVaoBang()
        {
            if (dataGridView1.Rows.Count == 0) return;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[viTri].Selected = true;
            this.BindingContext[dataGridView1.DataSource].Position = viTri;
        }
        private void btnDau_Click(object sender, EventArgs e)
        {
            viTri = 0;
            DiChuyenVaoBang();
        }
        private void btnCuoi_Click(object sender, EventArgs e)
        {
            viTri = dataGridView1.Rows.Count - 1;
            if (viTri < 0) viTri = 0;
            DiChuyenVaoBang();
        }
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (viTri > 0)
            {
                viTri--;
                DiChuyenVaoBang();
            }
        }
        private void btnSau_Click(object sender, EventArgs e)
        {
            if (viTri < dataGridView1.Rows.Count - 1)
            {
                viTri++;
                DiChuyenVaoBang();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            String sql_sua = "Update LoaiSanPham set TenLoai = N'" + txtTenLoai.Text + "', MoTa = N'" + txtMoTa.Text + "' where MaLoai = '" + txtMaLoai.Text + "'";
            kn.ThucThi(sql_sua);
            BANGLOAISANPHAM();
            HIENTHIDULIEU();
        }
    }
}