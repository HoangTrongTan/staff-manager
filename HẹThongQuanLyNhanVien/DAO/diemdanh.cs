using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Export.Xl;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien.DAO
{
    public class diemdanh
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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT manv,hoten,songaylam,songaynghi,thoigian FROM NhanVien", conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public void capnhat(string manv,bool nghi,string thoigian)
        {
            try
            {
                open();
                string sql = "UPDATE NhanVien SET songaylam=songaylam+1,thoigian=@thoigian WHERE manv=@manv";
                if (nghi)
                {
                    sql = "UPDATE NhanVien SET songaynghi=songaynghi+1,thoigian=@thoigian WHERE manv=@manv";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@thoigian",thoigian);
                cmd.Parameters.AddWithValue("@manv",manv);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                function.mess("Có lỗi" + ex.ToString());
                Console.WriteLine("\n\n"+ex.ToString());
            }
            
        }
        public int checkDiemDanh(string thoigian)
        {
            int i = 0;
            open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE thoigian=@thoigian", conn);
            cmd.Parameters.AddWithValue("@thoigian", thoigian);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                i += 1;
            }
            conn.Close();
            return i;
        }
        public void vang(string mnv,string thoigian,string lydo)
        {
            open();
            SqlCommand cmd = new SqlCommand("INSERT INTO vang VALUES(@manv,@thoigian,@lydo)", conn);
            cmd.Parameters.AddWithValue("@manv", mnv);
            cmd.Parameters.AddWithValue("@thoigian", thoigian);
            cmd.Parameters.AddWithValue("@lydo", lydo);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getAllVang(string thoigian)
        {
            open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT t.manv,n.hoten,t.thoigian,t.lydo FROM vang as t INNER JOIN NhanVien as n ON t.manv = n.manv WHERE t.thoigian = '" + thoigian+"'", conn);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
