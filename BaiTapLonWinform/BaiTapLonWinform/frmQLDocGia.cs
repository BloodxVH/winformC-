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
using System.Data.Common;

namespace BaiTapLonWinform
{
    public partial class frmQLDocGia : Form
    {
        Classes.CommonFuntions function = new Classes.CommonFuntions();
        Classes.ConnectData data = new Classes.ConnectData();
        public frmQLDocGia()
        {
            InitializeComponent();
            DataTable dtDocGia = data.ReadData("Select * from tblDocGia");
            function.FillComboBox(cboGioiTinh, dtDocGia, "GioiTinhDG", "MaDG");
            function.FillComboBox(cboLoaiDG, dtDocGia, "LoaiDG", "MaDG");
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {

        }

        private void frmQLDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridViewDSDocGia.Columns[0].HeaderText = "Ma DG";
            dataGridViewDSDocGia.Columns[1].HeaderText = "Ten DG";
            dataGridViewDSDocGia.Columns[2].HeaderText = "Gioi Tinh";
            dataGridViewDSDocGia.Columns[3].HeaderText = "Ngay Sinh";
            dataGridViewDSDocGia.Columns[4].HeaderText = "SDT DG";
            dataGridViewDSDocGia.Columns[5].HeaderText = "DiaChiDG";
            dataGridViewDSDocGia.Columns[6].HeaderText = "Loai DG";
            dataGridViewDSDocGia.Columns[7].HeaderText = "Ghi Chu";
            dataGridViewDSDocGia.Columns[8].HeaderText = "TenTaiKhoanDG";
            dataGridViewDSDocGia.Columns[9].HeaderText = "MatKhauDG";

        }
        void LoadData()
        {
            DataTable dtDG = data.ReadData("Select * from tblDocGia");
            dataGridViewDSDocGia.DataSource = dtDG;
        }

        private void dataGridViewDSDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[0].Value.ToString();
            txtTenDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[1].Value.ToString();
            dtmNgaySinh.Text = dataGridViewDSDocGia.CurrentRow.Cells[3].Value.ToString();
            txtTenTK.Text = dataGridViewDSDocGia.CurrentRow.Cells[8].Value.ToString();
            txtMK.Text = dataGridViewDSDocGia.CurrentRow.Cells[9].Value.ToString();
            cboGioiTinh.Text = dataGridViewDSDocGia.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridViewDSDocGia.CurrentRow.Cells[5].Value.ToString();
            txtSoDT.Text = dataGridViewDSDocGia.CurrentRow.Cells[4].Value.ToString();
            cboLoaiDG.Text = dataGridViewDSDocGia.CurrentRow.Cells[6].Value.ToString();
            txtGhiChu.Text = dataGridViewDSDocGia.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra mã có trùng hay không
            DataTable dtCheckDocGia = data.ReadData("Select * from tblDocGia where MaDG='" + txtMaDG.Text + "' ");
            if (dtCheckDocGia.Rows.Count > 0)
            {
                MessageBox.Show("Ma hang da co,moi ban nhap ma khac");
                txtMaDG.Focus();
                return;
            }
            // Kiểm tra xem đã nhập đủ thông tin hay chưa
            if (string.IsNullOrEmpty(txtTenDG.Text) || string.IsNullOrEmpty(dtmNgaySinh.Text) || string.IsNullOrEmpty(txtTenTK.Text) || string.IsNullOrEmpty(txtMK.Text)
                || string.IsNullOrEmpty(cboGioiTinh.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSoDT.Text) || string.IsNullOrEmpty(cboLoaiDG.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Lỗi");
                return;
            }

            try
            {
                string maDG = txtMaDG.Text;
                string tenDG = txtTenDG.Text;
                string gioiTinh = cboGioiTinh.Text;
                string ngaySinh = dtmNgaySinh.Text;
                string sdt = txtSoDT.Text;
                string diaChi = txtDiaChi.Text;
                string loaiDG = cboLoaiDG.Text;
                string ghiChu = txtGhiChu.Text;
                string tenTaiKhoan = txtTenTK.Text;
                string matKhau = txtMK.Text;

                // Kiểm tra tính hợp lệ của dữ liệu nếu cần

                // Xây dựng câu truy vấn SQL để thêm bản ghi mới vào tblDocGia
                string sqlInsert = $"INSERT INTO tblDocGia VALUES ('{maDG}', N'{tenDG}', N'{gioiTinh}', '{ngaySinh}', '{sdt}', N'{diaChi}', N'{loaiDG}', N'{ghiChu}', '{tenTaiKhoan}', '{matKhau}')";

                // Gọi phương thức ChangeData từ lớp ConnectData để thực thi câu truy vấn
                data.ChangeData(sqlInsert);
                // Làm mới DataGridView để hiển thị dữ liệu đã cập nhật
                LoadData();
                // Thông báo thành công
                MessageBox.Show("Thêm độc giả thành công!");
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        void ResetValue()
        {
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            cboGioiTinh.SelectedIndex = -1;
            dtmNgaySinh.Value = DateTime.Now;
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            cboLoaiDG.SelectedIndex = -1;
            txtGhiChu.Text = "";
            txtTenTK.Text = "";
            txtMK.Text = "";
        }

        private void TimDanhSach()
        {

            if (radMaDG.Checked)
            {

                DataTable dtMaDocGia = data.ReadData("select * from tblDocGia where MaDG like '%" + txtNDTimKiem.Text + "%'");
                dataGridViewDSDocGia.DataSource = dtMaDocGia;
                dataGridViewDSDocGia.AutoGenerateColumns = false;
            }
            else if (radTenDG.Checked)
            {

                DataTable dtTenDocGia = data.ReadData("select * from tblDocGia where TenDG like N'%" + txtNDTimKiem.Text + "%'");
                dataGridViewDSDocGia.DataSource = dtTenDocGia;
                dataGridViewDSDocGia.AutoGenerateColumns = false;
            }
        }

        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimDanhSach();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển nhập liệu
            string maDG = txtMaDG.Text.Trim();
            string tenDG = txtTenDG.Text.Trim();
            string gioiTinh = cboGioiTinh.Text;
            string ngaySinh = dtmNgaySinh.Text;
            string sdt = txtSoDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string loaiDG = cboLoaiDG.Text;
            string ghiChu = txtGhiChu.Text.Trim();
            string tenTaiKhoan = txtTenTK.Text.Trim();
            string matKhau = txtMK.Text.Trim();
            string sqlUpdate = $@"UPDATE tblDocGia 
                          SET TenDG = N'{tenDG}', GioiTinhDG = N'{gioiTinh}', NgaySinhDG = '{ngaySinh}', 
                              SDTDG = '{sdt}', DiaChiDG = N'{diaChi}', LoaiDG = N'{loaiDG}', 
                              GhiChu = N'{ghiChu}', TenTaiKhoanDG = '{tenTaiKhoan}', MatKhauDG = '{matKhau}' 
                          WHERE MaDG = '{maDG}'";

            MessageBox.Show("Sửa Thành Công");
            // Gọi phương thức ChangeData từ lớp ConnectData để thực thi câu truy vấn
            data.ChangeData(sqlUpdate);

            // Làm mới DataGridView để hiển thị dữ liệu đã cập nhật
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    data.ReadData("delete tblDocGia where MaDG='" + txtMaDG.Text + "' ");
                    LoadData();
                    ResetValue();
                }
                catch
                {
                    MessageBox.Show("Bạn k xóa được vì Độc Giả này đang mượn sách");
                }
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Đã lưu thành công");
        }
    }
}
