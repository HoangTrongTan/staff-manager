using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien.DAO
{
    public class taikhoanDAO
    {
        SqlConnection conn = new SqlConnection(Database.conn);

        public taikhoan checkLogin(taikhoan tk)
        {
            taikhoan tk_temp = null;
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Account WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau", conn);
            cmd.Parameters.AddWithValue("@TaiKhoan",tk.TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau",tk.Matkhau);
            SqlDataReader read = cmd.ExecuteReader();
            
            if (read.Read())
            {
                tk_temp = new taikhoan(
                    read["TaiKhoan"].ToString(),
                    read["MatKhau"].ToString(),
                    read["HoTen"].ToString()
                    );
            }
            conn.Close();
            return tk_temp;
        }
    }
}
