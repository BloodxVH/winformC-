using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Add this line
using System.Data.SqlClient;
using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BaiTapLonWinform
{
    public partial class frmBieuDo : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();


        public frmBieuDo()
        {
            InitializeComponent();
        }

        private void btnBieuDoSach_Click(object sender, EventArgs e)
        {

        }

        private void frmBieuDo_Load(object sender, System.EventArgs e)
        {


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void BieuDoChuDe()
        {
            string sqlSelect = "SELECT ChuDe, COUNT(*) AS SoLuong FROM tblSach GROUP BY ChuDe";
            DataTable dt = data.ReadData(sqlSelect);
            dgvDuLieu.DataSource = dt;
            chart1.DataSource = dt;
            chart1.Titles.Clear();


            chart1.Titles.Add("Biểu Đồ Số Lượng Sách Theo Chủ Đề");


            foreach (DataColumn column in dt.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }

            chart1.Series["Series1"].XValueMember = "ChuDe"; // X-axis
            chart1.Series["Series1"].YValueMembers = "SoLuong"; // Y-axis
            chart1.Series["Series1"].Name = "Sách";

        }

        private void btnBieuDoSach_Click_1(object sender, EventArgs e)
        {
            BieuDoChuDe();
        }
        void BieuDoTinhTrang()
        {
            string sqlSelect = "SELECT TinhTrang, COUNT(*) AS SoLuong FROM tblSach GROUP BY TinhTrang;";
            DataTable dt = data.ReadData(sqlSelect);
            dgvDuLieu.DataSource = dt;
            chart1.DataSource = dt;
            chart1.Series["Series1"].Name = null;
            chart1.Titles.Clear();


            chart1.Titles.Add("Biểu Đồ Số Lượng Sách Theo Tình Trạng");
            foreach (DataColumn column in dt.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }
            chart1.Series["Series1"].XValueMember = "TinhTrang"; // X-axis
            chart1.Series["Series1"].YValueMembers = "SoLuong"; // Y-axis
            chart1.Series["Series1"].Name = "Sách";

        }

        private void btnBieuDoSachMuon_Click(object sender, EventArgs e)
        {
            BieuDoTinhTrang();
        }
        void ThongKeSoLuongMuon()
        {
            string sqlSelect = "SELECT s.ChuDe, COUNT(h.MaPhieu) AS SoLuongMuon FROM tblSach s LEFT JOIN tblHSPhieuMuon h ON s.MaSach = h.MaSach WHERE h.MaPhieu IS NOT NULL GROUP BY s.ChuDe;";
            DataTable dt = data.ReadData(sqlSelect);
            dgvDuLieu.DataSource = dt;
            chart1.DataSource = dt;
            chart1.Titles.Clear();

            chart1.Titles.Add("Biểu Đồ Số Lượng Sách Theo Chủ Đề");

            foreach (DataColumn column in dt.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }
            chart1.Series["Series1"].XValueMember = "ChuDe"; // X-axis
            chart1.Series["Series1"].YValueMembers = "SoLuongMuon"; // Y-axis

            // Đặt tên mới cho Series1

        }

        private void btnSLMuon_Click(object sender, EventArgs e)
        {
            ThongKeSoLuongMuon();
        }
    }
}