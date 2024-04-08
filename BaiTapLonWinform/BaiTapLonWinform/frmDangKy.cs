using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BaiTapLonWinform
{

    public partial class frmDangKy : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();

        public frmDangKy()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập đầy đủ thông tin
            if (txtMaDG.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập MaDG.", "Thông Báo");
                txtMaDG.Focus();
            }
            else if (txtTenTaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên tài khoản.", "Thông Báo");
                txtTenTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Mật Khẩu.", "Thông Báo");
                txtMatKhau.Focus();
            }
            else if (txtSdt.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Số điện thoại.", "Thông Báo");
                txtSdt.Focus();
            }
            else
            {
                // Kiểm tra trùng Tên Đăng Nhập trong CSDL
                string tenDangNhap = txtTenTaiKhoan.Text.Trim();
                string maDocGia = txtMaDG.Text.Trim();
                if (KiemTraTrungMaDG(maDocGia))
                {
                    MessageBox.Show(" Mã độc giả đã tồn tại. Vui lòng chọn mã khác.", "Thông Báo");
                    txtMaDG.Focus();
                }
                else if (KiemTraTrungTenDangNhap(tenDangNhap))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên khác.", "Thông Báo");
                    txtTenTaiKhoan.Focus();
                }
                else
                {
                    // Thực hiện đăng ký (gọi hàm thêm dữ liệu vào CSDL)
                    ThucHienDangKy();
                }
            }
        }

        private bool KiemTraTrungTenDangNhap(string tenDangNhap)
        {
            // Gọi hàm kiểm tra trùng tên đăng nhập từ class ConnectData
            string sqlCheck = $"SELECT * FROM tblDocGia WHERE TenTaiKhoanDG = '{tenDangNhap}'";
            DataTable dt = data.ReadData(sqlCheck);
            return dt.Rows.Count > 0;
        }
        private bool KiemTraTrungMaDG(string maDocGia)
        {
            // Gọi hàm kiểm tra trùng tên đăng nhập từ class ConnectData
            string sqlCheck = $"SELECT * FROM tblDocGia WHERE MaDG = '{maDocGia}'";
            DataTable dt = data.ReadData(sqlCheck);
            return dt.Rows.Count > 0;
        }
        private void ThucHienDangKy()
        {
            // Lấy thông tin từ các TextBox
            string maDocGia = txtMaDG.Text.Trim();
            string tenDangNhap = txtTenTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string soDienThoai = txtSdt.Text.Trim();

            // Thực hiện thêm dữ liệu vào CSDL (gọi hàm từ class ConnectData)
            string sqlInsert = $"INSERT INTO tblDocGia (MaDG, TenTaiKhoanDG, MatKhauDG, SDTDG) " +
                              $"VALUES ('{maDocGia}', '{tenDangNhap}', '{matKhau}', '{soDienThoai}')";
            data.ChangeData(sqlInsert);

            // Hiển thị thông báo đăng ký thành công
            MessageBox.Show("Đăng ký thành công.", "Thông Báo");

            // (Optional) Đặt các hành động cần thực hiện sau khi đăng ký thành công, ví dụ: chuyển đến form đăng nhập, đóng form đăng ký, vv.
            // Ví dụ: this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
