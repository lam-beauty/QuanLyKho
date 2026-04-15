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
    public partial class frmChiTietPhieuNhap : Form
    {
        // Khởi tạo lớp kết nối
        KetNoiCSDL kn = new KetNoiCSDL();

        // Các thuộc tính để truyền dữ liệu về ucPhieuNhap
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        // Hàm nạp danh sách sản phẩm vào ComboBox
        private void LoadSanPham()
        {
            string sql = "SELECT MaSanPham, TenSanPham FROM SanPham";
            DataTable dt = kn.LayBang(sql);

            cbSanPham.DataSource = dt;
            cbSanPham.DisplayMember = "TenSanPham"; // Hiển thị tên
            cbSanPham.ValueMember = "MaSanPham";   // Lưu giá trị là mã
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return;
            }

            try
            {
                // 2. Lấy dữ liệu từ giao diện
                MaSP = cbSanPham.SelectedValue.ToString();
                SoLuong = int.Parse(txtSoLuong.Text);

                // 3. Lấy Đơn giá nhập mặc định từ bảng SanPham trong CSDL
                // Việc này giúp Đơn giá tự động khớp với mặt hàng mà không cần người dùng nhập
                string sqlGia = "SELECT GiaNhapMacDinh FROM SanPham WHERE MaSanPham = '" + MaSP + "'";
                DataTable dtGia = kn.LayBang(sqlGia);

                if (dtGia.Rows.Count > 0)
                {
                    DonGia = int.Parse(dtGia.Rows[0]["GiaNhapMacDinh"].ToString());
                }
                else
                {
                    DonGia = 0; // Đề phòng trường hợp SP chưa có giá
                }

                // 4. Trả về kết quả OK để ucPhieuNhap biết là đã nhập xong
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi định dạng số lượng: " + ex.Message);
            }
        }
    }
}