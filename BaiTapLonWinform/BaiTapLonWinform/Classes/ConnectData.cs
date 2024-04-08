using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapLonWinform.Classes
{
    internal class ConnectData
    {
        string strConnect = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=MHHDL_DoAnQLTV;Integrated Security=True";
        SqlConnection sqlConn = null;
        void OpenConnect()
        {
            sqlConn = new SqlConnection(strConnect);
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();
        }
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlData.Fill(dt);
            CloseConnect();
            sqlData.Dispose();
            return dt;
        }
        public void ChangeData(string sql)
        {
            OpenConnect();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlConn;
            sqlCom.CommandText = sql;
            sqlCom.ExecuteNonQuery();
            CloseConnect();
            sqlCom.Dispose();
        }

        void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)

            {
                sqlConn.Close();
                sqlConn.Dispose();

            }
        }

        public bool KiemTraLogin(string username, string password, string tableName)
        {
            try
            {
                OpenConnect();

                // Use a switch statement to handle different tables
                string query = "";
                switch (tableName)
                {
                    case "tblThuThu":
                        query = "SELECT COUNT(*) FROM tblThuThu WHERE TenTaiKhoanTT = @username AND MatKhauTT = @password";
                        break;
                    case "tblDocGia":
                        query = "SELECT COUNT(*) FROM tblDocGia WHERE TenTaiKhoanDG = @username AND MatKhauDG = @password";
                        break;
                    // Add more cases for additional tables if needed

                    default:
                        // Handle unknown table name
                        return false;
                }

                SqlCommand command = new SqlCommand(query, sqlConn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int result = (int)command.ExecuteScalar();
                CloseConnect();
                return result > 0;
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or throw as needed
                // Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool DoiMatKhauChoHaiBang(string tenTaiKhoan, string matKhauMoi)
        {
            try
            {
                OpenConnect();

                // Bắt đầu giao dịch
                SqlTransaction transaction = sqlConn.BeginTransaction();

                try
                {
                    // Thực hiện câu lệnh UPDATE cho bảng tblThuThu
                    string sqlUpdateThuThu = "UPDATE tblThuThu SET MatKhauTT = @newPassword WHERE TenTaiKhoanTT = @username";
                    SqlCommand commandThuThu = new SqlCommand(sqlUpdateThuThu, sqlConn, transaction);
                    commandThuThu.Parameters.AddWithValue("@newPassword", matKhauMoi);
                    commandThuThu.Parameters.AddWithValue("@username", tenTaiKhoan);
                    int rowsAffectedThuThu = commandThuThu.ExecuteNonQuery();

                    // Thực hiện câu lệnh UPDATE cho bảng tblDocGia
                    string sqlUpdateDocGia = "UPDATE tblDocGia SET MatKhauDG = @newPassword WHERE TenTaiKhoanDG = @username";
                    SqlCommand commandDocGia = new SqlCommand(sqlUpdateDocGia, sqlConn, transaction);
                    commandDocGia.Parameters.AddWithValue("@newPassword", matKhauMoi);
                    commandDocGia.Parameters.AddWithValue("@username", tenTaiKhoan);
                    int rowsAffectedDocGia = commandDocGia.ExecuteNonQuery();

                    // Kết thúc giao dịch
                    transaction.Commit();

                    CloseConnect();

                    // Trả về true nếu cả hai bảng đều đã được cập nhật thành công
                    return rowsAffectedThuThu > 0 && rowsAffectedDocGia > 0;
                }
                catch (Exception ex)
                {
                    // Rollback giao dịch nếu có lỗi
                    transaction.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi khác (không phải từ giao dịch)
                // Console.WriteLine(ex.Message);
                return false;
            }
        }





    }
}
