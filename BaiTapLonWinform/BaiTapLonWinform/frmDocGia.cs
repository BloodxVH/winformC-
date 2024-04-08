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
    public partial class frmDocGia : Form
    {
        Classes.ConnectData Data = new Classes.ConnectData();
        DataTable dt = new DataTable();
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            loadDataSach();
            TimKiemSach();

        }

        private void TimKiemSach()
        {
            if (radMaSach.Checked)
            {
                DataTable dtMaSach = Data.ReadData("SELECT * FROM tblSach WHERE  MaSach Like N'%" + txtNDTimKiem.Text + "%'");
                dgvThongTInSach.DataSource = dtMaSach;
                dgvThongTInSach.AutoGenerateColumns = false;
            }
            else if (radTenSach.Checked)
            {
                DataTable dtTenSach = Data.ReadData("SELECT * FROM tblSach WHERE TenSach Like N'%" + txtNDTimKiem.Text + "%'");
                dgvThongTInSach.DataSource = dtTenSach;
                dgvThongTInSach.AutoGenerateColumns = false;
            }
            else if (radTenTG.Checked)
            {
                DataTable dtTacGia = Data.ReadData("SELECT * FROM tblSach WHERE TacGia Like N'%" + txtNDTimKiem.Text + "%'");
                dgvThongTInSach.DataSource = dtTacGia;
                dgvThongTInSach.AutoGenerateColumns = false;
            }
            else if (radTenCD.Checked)
            {
                DataTable dtChuDe = Data.ReadData("SELECT * FROM tblSach WHERE ChuDe Like N'%" + txtNDTimKiem.Text + "%'");
                dgvThongTInSach.DataSource = dtChuDe;
                dgvThongTInSach.AutoGenerateColumns = false;
            }
        }
        void loadDataSach()
        {

            DataTable dt = Data.ReadData("SELECT * FROM tblSach");
            dgvThongTInSach.DataSource = dt;

        }

        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemSach();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
