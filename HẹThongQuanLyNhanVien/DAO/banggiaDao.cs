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
    public class banggiaDao
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        private void open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public DataTable getAll()
        {
            open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM banggia", conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public List<banggia> getList()
        {
            open();
            List<banggia> list = new List<banggia>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM banggia", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(
                    new banggia(
                        Convert.ToInt32(rd["ma"]),
                        rd["ten"].ToString(),
                        rd["gia"].ToString()
                        ));
            }
            conn.Close();
            return list;
        }

        public List<SanPham> getListSP()
        {
            open();
            List<SanPham> list = new List<SanPham>();
            SqlCommand cmd = new SqlCommand("ALL_SP", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(
                    new SanPham(
                        Convert.ToInt32(rd["id"]),
                        rd["ten"].ToString(),
                        rd["gia"].ToString(),
                        Convert.ToInt32(rd["soluong"].ToString() )
                        ));
            }
            conn.Close();
            return list;
        }
        public DataTable getAllSP()
        {
            open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("ALL_SP", conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable ALL_LS_SP()
        {
            open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("ALL_LS_SP", conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
