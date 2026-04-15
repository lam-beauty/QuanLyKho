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
    public partial class ucKho : UserControl
    {
        public ucKho()
        {
            InitializeComponent();
        }
        KetNoiCSDL kn = new KetNoiCSDL();

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtGhiChu.Text = "";
        }

        private void HIENTHITONKHO()
        {
            if (string.IsNullOrEmpty(txtMaKho.Text)) return;

            DataTable dta = new DataTable();

            string sql = "Select MaSanPham, SoLuongTon, NgayCapNhat from TonKho where MaKho = '" + txtMaKho.Text + "'";
            dta = kn.LayBang(sql);
            dataGridView2.DataSource = dta;

            if (dta.Rows.Count > 0)
            {
                dataGridView2.Columns[0].HeaderText = "Mã Sản Phẩm";
                dataGridView2.Columns[1].HeaderText = "Số Lượng Tồn";
                dataGridView2.Columns[2].HeaderText = "Ngày Cập Nhật";
            }
        }

        private void HIENTHIDULIEU()
        {
            txtMaKho.DataBindings.Clear();
            txtMaKho.DataBindings.Add("Text", dataGridView1.DataSource, "MaKho");
            txtTenKho.DataBindings.Clear();
            txtTenKho.DataBindings.Add("Text", dataGridView1.DataSource, "TenKho");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dataGridView1.DataSource, "DienThoai");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");
        }

        private void BANGKHO()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from Kho");
            dataGridView1.DataSource = dta;
        }

        private void ucKho_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("Select * from Kho");
            dataGridView1.DataSource = dta;
            HIENTHIDULIEU();
            HIENTHITONKHO();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = "Delete from Kho where MaKho = '" + txtMaKho.Text + "'";
            kn.ThucThi(sql_xoa);
            BANGKHO();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String sql_luu = "Insert into Kho values('" + txtMaKho.Text + "', N'" + txtTenKho.Text + "', N'" + txtDiaChi.Text + "', '" + txtSdt.Text + "', N'" + txtGhiChu.Text + "')";
            kn.ThucThi(sql_luu);
            BANGKHO();
            HIENTHIDULIEU();
        }

        int viTri = 0;
        private void DiChuyenVaoBang()
        {
            if (dataGridView1.Rows.Count == 0) return;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[viTri].Selected = true;
            this.BindingContext[dataGridView1.DataSource].Position = viTri;

            HIENTHITONKHO();
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
            String sql_sua = "Update Kho set TenKho = N'" + txtTenKho.Text + "', DiaChi = N'" + txtDiaChi.Text + "', DienThoai = '" + txtSdt
                .Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaKho = '" + txtMaKho.Text + "'";
            kn.ThucThi(sql_sua);
            BANGKHO();
            HIENTHIDULIEU();
        }
    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                viTri = e.RowIndex;
                DiChuyenVaoBang();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}