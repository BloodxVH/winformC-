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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace BaiTapLonWinform
{
    public partial class frmDoiMatKhau : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTaiKhoanCu.Text; // Get the current username, you need to implement this logic based on your application
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text;

            if (matKhauMoi != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check the old password before attempting to change it
            if (!data.KiemTraLogin(tenTaiKhoan, matKhauCu, "tblThuThu") && !data.KiemTraLogin(tenTaiKhoan, matKhauCu, "tblDocGia"))
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Attempt to change the password for both tables
            if (data.DoiMatKhauChoHaiBang(tenTaiKhoan, matKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Close the form or take any additional actions as needed
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Close the form or take any additional actions as needed
                this.Close();
            }



        }

        private void chkMatKhauCu_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMatKhauCu.Checked)
            {
                txtMatKhauCu.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = true;

            }
        }

        private void chkMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatKhauMoi.Checked)
            {
                txtMatKhauMoi.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhauMoi.UseSystemPasswordChar = true;

            }
        }

        private void chkNhapLaiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhapLaiMatKhau.Checked)
            {
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;

            }
            else
            {
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;

            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoanCu.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
