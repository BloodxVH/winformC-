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
    public partial class frmTrangChu : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();
        private string loaiNguoiDung;

        public frmTrangChu()
        {
            InitializeComponent();
        }

        public void SetLoaiNguoiDung(string loai)
        {
            loaiNguoiDung = loai;
            CapNhatGiaoDien();
        }
        private void CapNhatGiaoDien()
        {
            // Ẩn hoặc hiển thị các chức năng dựa trên loại người dùng
            quảnLýĐộcGiảToolStripMenuItem.Visible = (loaiNguoiDung == "ThuThu");
            đăngKýTTToolStripMenuItem.Visible = (loaiNguoiDung == "ThuThu");
            báoCáoThốngKêToolStripMenuItem.Visible = (loaiNguoiDung == "ThuThu");
            quảnLýSáchToolStripMenuItem.Visible = (loaiNguoiDung == "ThuThu");
            // Các dòng khác tương tự cho các chức năng khác
        }
        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy=new frmDangKy();
            frmDangKy.Show();
        }

        private void đổiMậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm =new frmDoiMatKhau();
            frm.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaiNguoiDung == "ThuThu")
            {
                frmQLSach frmQLSach = new frmQLSach();
                frmQLSach.Show();
            }
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaiNguoiDung == "ThuThu")
            {
                frmQLDocGia frmQLDocGia = new frmQLDocGia();
                frmQLDocGia.Show();
            }           
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLMuonTra frmQLMuonTra = new frmQLMuonTra();
            frmQLMuonTra.Show();
        }        
                     
        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaiNguoiDung == "ThuThu")
            {
                frmBaoCaoThongKe BaoCaoThongKe = new frmBaoCaoThongKe();
                BaoCaoThongKe.Show();
            }
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác Nhận Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hiển thị form đăng nhập và đóng form hiện tại
                frmDangNhap frmLogin = new frmDangNhap();
                frmLogin.Show();
                this.Hide(); // Sử dụng Hide thay vì Close để giữ form hiện tại được giữ lại nhưng không hiển thị
            }
        }

        private void đăngKýTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaiNguoiDung == "ThuThu")
            {
                frmDangKyTT frmDangKyTT = new frmDangKyTT();
                frmDangKyTT.Show();
            }
        }

        private void thưVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocGia frmDocGia = new frmDocGia();
            frmDocGia.Show();
        }

        private void biểuĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaiNguoiDung == "ThuThu")
            {
                frmBieuDo frmBieuDo = new frmBieuDo();
                frmBieuDo.Show();
            }
        }
    }
}
