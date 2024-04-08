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
    public partial class frmQLMuonTra : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();
        Classes.CommonFuntions funtions = new Classes.CommonFuntions();
        public frmQLMuonTra()
        {
            InitializeComponent();
            DataTable dtMuonTra = data.ReadData("Select * from tblHSPhieuMuon");
            funtions.FillComboBox(comboBox3, dtMuonTra, "TinhTrang", "MaPhieu");
        }
        private void TimDanhSach1()
        {
            if (radMaDG.Checked)
            {

                DataTable dtMaDocGia = data.ReadData("select * from tblHSPhieuMuon where MaDG like '%" + txtNDTimKiem.Text + "%'");
                dataGridViewDSMuon0.DataSource = dtMaDocGia;
                dataGridViewDSMuon0.AutoGenerateColumns = false;
            }
            else if (radMaSach.Checked)
            {
                DataTable dtMaSach = data.ReadData("select * from tblHSPhieuMuon where MaSach like N'%" + txtNDTimKiem.Text + "%'");
                dataGridViewDSMuon0.DataSource = dtMaSach;
                dataGridViewDSMuon0.AutoGenerateColumns = false;
            }
        }

        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimDanhSach1();
        }

        private void dataGridViewDSMuon0_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNhap.Enabled = true;
            btnGiaHan.Enabled = true;
            btnHuy0.Enabled = true;
            txtTTMaSach.Text = dataGridViewDSMuon0.CurrentRow.Cells[0].Value.ToString();
            txtTTTenSach.Text = dataGridViewDSMuon0.CurrentRow.Cells[1].Value.ToString();
            txtTTSLCon.Text = dataGridViewDSMuon0.CurrentRow.Cells[2].Value.ToString();
            txtTTTenTG.Text = dataGridViewDSMuon0.CurrentRow.Cells[3].Value.ToString();
            txtMaPhieu0.Text = dataGridViewDSMuon0.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridViewDSMuon0.CurrentRow.Cells[5].Value.ToString();
            dtmNgayMuon0.Text = dataGridViewDSMuon0.CurrentRow.Cells[6].Value.ToString();
            dtmNgayTra0.Text = dataGridViewDSMuon0.CurrentRow.Cells[7].Value.ToString();
            txtSLMuon0.Text = dataGridViewDSMuon0.CurrentRow.Cells[8].Value.ToString();
            comboBox3.Text = dataGridViewDSMuon0.CurrentRow.Cells[9].Value.ToString();
            txtGhiChu0.Text = dataGridViewDSMuon0.CurrentRow.Cells[10].Value.ToString();
            comboBox2.Text = dataGridViewDSMuon0.CurrentRow.Cells[0].Value.ToString();
        }



        private void frmQLMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData2();
        }

        void LoadData()
        {
            DataTable dtMuonTra1 = data.ReadData("SELECT\r\n    tblSach.MaSach,\r\n    tblSach.TenSach,\r\n    tblSach.SLNhap - COALESCE(SUM(tblHSPhieuMuon.SLMuon), 0) AS SoLuongCon,\r\n    tblSach.TacGia,\r\n    tblHSPhieuMuon.MaPhieu,\r\n    tblHSPhieuMuon.MaDG,\r\n    tblHSPhieuMuon.NgayMuon,\r\n    tblHSPhieuMuon.NgayTra,\r\n    tblHSPhieuMuon.SLMuon,\r\n    tblHSPhieuMuon.TinhTrang,\r\n    tblHSPhieuMuon.GhiChu\r\nFROM\r\n    tblSach\r\nLEFT JOIN\r\n    tblHSPhieuMuon ON tblSach.MaSach = tblHSPhieuMuon.MaSach\r\nGROUP BY\r\n    tblSach.MaSach, tblSach.TenSach, tblSach.SLNhap, tblSach.TacGia, tblHSPhieuMuon.MaPhieu, tblHSPhieuMuon.MaDG, tblHSPhieuMuon.NgayMuon, tblHSPhieuMuon.NgayTra, tblHSPhieuMuon.SLMuon, tblHSPhieuMuon.TinhTrang, tblHSPhieuMuon.GhiChu");
            dataGridViewDSMuon0.DataSource = dtMuonTra1;
        }

        void LoadData2()
        {
            DataTable dtMuonTra2 = data.ReadData("SELECT\r\n    tblSach.MaSach,\r\n    tblSach.TenSach,\r\n    tblSach.SLNhap - COALESCE(SUM(tblHSPhieuMuon.SLMuon), 0) AS SoLuongCon,\r\n    tblSach.TacGia,\r\n    tblHSPhieuMuon.MaPhieu,\r\n    tblHSPhieuMuon.MaDG,\r\n    tblHSPhieuMuon.NgayMuon,\r\n    tblHSPhieuMuon.NgayTra,\r\n    tblHSPhieuMuon.SLMuon,\r\n    tblHSPhieuMuon.TinhTrang,\r\n    tblHSPhieuMuon.GhiChu\r\nFROM\r\n    tblSach\r\nLEFT JOIN\r\n    tblHSPhieuMuon ON tblSach.MaSach = tblHSPhieuMuon.MaSach\r\nGROUP BY\r\n    tblSach.MaSach, tblSach.TenSach, tblSach.SLNhap, tblSach.TacGia, tblHSPhieuMuon.MaPhieu, tblHSPhieuMuon.MaDG, tblHSPhieuMuon.NgayMuon, tblHSPhieuMuon.NgayTra, tblHSPhieuMuon.SLMuon, tblHSPhieuMuon.TinhTrang, tblHSPhieuMuon.GhiChu");
            dataGridViewDSMuon1.DataSource = dtMuonTra2;
        }

        private void btnThoat0_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu0.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || txtSLMuon0.Text == "" || comboBox3.Text == "" || txtGhiChu0.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                return;

            }

            if (!int.TryParse(txtSLMuon0.Text, out int soLuongMuon))
            {
                MessageBox.Show("Số lượng nhập phải là một số nguyên!");
                return;
            }


            try
            {
                // Lấy thông tin từ các controls trên form
                string maSach = txtTTMaSach.Text;
                string tenSach = txtTTTenSach.Text;
                string tacGia = txtTTTenTG.Text;
                string maPhieu = txtMaPhieu0.Text;
                string maDG = comboBox1.Text.ToString(); // Giả sử comboBox1 là ComboBox chứa danh sách mã độc giả
                string maSachMuon = comboBox2.Text.ToString(); // Giả sử comboBox2 là ComboBox chứa danh sách mã sách
                string ngayMuon = dtmNgayMuon0.Text; // Lấy ngày mượn dưới dạng văn bản
                string ngayTra = dtmNgayTra0.Text;
                string tinhTrang = comboBox3.Text;
                string ghiChu = txtGhiChu0.Text;



                // Thực hiện câu lệnh SQL để thêm bản ghi mới
                string sqlInsert = $@"INSERT INTO tblHSPhieuMuon 
                              (MaPhieu, MaDG, MaSach, NgayMuon, NgayTra, SLMuon, TinhTrang, GhiChu) 
                              VALUES 
                              ('{maPhieu}', '{maDG}', '{maSachMuon}', '{ngayMuon}', '{ngayTra}', {soLuongMuon}, N'{tinhTrang}', N'{ghiChu}')";

                data.ChangeData(sqlInsert);

                // Cập nhật lại DataGridView
                LoadData();

                // Thông báo thành công
                MessageBox.Show("Nhập thành công!");
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {

            // Lấy thông tin từ hàng đã chọn trong DataGridView
            string maPhieu = txtMaPhieu0.Text;
            string ngayMuon = dtmNgayMuon0.Text;
            // Cập nhật trường NgayTra trong cơ sở dữ liệu
            string sqlInsert = $@"UPDATE tblHSPhieuMuon
                              SET NgayMuon = '{ngayMuon.ToString()}'
                              WHERE MaPhieu = '{maPhieu}'";

            string ngayTra = dtmNgayTra0.Text;
            // Cập nhật trường NgayTra trong cơ sở dữ liệu
            string sqlUpdate = $@"UPDATE tblHSPhieuMuon
                              SET NgayTra = '{ngayTra.ToString()}'
                              WHERE MaPhieu = '{maPhieu}'";

            data.ChangeData(sqlUpdate);
            data.ChangeData(sqlInsert);

            // Tải lại dữ liệu để phản ánh các thay đổi trong DataGridView
            LoadData();

            // Hiển thị thông báo thành công
            MessageBox.Show("Gia hạn thành công!");

            ResetValue();

        }
        void ResetValue()
        {
            radMaDG.Checked = false;
            radMaSach.Checked = false;
            txtNDTimKiem.Text = "";
            txtTTMaSach.Text = "";
            txtTTTenSach.Text = "";
            txtTTSLCon.Text = "";
            txtTTTenTG.Text = "";
            txtMaPhieu0.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            txtSLMuon0.Text = "";
            dtmNgayMuon0.Value = DateTime.Now;
            dtmNgayTra0.Value = DateTime.Now;
            comboBox3.Text = "";
            txtGhiChu0.Text = "";
            btnNhap.Enabled = false;
            btnGiaHan.Enabled = true;
        }

        private void btnHuy0_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnChoMuon0_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TimDanhSach2()
        {
            if (radMaDG1.Checked)
            {
                DataTable dtMaDG = data.ReadData("select * from tblHSPhieuMuon where MaDG like '%" + txtNDTimKiem1.Text + "%'");
                dataGridViewDSMuon1.DataSource = dtMaDG;
                dataGridViewDSMuon1.AutoGenerateColumns = false;
            }
            else if (radMaSach1.Checked)
            {
                DataTable dtMatblSach = data.ReadData("select * from tblHSPhieuMuon where MaSach like N'%" + txtNDTimKiem1.Text + "%'");
                dataGridViewDSMuon1.DataSource = dtMatblSach;
                dataGridViewDSMuon1.AutoGenerateColumns = false;
            }
        }


        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNDTimKiem1_TextChanged(object sender, EventArgs e)
        {
            TimDanhSach2();
        }

        private void dataGridViewDSMuon1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu1.Text = dataGridViewDSMuon1.CurrentRow.Cells[4].Value.ToString();
            txtMaDG1.Text = dataGridViewDSMuon1.CurrentRow.Cells[5].Value.ToString();
            txtMaSach1.Text = dataGridViewDSMuon1.CurrentRow.Cells[0].Value.ToString();
            txtSLMuon1.Text = dataGridViewDSMuon1.CurrentRow.Cells[8].Value.ToString();
            dtmNgayMuon1.Text = dataGridViewDSMuon1.CurrentRow.Cells[6].Value.ToString();
            dtmNgayTra1.Text = dataGridViewDSMuon1.CurrentRow.Cells[7].Value.ToString();
            txtTinhTrang1.Text = dataGridViewDSMuon1.CurrentRow.Cells[9].Value.ToString();
            txtGhiChu1.Text = dataGridViewDSMuon1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnTraSach1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban co muon tra sach co ma phieu " + txtMaPhieu1.Text + " khong?", "Co hay khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.ReadData("delete from tblHSPhieuMuon where MaPhieu='" + txtMaPhieu1.Text + "'");
                MessageBox.Show("Đã trả sach co ma phieu" + txtMaPhieu1.Text + "", "Thông báo");
                LoadData2();
            }

        }
    }
}
