using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        KetNoiCSDL kn = new KetNoiCSDL();
        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black; 
            }
        }
        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Gray; 
            }
        }
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Gray;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string a = txtTenDangNhap.Text;
            string b = txtMatKhau.Text;
            string Sql1;


            Sql1 = "Select * from NguoiDung where TenDangNhap = '" + a + "' and MatKhau = '" + b + "'";

            SqlCommand cmd = new SqlCommand(Sql1, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                MainForm fmain = new MainForm();
                fmain.Show();
            }
            else
            {
                MessageBox.Show("Thong tin mat khau hoac ten dang nhap bi sai");
            }
        }
    }
}
