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
    public class lichsuDao
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        private void open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public List<string> getAllTime()
        {
            open();
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT(thoigian) FROM NV_temp",conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(rd["thoigian"].ToString());
            }
            conn.Close();
            return list;
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT NV_temp.manv as [Mã nv],NV_temp.hoten as [name],NV_temp.sodaucat as [số đầu cắt],banggia.ten as DV,NV_temp.thoigian FROM NV_temp INNER JOIN banggia ON NV_temp.loaiviec = banggia.ma", conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
