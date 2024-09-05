using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien.CONTROLER
{
    public class doanhthuControll
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        public string TongDoanhThu()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string str = "";
            SqlCommand cmd = new SqlCommand("SELECT SUM(tongluong) FROM NhanVien", conn);
            object result = cmd.ExecuteScalar();
            if(result != null)
            {
                str = result.ToString();
            }
            conn.Close();
            return str;
        }
        public int updateThuongthem(string thuongthem,string manv)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int i = 0;
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET thuongthem = @thuongthem,tongluong= tongluong+@thuongthem WHERE manv = @manv", conn);
            cmd.Parameters.AddWithValue("@thuongthem", thuongthem);
            cmd.Parameters.AddWithValue("@manv", manv);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public int capnhatKichHoat(bool j)
        {
            Console.WriteLine("\n\n\n"+j.ToString());
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int i = 0;
            SqlCommand cmd = new SqlCommand("UPDATE Calendar SET kichhoat=@kichhoat", conn);
            cmd.Parameters.AddWithValue("@kichhoat", j?"1":"0");
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

     
    }
}
