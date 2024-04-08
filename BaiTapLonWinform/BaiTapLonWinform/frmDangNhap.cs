using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonWinform
{
    public partial class frmDangNhap : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn thoát.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            if (rdbThuThu.Checked)
            {
                if (data.KiemTraLogin(username, password, "tblThuThu"))
                {
                    frmTrangChu frmTrangChu = new frmTrangChu();
                    frmTrangChu.SetLoaiNguoiDung("ThuThu");
                    this.Hide();
                    frmTrangChu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại.");
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                    rdbThuThu.Checked = false;
                }
            }
            else if (rdbDocGia.Checked) 
            {
                if (data.KiemTraLogin(username, password, "tblDocGia"))
                {
                    frmTrangChu frmTrangChu = new frmTrangChu();
                    frmTrangChu.SetLoaiNguoiDung("DocGia");
                    this.Hide();
                    frmTrangChu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại.");
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                    rdbDocGia.Checked = false;
                }
            }
                
        }

    }
}
