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
    public partial class ucNhaCungCap : UserControl
    {
        public ucNhaCungCap()
        {
            InitializeComponent();
        }
        KetNoiCSDL kn = new KetNoiCSDL();

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";
        }
        private void HIENTHIDULIEU()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dataGridView1.DataSource, "MaNCC");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", dataGridView1.DataSource, "TenNCC");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dataGridView1.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridView1.DataSource, "Email");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");

        }
        private void BANGNCC()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from NhaCungCap");
            dataGridView1.DataSource = dta;
        }
        private void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from NhaCungCap");
            dataGridView1.DataSource = dta;
            HIENTHIDULIEU();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = "Delete from NhaCungCap where MaNCC = '" + txtMaNCC.Text + "'";
            kn.ThucThi(sql_xoa);
            BANGNCC();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String sql_luu = "Insert into NhaCungCap values('" + txtMaNCC.Text + "', N'" + txtTenNCC.Text + "', N'" + txtDiaChi.Text + "','" + txtSdt.Text + "','" + txtEmail.Text + "', N'" + txtGhiChu.Text + "')";
            kn.ThucThi(sql_luu);
            BANGNCC();
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
            String sql_sua = "Update NhaCungCap set TenNCC = N'" + txtTenNCC.Text + "', DiaChi = N'" + txtDiaChi.Text + "', DienThoai = '" + txtSdt.Text + "', Email = '" + txtEmail.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaNCC = '" + txtMaNCC.Text + "'";
            kn.ThucThi(sql_sua);
            BANGNCC();
            HIENTHIDULIEU();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}