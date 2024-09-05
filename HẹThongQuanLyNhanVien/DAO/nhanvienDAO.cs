using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.SERVICE;
using HẹThongQuanLyNhanVien.Model;
using System.Windows.Forms;

namespace HẹThongQuanLyNhanVien.DAO
{
    public class nhanvienDAO
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        public List<nhanvien> getListNhanVienTinhCong()
        {
            List<nhanvien> ls = new List<nhanvien>();
            
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT manv,hoten,luonghientai,tongluong FROM NhanVien", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ls.Add(
                    new nhanvien(
                        rd["manv"].ToString(),
                        rd["hoten"].ToString(),
                        rd["luonghientai"].ToString(),
                        rd["tongluong"].ToString()
                        ));
            }
            conn.Close();
            return ls;
        }
        public List<Person> getList()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            List<Person> list = new List<Person>();
            SqlCommand cmd = new SqlCommand("SELECT manv,hoten,diachi,namsinh FROM NhanVien", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(
                    new Person(
                        rd["manv"].ToString(),
                        rd["hoten"].ToString(),
                        rd["diachi"].ToString(),
                        rd["namsinh"].ToString()
                        ));
            }
            conn.Close();
            return list;
        }
        public DataTable ALL()
        {
            DataTable tb = new DataTable();
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlDataAdapter adapter =  new SqlDataAdapter("SELECT manv,hoten,diachi,namsinh FROM NhanVien", conn);
            adapter.Fill(tb);
            conn.Close();
            return tb;
        }
        public int insert(Person nv)
        {
            int i = 0;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien(manv,hoten,diachi,namsinh) VALUES(@manv,@hoten,@diachi,@namsinh)", conn);
                cmd.Parameters.AddWithValue("@manv", nv.Manv);
                cmd.Parameters.AddWithValue("@hoten", nv.Hoten);
                cmd.Parameters.AddWithValue("@diachi", nv.Diachi);
                cmd.Parameters.AddWithValue("@namsinh", nv.Namsinh);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bị trùng mã !");
                Console.WriteLine(ex.ToString());
            }
            return i;
        }
        public int delete(string mnv)
        {
            int i = 0;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE manv = @manv", conn);
            cmd.Parameters.AddWithValue("@manv", mnv);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public int config(Person nv)
        {
            int i = 0;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET hoten=@hoten,diachi=@diachi,namsinh=@namsinh WHERE manv=@manv", conn);
            cmd.Parameters.AddWithValue("@manv", nv.Manv);
            cmd.Parameters.AddWithValue("@hoten", nv.Hoten);
            cmd.Parameters.AddWithValue("@diachi", nv.Diachi);
            cmd.Parameters.AddWithValue("@namsinh", nv.Namsinh);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

    }
}
