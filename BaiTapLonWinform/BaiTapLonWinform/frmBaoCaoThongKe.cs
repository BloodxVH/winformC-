using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapLonWinform.Classes;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace BaiTapLonWinform
{
    public partial class frmBaoCaoThongKe : Form
    {
        Classes.ConnectData Data = new Classes.ConnectData();
        DataTable dt = new DataTable();

        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }
        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            //SL Đầu Sách
            DataTable DauSach = Data.ReadData("SELECT COUNT(*) AS SoLuongDauSach FROM tblSach");
            txtSLDauSach.Text = DauSach.Rows[0]["SoLuongDauSach"].ToString();
            //Sl  Cuốn Sách
            DataTable CuonSach = Data.ReadData("SELECT SUM(tblSach.SLNhap) AS SoLuongCuonSach FROM tblSach");
            txtSLCuon.Text = CuonSach.Rows[0]["SoLuongCuonSach"].ToString();
            //SL Mượn
            DataTable MuonSach = Data.ReadData("SELECT SUM(tblHSPhieuMuon.SLMuon) AS SoLuongMuon FROM tblHSPhieuMuon");
            txtSLMuon.Text = MuonSach.Rows[0]["SoLuongMuon"].ToString();
            //SL Còn
            DataTable SachCon = Data.ReadData("SELECT SUM(tblSach.SLNhap - tblHSPhieuMuon.SLMuon) AS SoLuongSachCon FROM tblSach LEFT JOIN tblHSPhieuMuon ON tblSach.MaSach = tblHSPhieuMuon.MaSach");
            txtSLCon.Text = SachCon.Rows[0]["SoLuongSachCon"].ToString();
            //SL Sách Quá Hạn
            DataTable SachQuaHan = Data.ReadData("SELECT count(SLMuon) as TongSLQuaHan from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()");
            txtSLQuaHan.Text = SachQuaHan.Rows[0]["TongSLQuaHan"].ToString();
            //Tổng Giá Trị
            DataTable TongTienSach = Data.ReadData("SELECT SUM(tblSach.DonGia * tblSach.SLNhap) AS TongTienSach FROM tblSach");
            txtTongGiaTri.Text = TongTienSach.Rows[0]["TongTienSach"].ToString();
            //độc  giả
            //sl ĐG  trong  TV
            DataTable TongDG = Data.ReadData("SELECT COUNT(*) AS TongDocGia FROM tblDocGia");
            txtSLDocGia.Text = TongDG.Rows[0]["TongDocGia"].ToString();
            //Sl  ĐG Mượn Sách
            DataTable ĐGMuonSach = Data.ReadData("SELECT COUNT(DISTINCT CASE WHEN tblHSPhieuMuon.TinhTrang = N'Mới' THEN tblDocGia.MaDG END) AS ĐGDangMuonSach FROM tblDocGia LEFT JOIN tblHSPhieuMuon ON tblDocGia.MaDG = tblHSPhieuMuon.MaDG");
            txtSLDGDaMuon.Text = ĐGMuonSach.Rows[0]["ĐGDangMuonSach"].ToString();
            //sl đg quá  hạn
            DataTable DGQuaHan = Data.ReadData("SELECT count(distinct(MaDG)) as TongSLQuaHan from tblHSPhieuMuon where CONVERT (datetime, NgayTra, 103) < getdate()");
            txtSLDGQuaHan.Text = DGQuaHan.Rows[0]["TongSLQuaHan"].ToString();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Quay Lại Trang Chủ Không?", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                frmTrangChu frmTrangChu = new frmTrangChu();
                this.Hide();
                frmTrangChu.ShowDialog();
                this.Show();

            }
        }
        private void btnDSSachQH_Click(object sender, EventArgs e)
        {
            DataTable dtSachQH = Data.ReadData("SELECT tblHSPhieuMuon.MaPhieu as 'Mã Phiếu',tblHSPhieuMuon.MaSach as 'Mã Sách',tblHSPhieuMuon.MaDG as 'Mã DG',tblSach.TenSach as 'Tên Sách',tblHSPhieuMuon.NgayMuon as 'Ngày Mượn',tblHSPhieuMuon.NgayTra as 'Ngày Trả',tblHSPhieuMuon.SLMuon as 'SL Mượn',tblHSPhieuMuon.GhiChu as 'Ghi Chú' FROM tblHSPhieuMuon JOIN tblSach ON tblHSPhieuMuon.MaSach = tblSach.MaSach WHERE CONVERT(datetime, tblHSPhieuMuon.NgayTra, 103) < GETDATE()");
            dgvBaoCaoThongKe.DataSource = dtSachQH;
        }
        private void btnInBCTKSachQuaHan_Click(object sender, EventArgs e)
        {
            DataTable dtSachQH = Data.ReadData("SELECT tblHSPhieuMuon.MaPhieu as 'Mã Phiếu',tblHSPhieuMuon.MaSach as 'Mã Sách',tblHSPhieuMuon.MaDG as 'Mã DG',tblSach.TenSach as 'Tên Sách',tblHSPhieuMuon.NgayMuon as 'Ngày Mượn',tblHSPhieuMuon.NgayTra as 'Ngày Trả',tblHSPhieuMuon.SLMuon as 'SL Mượn',tblHSPhieuMuon.GhiChu as 'Ghi Chú' FROM tblHSPhieuMuon JOIN tblSach ON tblHSPhieuMuon.MaSach = tblSach.MaSach WHERE CONVERT(datetime, tblHSPhieuMuon.NgayTra, 103) < GETDATE()");
            dgvBaoCaoThongKe.DataSource = dtSachQH;
            Excel.Application exApp = new Excel.Application(); // app excel
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);//  thể hiện  file excel
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];// trang sheet(có 1 trang )
            // in tiêu  đề
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];//  đua con  trỏ vào ô 1,1\
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "Thư Viện Dương-Hào-Hiếu";

            Excel.Range diachi = (Excel.Range)exSheet.Cells[2, 1];
            diachi.Font.Size = 13;
            diachi.Font.Color = Color.Blue;
            diachi.Value = "Số 3 Cầu Giấy-Đống Đa-Hà Nội";

            //In Hoá Đơn Bán
            exSheet.Range["D4"].Font.Size = 18;
            exSheet.Range["D4"].Font.Bold = true;
            exSheet.Range["D4"].Font.Color = Color.Black;
            exSheet.Range["D4"].Value = "Danh Sách Sách  Quá Hạn";
            //định dạng dòng
            exSheet.Range["A6:I6"].Font.Size = 12;
            exSheet.Range["A6:I6"].Font.Bold = true;
            exSheet.Range["A6"].ColumnWidth = 4;
            exSheet.Range["D6"].ColumnWidth = 10;
            exSheet.Range["E6"].ColumnWidth = 25;
            exSheet.Range["F6"].ColumnWidth = 12;
            exSheet.Range["G6"].ColumnWidth = 12;
            exSheet.Range["I6"].ColumnWidth = 15;
            //In Dòng Tieu Đề
            exSheet.Range["A6"].Value = "STT";
            exSheet.Range["B6"].Value = "Mã Phiếu";
            exSheet.Range["C6"].Value = "Mã Sách";
            exSheet.Range["D6"].Value = "Mã Độc Giả";
            exSheet.Range["E6"].Value = "Tên Sách";
            exSheet.Range["F6"].Value = "Ngày Mượn";
            exSheet.Range["G6"].Value = "Ngảy Trả";
            exSheet.Range["H6"].Value = "SL Mượn";
            exSheet.Range["I6"].Value = "Ghi Chú";

            //in ds chi tiết
            int dong = 7;
            for (int i = 1; i < dgvBaoCaoThongKe.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[5].Value.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[6].Value.ToString();
                exSheet.Range["I" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[7].Value.ToString();
                //căn lề trái excel
                exSheet.Range["A" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["B" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["C" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["D" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["E" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["F" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["G" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["H" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["I" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            }
            dong = dong + dgvBaoCaoThongKe.Rows.Count;
            exSheet.Name = "DS Sách Quá Hạn";
            exSheet.Range["I" + (dong + 1).ToString()].Value = "Nhân Viên:Dương-Hào-Hiếu";

            if (dgvBaoCaoThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không thể in vì không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Your existing code to activate, save, and quit Excel
                exBook.Activate();

                SaveFileDialog saveExcelSachQH = new SaveFileDialog();
                saveExcelSachQH.Filter = "Excel Workbook|*.xlsx|All Files|*.*";
                saveExcelSachQH.FilterIndex = 2;

                if (saveExcelSachQH.ShowDialog() == DialogResult.OK)
                {
                    exBook.SaveAs(saveExcelSachQH.FileName.ToLower());
                }
                exApp.Quit();
            }
        }

        private void btnDSDocGiaQH_Click(object sender, EventArgs e)
        {
            DataTable dtDGQH = Data.ReadData(" SELECT tblHSPhieuMuon.MaPhieu as 'Mã Phiếu',tblHSPhieuMuon.MaDG as 'Mã DG',tblDocGia.TenDG as 'Tên ĐG',tblDocGia.GioiTinhDG as ' Giới Tính',tblDocGia.DiaChiDG as 'Địa Chỉ',tblDocGia.SDTDG as 'SĐT',tblHSPhieuMuon.NgayMuon as 'Ngày Mượn',tblHSPhieuMuon.NgayTra as 'Ngày Trả',tblHSPhieuMuon.SLMuon as 'SL Mượn',tblHSPhieuMuon.GhiChu as 'Ghi Chú' FROM tblHSPhieuMuon JOIN tblDocGia ON tblHSPhieuMuon.MaDG = tblDocGia.MaDG WHERE CONVERT(datetime, tblHSPhieuMuon.NgayTra, 103) < GETDATE()");
            dgvBaoCaoThongKe.DataSource = dtDGQH;
        }
        private void btnInBCTKDocGIaQuaHan_Click(object sender, EventArgs e)
        {

        }

        private void btnTKSachTheoChuDe_Click(object sender, EventArgs e)
        {
            DataTable dtKiemKe = Data.ReadData("SELECT ChuDe 'Chủ Đề',TenSach 'Tên Sách',TacGia 'Tác Giả',NXB 'Nhà Xuất Bản',NamXB 'Năm Xuất Bản',COUNT(*) 'Số Lượng Sách',SUM(SLNhap) 'Tổng Số Lượng Cuốn' FROM tblSach GROUP BY ChuDe, TenSach, TacGia, NXB, NamXB");
            dgvBaoCaoThongKe.DataSource = dtKiemKe;
            Excel.Application exApp = new Excel.Application(); // app excel
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);//  thể hiện  file excel
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];// trang sheet(có 1 trang )
            // in tiêu  đề
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];//  đua con  trỏ vào ô 1,1\
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "Thư Viện Dương-Hào-Hiếu";

            Excel.Range diachi = (Excel.Range)exSheet.Cells[2, 1];
            diachi.Font.Size = 13;
            diachi.Font.Color = Color.Blue;
            diachi.Value = "Số 3 Cầu Giấy-Đống Đa-Hà Nội";

            //In Hoá Đơn Bán
            exSheet.Range["D4"].Font.Size = 18;
            exSheet.Range["D4"].Font.Bold = true;
            exSheet.Range["D4"].Font.Color = Color.Black;
            exSheet.Range["D4"].Value = "Kiểm Kê Sách Thư Viện";
            //định dạng dòng
            exSheet.Range["A6:H6"].Font.Size = 12;
            exSheet.Range["A6:H6"].Font.Bold = true;
            exSheet.Range["A6"].ColumnWidth = 4;
            exSheet.Range["B6"].ColumnWidth = 13;
            exSheet.Range["C6"].ColumnWidth = 25;
            exSheet.Range["D6"].ColumnWidth = 20;
            exSheet.Range["E6"].ColumnWidth = 15;
            exSheet.Range["F6"].ColumnWidth = 8;
            exSheet.Range["G6"].ColumnWidth = 8;
            exSheet.Range["H6"].ColumnWidth = 10;

            //In Dòng Tieu Đề
            exSheet.Range["A6"].Value = "STT";
            exSheet.Range["B6"].Value = "Chủ Đề";
            exSheet.Range["C6"].Value = "Tên Sách";
            exSheet.Range["D6"].Value = "Tác Giả";
            exSheet.Range["E6"].Value = "Nhà Xuất Bản";
            exSheet.Range["F6"].Value = "Năm XB";
            exSheet.Range["G6"].Value = "SL Sách";
            exSheet.Range["H6"].Value = "Tình Trạng";

            //in ds chi tiết
            int dong = 7;
            for (int i = 1; i < dgvBaoCaoThongKe.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[5].Value.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[6].Value.ToString();

                // căn chỉnh theo chiều ngang của từng ô sang trái
                exSheet.Range["A" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["B" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["C" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["D" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["E" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["F" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["G" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["H" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;


            }
            dong = dong + dgvBaoCaoThongKe.Rows.Count;
            exSheet.Name = "Kiểm Kê Sách Thư Viện";
            exSheet.Range["G" + (dong + 1).ToString()].Value = "Nhân Viên:Dương-Hào-Hiếu";

            if (dgvBaoCaoThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không thể in vì không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Your existing code to activate, save, and quit Excel
                exBook.Activate();

                SaveFileDialog saveExcelSachQH = new SaveFileDialog();
                saveExcelSachQH.Filter = "Excel Workbook|*.xlsx|All Files|*.*";
                saveExcelSachQH.FilterIndex = 2;

                if (saveExcelSachQH.ShowDialog() == DialogResult.OK)
                {
                    exBook.SaveAs(saveExcelSachQH.FileName.ToLower());
                }
                exApp.Quit();
            }
        }

        private void btnSachDangMuon_Click(object sender, EventArgs e)
        {
            DataTable dtSachDangMuon = Data.ReadData(" SELECT tblSach.MaSach as 'Mã Sách',tblSach.TenSach as 'Tên Sách',tblSach.TacGia as 'Tác Giả',tblHSPhieuMuon.MaPhieu as 'Mã Phiếu Mượn',tblDocGia.TenDG as 'Tên Độc Giả',tblHSPhieuMuon.NgayMuon as 'Ngày Mượn',tblHSPhieuMuon.NgayTra as 'Ngày Trả Dự Kiến',tblHSPhieuMuon.SLMuon  as  'SL Mượn',tblHSPhieuMuon.TinhTrang as 'Tình Trạng' FROM tblHSPhieuMuon JOIN tblSach ON tblHSPhieuMuon.MaSach = tblSach.MaSach JOIN tblDocGia ON tblHSPhieuMuon.MaDG = tblDocGia.MaDG WHERE tblHSPhieuMuon.TinhTrang <> N' ';");
            dgvBaoCaoThongKe.DataSource = dtSachDangMuon;
            Excel.Application exApp = new Excel.Application(); // app excel
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);//  thể hiện  file excel
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];// trang sheet(có 1 trang )
            // in tiêu  đề
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];//  đua con  trỏ vào ô 1,1\
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "Thư Viện Dương-Hào-Hiếu";

            Excel.Range diachi = (Excel.Range)exSheet.Cells[2, 1];
            diachi.Font.Size = 13;
            diachi.Font.Color = Color.Blue;
            diachi.Value = "Số 3 Cầu Giấy-Đống Đa-Hà Nội";

            //In Hoá Đơn Bán
            exSheet.Range["D4"].Font.Size = 18;
            exSheet.Range["D4"].Font.Bold = true;
            exSheet.Range["D4"].Font.Color = Color.Black;
            exSheet.Range["D4"].Value = "Danh Sách Sách Đang Mượn";
            //định dạng dòng
            exSheet.Range["A6:J6"].Font.Size = 12;
            exSheet.Range["A6:J6"].Font.Bold = true;
            exSheet.Range["A6"].ColumnWidth = 4;
            exSheet.Range["B6"].ColumnWidth = 10;
            exSheet.Range["C6"].ColumnWidth = 25;
            exSheet.Range["D6"].ColumnWidth = 20;
            exSheet.Range["E6"].ColumnWidth = 10;
            exSheet.Range["F6"].ColumnWidth = 20;
            exSheet.Range["G6"].ColumnWidth = 13;
            exSheet.Range["H6"].ColumnWidth = 18;
            exSheet.Range["I6"].ColumnWidth = 10;
            exSheet.Range["j6"].ColumnWidth = 10;

            //In Dòng Tieu Đề
            exSheet.Range["A6"].Value = "STT";
            exSheet.Range["B6"].Value = "Mã Sách";
            exSheet.Range["C6"].Value = "Tên Sách";
            exSheet.Range["D6"].Value = "Tác Giả";
            exSheet.Range["E6"].Value = "Mã Mượn";
            exSheet.Range["F6"].Value = "Tên Độc Giả";
            exSheet.Range["G6"].Value = "Ngày Mượn";
            exSheet.Range["H6"].Value = "Ngày Trả Dự Kiến";
            exSheet.Range["I6"].Value = "Sl Mượn";
            exSheet.Range["J6"].Value = "Tình Trạng";
            //in ds chi tiết
            int dong = 7;
            for (int i = 1; i < dgvBaoCaoThongKe.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[5].Value.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[6].Value.ToString();
                exSheet.Range["I" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[7].Value.ToString();
                exSheet.Range["J" + (dong + i).ToString()].Value = dgvBaoCaoThongKe.Rows[i].Cells[8].Value.ToString();

                // căn chỉnh theo chiều ngang của từng ô sang trái
                exSheet.Range["A" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["B" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["C" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["D" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["E" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["F" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["G" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["H" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["I" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["J" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            }
            dong = dong + dgvBaoCaoThongKe.Rows.Count;
            exSheet.Name = "Kiểm Kê Sách Đang Mượn Thư Viện";
            exSheet.Range["G" + (dong + 1).ToString()].Value = "Nhân Viên:Dương-Hào-Hiếu";

            if (dgvBaoCaoThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không thể in vì không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Your existing code to activate, save, and quit Excel
                exBook.Activate();

                SaveFileDialog saveExcelSachQH = new SaveFileDialog();
                saveExcelSachQH.Filter = "Excel Workbook|*.xlsx|All Files|*.*";
                saveExcelSachQH.FilterIndex = 2;

                if (saveExcelSachQH.ShowDialog() == DialogResult.OK)
                {
                    exBook.SaveAs(saveExcelSachQH.FileName.ToLower());
                }
                exApp.Quit();
            }
        }
    }
}
