using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.Model;
using System.Windows.Forms;
using HẹThongQuanLyNhanVien.SERVICE;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using iTextSharp.text;

namespace HẹThongQuanLyNhanVien.CONTROLER
{
    public class banggiaController
    {
        SqlConnection conn = new SqlConnection(Database.conn);
        private void open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public int insert(banggia bg)
        {
            int i = 0;
            open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO banggia(ten,gia) VALUES(@ten,@gia)", conn);
                cmd.Parameters.AddWithValue("@ten",bg.Ten);
                cmd.Parameters.AddWithValue("@gia", bg.Gia);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bị trùng tên !");
                Console.WriteLine(ex.ToString());
            }
            return i;
        }
        public int delete(int ma)
        {
            int i = 0;
            open();
            SqlCommand cmd = new SqlCommand("DELETE FROM banggia WHERE ma = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", ma);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public int config(banggia bg)
        {
            int i = 0;
            open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE banggia SET ten=@ten,gia=@gia WHERE ma = @ma", conn);
                cmd.Parameters.AddWithValue("@ma", bg.Id);
                cmd.Parameters.AddWithValue("@ten", bg.Ten);
                cmd.Parameters.AddWithValue("@gia", bg.Gia);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return i;
        }
        //======================================Trinh độ========================
        public int insertSanPham(SanPham sp)
        {
            int i = 0;
            open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO sanpham(ten,gia,soluong) VALUES(@ten,@gia,@soluong)", conn);
                cmd.Parameters.AddWithValue("@ten", sp.Ten);
                cmd.Parameters.AddWithValue("@gia", sp.Gia);
                cmd.Parameters.AddWithValue("@soluong", sp.Soluong); //sửa ****
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bị trùng tên !");
                Console.WriteLine(ex.ToString());
            }
            return i;
        }
        public int deleteSanPham(int ma)
        {
            int i = 0;
            open();
            SqlCommand cmd = new SqlCommand("DELETE FROM sanpham WHERE id = @ma", conn);
            cmd.Parameters.AddWithValue("@ma", ma);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public int configSanPham(SanPham sp)
        {
            int i = 0;
            open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE sanpham SET ten=@ten,gia=@gia,soluong=@soluong WHERE id = @ma", conn);
                cmd.Parameters.AddWithValue("@ma", sp.Id);
                cmd.Parameters.AddWithValue("@ten", sp.Ten);
                cmd.Parameters.AddWithValue("@gia", sp.Gia);
                cmd.Parameters.AddWithValue("@soluong", sp.Soluong);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return i;
        }
        public int capnhatSoluongSP(int sl,int id)
        {
            Console.WriteLine(sl);
            Console.WriteLine(sl);
            Console.WriteLine(sl);
            Console.WriteLine(sl);
            Console.WriteLine(sl);
            Console.WriteLine(sl);
            Console.WriteLine(sl);
            Console.WriteLine(sl);
            Console.WriteLine(sl);
            int i = 0;
            open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE sanpham SET soluong = soluong - @soluong WHERE id = @ma", conn);
                cmd.Parameters.AddWithValue("@soluong", sl);
                cmd.Parameters.AddWithValue("@ma", id);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return i;
        }
        public int themLichSu(SanPham sp)
        {
            int i = 0;
            open();
            try
            {
                SqlCommand cmd1 = new SqlCommand("INSERT INTO LichSuSP(Ten,Tien,Soluong) VALUES(@ten,@gia,@soluong)", conn);
                cmd1.Parameters.AddWithValue("@ten", sp.Ten);
                cmd1.Parameters.AddWithValue("@gia", sp.Gia);
                cmd1.Parameters.AddWithValue("@soluong", sp.Soluong);
                i = cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bị trùng tên !");
                Console.WriteLine(ex.ToString());
            }
            return i;
        }
        public string getTongTien()
        {
            int sum = 0;
            open();
            SqlCommand cmd = new SqlCommand("SELECT gia FROM sanpham", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                sum += function.ChangeStrToNumber(rd["gia"].ToString());
            }
            conn.Close();
            
            return function.ChangeMoney(sum) + " đ";
        }
        public int delLichSu()
        {
            int i = 0;
            open();
            SqlCommand cmd = new SqlCommand("DELETE FROM LichSuSP", conn);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
