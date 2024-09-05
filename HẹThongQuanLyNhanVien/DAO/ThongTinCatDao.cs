using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien.DAO
{
    public class ThongTinCatDao
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        private void open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public List<trinhdoModel> getListTrinhDo()
        {
            List<trinhdoModel> list = new List<trinhdoModel>();
            
            open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM trinhdo", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(
                    new trinhdoModel(
                        Convert.ToInt32(rd["id"]),
                        rd["ten"].ToString(),
                        rd["gia"].ToString()
                        ));
            }
            conn.Close();
            return list;
        }
        
    }
}
