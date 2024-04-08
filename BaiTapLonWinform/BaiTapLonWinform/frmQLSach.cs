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
    public partial class frmQLSach : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();


        public frmQLSach()
        {
            InitializeComponent();
        }






        private void dataGridViewDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtMaSach.Text = dataGridViewDSSach.CurrentRow.Cells[0].Value.ToString();
                txtTenSach.Text = dataGridViewDSSach.CurrentRow.Cells[1].Value.ToString();
                txtTacGia.Text = dataGridViewDSSach.CurrentRow.Cells[3].Value.ToString();
                txtNXB.Text = dataGridViewDSSach.CurrentRow.Cells[4].Value.ToString();
                txtNamXB.Text = dataGridViewDSSach.CurrentRow.Cells[5].Value.ToString();
                txtChuDe.Text = dataGridViewDSSach.CurrentRow.Cells[2].Value.ToString();
                txtSLNhap.Text = dataGridViewDSSach.CurrentRow.Cells[6].Value.ToString();
                txtDonGia.Text = dataGridViewDSSach.CurrentRow.Cells[7].Value.ToString();
                txtGhiChu.Text = dataGridViewDSSach.CurrentRow.Cells[9].Value.ToString();
                cboTinhTrang.Text = dataGridViewDSSach.CurrentRow.Cells[8].Value.ToString();



                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;


            }
        }

        void LoadData()
        {
            DataTable dtSach = data.ReadData("Select * from tblSach");
            dataGridViewDSSach.DataSource = dtSach;
        }
        void Reset()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "";
            txtNamXB.Text = "";
            txtChuDe.Text = "";
            txtSLNhap.Text = "";
            txtDonGia.Text = "";
            cboTinhTrang.Text = "";
            txtGhiChu.Text = "";
            txtMaSach.Text = "";           

        }
        private void frmQLSach_Load(object sender, EventArgs e)
        {
            LoadData();
            cboTinhTrang.Items.Add("Mới");
            cboTinhTrang.Items.Add("Cũ");
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void timKiemSach()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            if (radMaSach.Checked)
            {
                DataTable dtMaSach = data.ReadData("select * from tblSach where MaSach like '%" + txtNDTimKiem.Text + "%'");
                dataGridViewDSSach.DataSource = dtMaSach;
                dataGridViewDSSach.AutoGenerateColumns = false;
            }
            else if (radTenSach.Checked)
            {
                DataTable dtTenSach = data.ReadData("select * from tblSach where TenSach like N'%" + txtNDTimKiem.Text + "%'");

                dataGridViewDSSach.DataSource = dtTenSach;
                dataGridViewDSSach.AutoGenerateColumns = false;
            }
            else if (radTenTG.Checked)
            {
                DataTable dtTenTG = data.ReadData("select * from tblSach where TacGia like N'%" + txtNDTimKiem.Text + "%'");
                dataGridViewDSSach.DataSource = dtTenTG;
                dataGridViewDSSach.AutoGenerateColumns = false;
            }
            else if (radTenCD.Checked)
            {
                DataTable dtTenCD = data.ReadData("select * from tblSach where ChuDe like N'%" + txtNDTimKiem.Text + "%'");
                dataGridViewDSSach.DataSource = dtTenCD;
                dataGridViewDSSach.AutoGenerateColumns = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("ban co muon xoa khong?", "Co hay khong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                try
                {
                    data.ReadData("delete tblSach where MaSach='" + txtMaSach.Text + "' ");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại.\nSách này đang được mượn.", "Thông Báo");
                }

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            int ktSLNhap, ktNamXB, ktDonGia;
            bool isNumberSLNhap = int.TryParse(txtSLNhap.Text, out ktSLNhap);
            bool isNumberDonGia = int.TryParse(txtDonGia.Text, out ktDonGia);
            bool isNumberNamXB = int.TryParse(txtNamXB.Text, out ktNamXB);
            DataTable dtCheckHang = data.ReadData("Select * from tblSach where MaSach='" + txtMaSach.Text + "' ");
            if (txtMaSach.Text == "")
            {
                MessageBox.Show(txtTenSach, "Vui lòng nhập mã sách");
                txtMaSach.Focus();
            }
            else if (txtTenSach.Text == "")
            {
                MessageBox.Show(txtTenSach, "Vui lòng nhập Tên Sách");
            }

            else if (txtChuDe.Text == "")
            {
                MessageBox.Show(txtChuDe, "Vui lòng nhập Chủ Đề");
            }

            else if (txtTacGia.Text == "")
            {
                MessageBox.Show(txtTacGia, "Vui lòng nhập Tác Giả");
            }

            else if (txtNXB.Text == "")
            {
                MessageBox.Show(txtNXB, "Vui lòng nhập NXB");
            }

            else if (txtNamXB.Text == "")
            {
                MessageBox.Show(txtNamXB, "Vui lòng nhập Năm XB");
            }

            else if (txtSLNhap.Text == "")
            {
                MessageBox.Show(txtSLNhap, "Vui lòng nhập SL");
            }


            else if (txtDonGia.Text == "")
            {
                MessageBox.Show(txtDonGia, "Vui lòng nhập Đơn Giá");
            }

            else if (cboTinhTrang.Text == "")
            {
                MessageBox.Show(cboTinhTrang, "Vui lòng nhập Tình Trạng");
            }
            else if (isNumberSLNhap == false || isNumberDonGia == false || isNumberNamXB == false)
            {
                MessageBox.Show("Vui lòng nhập số trong các ô:\nSL Nhập.\nNăm XB.\nĐơn Giá.", "Thông Báo");
            }
            else if (txtTenSach.Text.Length > 0 && txtTacGia.Text.Length > 0 && txtNXB.Text.Length > 0 && txtChuDe.Text.Length > 0 && isNumberSLNhap == true && isNumberDonGia == true && cboTinhTrang.Text.Length > 0 && isNumberNamXB == true)
            {

                string sqlInsert = "update tblSach set TenSach=N'" + txtTenSach.Text + "',ChuDe=N'" + txtChuDe.Text + "',TacGia=N'" + txtTacGia.Text + "',NXB=N'" + txtNXB.Text + "',NamXB='" + txtNamXB.Text + "',SLNhap='" + txtSLNhap.Text + "',DonGia='" + txtDonGia.Text + "',TinhTrang=N'" + cboTinhTrang.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaSach='" + txtMaSach.Text + "'";
                data.ReadData(sqlInsert);
                LoadData();
                MessageBox.Show("Sửa thành công.", "Thông Báo");
                Reset();
                btnThem.Enabled = true;
                btnSua.Enabled = false;

            }
        }


        private void txtNDTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiemSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
                int ktSLNhap, ktNamXB, ktDonGia;
                bool isNumberSLNhap = int.TryParse(txtSLNhap.Text, out ktSLNhap);
                bool isNumberDonGia = int.TryParse(txtDonGia.Text, out ktDonGia);
                bool isNumberNamXB = int.TryParse(txtNamXB.Text, out ktNamXB);
                DataTable dtCheckHang = data.ReadData("Select * from tblSach where MaSach='" + txtMaSach.Text + "' ");
                if (txtMaSach.Text == "")
                {
                    MessageBox.Show(txtTenSach, "Vui lòng nhập mã sách");                   
                    txtMaSach.Focus();
                }
                else if (dtCheckHang.Rows.Count > 0)
                {
                    MessageBox.Show("Mã sách đã có vui lòng nhập mã khác ");
                    txtMaSach.Clear();
                    txtMaSach.Focus();
                }
                else if (txtTenSach.Text == "")
                {
                    MessageBox.Show(txtTenSach, "Vui lòng nhập Tên Sách");
                }
                
                else if (txtChuDe.Text == "")
                {
                    MessageBox.Show(txtChuDe, "Vui lòng nhập Chủ Đề");
                }
                
                else if (txtTacGia.Text == "")
                {
                    MessageBox.Show(txtTacGia, "Vui lòng nhập Tác Giả");
                }
                
                else if (txtNXB.Text == "")
                {
                    MessageBox.Show(txtNXB, "Vui lòng nhập NXB");
                }
                
                else if (txtNamXB.Text == "")
                {
                    MessageBox.Show(txtNamXB, "Vui lòng nhập Năm XB");
                }
                
                else if (txtSLNhap.Text == "")
                {
                    MessageBox.Show(txtSLNhap, "Vui lòng nhập SL");
                }
                

                else if (txtDonGia.Text == "")
                {
                    MessageBox.Show(txtDonGia, "Vui lòng nhập Đơn Giá");
                }
                
                else if (cboTinhTrang.Text == "")
                {
                    MessageBox.Show(cboTinhTrang, "Vui lòng nhập Tình Trạng");
                }              
                else if (isNumberSLNhap == false || isNumberDonGia == false || isNumberNamXB == false)
                {
                    MessageBox.Show("Vui lòng nhập số trong các ô:\nSL Nhập.\nNăm XB.\nĐơn Giá.", "Thông Báo");
                }
                else if (txtTenSach.Text.Length > 0 && txtTacGia.Text.Length > 0 && txtNXB.Text.Length > 0 && txtChuDe.Text.Length > 0 && isNumberSLNhap == true && isNumberDonGia == true && cboTinhTrang.Text.Length > 0 && isNumberNamXB == true)
                {

                    string sqlInsert = "insert into tblSach values ('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + txtChuDe.Text + "',N'" + txtTacGia.Text + "',N'" + txtNXB.Text + "','" + txtNamXB.Text + "','" + txtSLNhap.Text + "','" + txtDonGia.Text + "',N'" + cboTinhTrang.Text + "',N'" + txtGhiChu.Text + "')";

                    data.ReadData(sqlInsert);
                    LoadData();
                    MessageBox.Show("them moi thanh cong");
                    Reset();


                }
                
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            Reset();
        }
    }
}