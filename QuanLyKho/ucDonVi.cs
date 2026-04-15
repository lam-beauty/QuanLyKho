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
    public partial class ucDonVi : UserControl
    {
        public ucDonVi()
        {
            InitializeComponent();
        }
        KetNoiCSDL kn = new KetNoiCSDL();

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaDonVi.Text = "";
            txtTenDonVi.Text = "";
            txtGhiChu.Text = "";
        }

        private void HIENTHIDULIEU()
        {
            txtMaDonVi.DataBindings.Clear();
            txtMaDonVi.DataBindings.Add("Text", dataGridView1.DataSource, "MaDonVi");
            txtTenDonVi.DataBindings.Clear();
            txtTenDonVi.DataBindings.Add("Text", dataGridView1.DataSource, "TenDonVi");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");
        }

        private void BANGDONVI()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from DonViTinh");
            dataGridView1.DataSource = dta;
        }

        private void ucDonVi_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from DonViTinh");
            dataGridView1.DataSource = dta;
            HIENTHIDULIEU();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = "Delete from DonViTinh where MaDonVi = '" + txtMaDonVi.Text + "'";
            kn.ThucThi(sql_xoa);
            BANGDONVI();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String sql_luu = "Insert into DonViTinh values('" + txtMaDonVi.Text + "', N'" + txtTenDonVi.Text + "', N'" + txtGhiChu.Text + "')";
            kn.ThucThi(sql_luu);
            BANGDONVI();
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
            String sql_sua = "Update DonViTinh set TenDonVi = N'" + txtTenDonVi.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaDonVi = '" + txtMaDonVi.Text + "'";
            kn.ThucThi(sql_sua);
            BANGDONVI();
            HIENTHIDULIEU();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}