using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraCharts.Native;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien.DAO
{
    public class doanhthuDao
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        public DataTable getAllDoanhThu()
        {
            DataTable dt = new DataTable();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getChartAll()
        {
            DataTable dt = new DataTable();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT hoten, tongluong FROM NhanVien", conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
