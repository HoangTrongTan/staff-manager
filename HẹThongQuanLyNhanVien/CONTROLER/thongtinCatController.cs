using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.SERVICE;
using HẹThongQuanLyNhanVien.Model;

namespace HẹThongQuanLyNhanVien.CONTROLER
{
    public class thongtinCatController
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        private void open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public int capnhatthongtin(nhanvien nv)
        {
            open();
            int i = 0;
            SqlCommand cmd = new SqlCommand("INSERT INTO NV_temp(hoten,sodaucat,loaiviec,thoigian,manv) VALUES(@hoten,@sodaucat,@loaiviec,@thoigian,@manv)", conn);
            cmd.Parameters.AddWithValue("@manv", nv.Manv);
            cmd.Parameters.AddWithValue("@hoten", nv.Hoten);
            cmd.Parameters.AddWithValue("@sodaucat", nv.Sodaucat);
            cmd.Parameters.AddWithValue("@loaiviec", nv.LoaiViec);
            cmd.Parameters.AddWithValue("@thoigian", nv.Thoigian);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("\n\n\n\n"+i.ToString() + "\n\n\n"+nv.ToString());
            return i;
        }
        public int capnhatTien(string luong,string manv)
        {
            open();
            int i = 0;
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET luonghientai =luonghientai+ @luong,tongluong= tongluong+@luong WHERE manv = @manv", conn);
            cmd.Parameters.AddWithValue("@luong",Convert.ToInt32(luong)  );
            cmd.Parameters.AddWithValue("@manv", manv);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("\n\n\n\nTiền nong" + i.ToString() + "\n\n\n"+luong+ manv);
            return i;
        }
        public int CapNhatLuong(string luonghientai,string tongluong)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET luonghientai=@luonghientai,tongluong=@tongluong WHERE manv=@manv", conn);

            return i;
        }
    }
}
