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
    public partial class ucKhachHang : UserControl
    {
        public ucKhachHang()
        {
            InitializeComponent();
        }
        KetNoiCSDL kn = new KetNoiCSDL();

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";
        }
        private void HIENTHIDULIEU()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dataGridView1.DataSource, "MaKH");
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", dataGridView1.DataSource, "TenKH");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dataGridView1.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridView1.DataSource, "Email");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");

        }
        private void BANGKHACHHANG()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from KhachHang");
            dataGridView1.DataSource = dta;
        }
        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from KhachHang");
            dataGridView1.DataSource = dta;
            HIENTHIDULIEU();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = "Delete from KhachHang where MaKH = '" + txtMaKH.Text + "'";
            kn.ThucThi(sql_xoa);
            BANGKHACHHANG();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String sql_luu = "Insert into KhachHang values('" + txtMaKH.Text + "', N'" + txtTenKH.Text + "', N'" + txtDiaChi.Text + "','" + txtSdt.Text + "','" + txtEmail.Text + "', N'" + txtGhiChu.Text + "')";
            kn.ThucThi(sql_luu);
            BANGKHACHHANG();
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
            String sql_sua = "Update KhachHang set TenKH = N'" + txtTenKH.Text + "', DiaChi = N'" + txtDiaChi.Text + "', DienThoai = '" + txtSdt.Text + "', Email = '" + txtEmail.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaKH = '" + txtMaKH.Text + "'";
            kn.ThucThi(sql_sua);
            BANGKHACHHANG(); 
            HIENTHIDULIEU();
        }
    }
}