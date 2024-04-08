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
    public partial class frmDangKyTT : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();

        public frmDangKyTT()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ giao diện người dùng
            string maThuThu = txtMaTT.Text.Trim();
            string hoTen = txtTenTT.Text.Trim();
            DateTime ngaySinh = dtmNgaySinh.Value;
            string gioiTinh = cboGioiTinh.SelectedItem.ToString();
            string sdt = txtSoDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();
            string tenTaiKhoan = txtTenTK.Text.Trim();
            string matKhau = txtMK.Text;
            string nhapLaiMatKhau = txtNhapLaiMK.Text;

            // Kiểm tra mật khẩu nhập lại có khớp không
            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem tên tài khoản và mã tt đã tồn tại chưa
            if (KiemTraTrungMaTT(maThuThu))
            {
                MessageBox.Show("Mã thủ thư đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (KiemTraTrungTenDangNhap(tenTaiKhoan))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện thêm dữ liệu vào CSDL
            string sqlInsert = $"INSERT INTO tblThuThu (MaTT,TenTT, GioiTinhTT, NgaySinhTT, SDTTT, DiaChiTT, GhiChu, TenTaiKhoanTT, MatKhauTT) " +
                               $"VALUES ('{maThuThu}','{hoTen}', '{gioiTinh}', '{ngaySinh.ToString("yyyy-MM-dd")}', '{sdt}', '{diaChi}', '{ghiChu}', '{tenTaiKhoan}', '{matKhau}')";

            // Gọi hàm từ class ConnectData để thực hiện câu lệnh INSERT
            data.ChangeData(sqlInsert);

            MessageBox.Show("Đăng ký thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng form đăng ký sau khi đăng ký thành công
            this.Close();
        }
        private bool KiemTraTrungTenDangNhap(string tenDangNhap)
        {
            // Gọi hàm kiểm tra trùng tên đăng nhập từ class ConnectData
            string sqlCheck = $"SELECT * FROM tblThuThu WHERE TenTaiKhoanTT = '{tenDangNhap}'";
            DataTable dt = data.ReadData(sqlCheck);
            return dt.Rows.Count > 0;
        }
        private bool KiemTraTrungMaTT(string maThuThu)
        {
            // Gọi hàm kiểm tra trùng tên đăng nhập từ class ConnectData
            string sqlCheck = $"SELECT * FROM tblThuThu WHERE MaTT = '{maThuThu}'";
            DataTable dt = data.ReadData(sqlCheck);
            return dt.Rows.Count > 0;
        }

        

        private void frmDangKyTT_Load(object sender, EventArgs e)
        {
            {
                // Thêm các giá trị giới tính vào ComboBox
                cboGioiTinh.Items.Add("Nam");
                cboGioiTinh.Items.Add("Nữ");

                // Chọn giá trị mặc định (nếu cần)
                cboGioiTinh.SelectedIndex = 0; // Chọn "Nam" làm giá trị mặc định
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
