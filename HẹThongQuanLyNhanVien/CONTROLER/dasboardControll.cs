using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.SERVICE;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace HẹThongQuanLyNhanVien.CONTROLER
{
    public class dasboardControll
    {
        private string ngayhomqua = ""; 
        private int kichhoat = 0;
        SqlConnection conn = new SqlConnection(Database.conn);

        public int Kichhoat { get => kichhoat; set => kichhoat = value; }
        public string Ngayhomqua { get => ngayhomqua; set => ngayhomqua = value; }

        public dasboardControll()
        {
            getThoiGian(this.ngayhomqua, this.kichhoat);
        }

        private void open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public int ThangMoi_LamMoi_NhanVien()
        {
            int i = 0;
            open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET songaylam = 0,songaynghi = 0, thuongthem = 0,luonghientai = 0,tongluong = 0", conn);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật resfresh nhan viên về lương và sô ngày làm"+ ex.ToString());
                Console.WriteLine(ex.ToString());
            }
            return i;
        }
        public void getThoiGian(string ngayhomqua,int kichhoat)
        {
            open();
            SqlCommand cmd = new SqlCommand("SELECT ngayhomqua, kichhoat FROM Calendar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    Console.WriteLine(reader["ngayhomqua"].ToString());
                    this.ngayhomqua = reader["ngayhomqua"].ToString();
                }
                if (!reader.IsDBNull(1))
                {
                    this.kichhoat = reader.GetInt32(1);
                }
            }
            reader.Close();
            conn.Close();
        }
        
        public int ghiThoiGian()
        {
            open();
            int i =  0;
            SqlCommand cmd = new SqlCommand("UPDATE Calendar SET ngayhomqua=@ngayhomqua", conn);
            cmd.Parameters.AddWithValue("@ngayhomqua", DateTime.Now.ToString("MM/dd/yyyy"));
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public bool docThoiGian()
        {
            DateTime ngayhomnay = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime ngayhomquaa = DateTime.ParseExact(function.TachngayThangNamDoanhThu(this.ngayhomqua), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //function.mess(function.TachngayThangNamDoanhThu(this.ngayhomqua) + (ngayhomnay.Month - ngayhomquaa.Month).ToString() );
            if ((ngayhomnay.Month - ngayhomquaa.Month) > 0)
            {
                Console.WriteLine((ngayhomnay.Month - ngayhomquaa.Month));
                ThangMoi_LamMoi_NhanVien();
                return true;
            }
            return false;
        }
        public int doimatkhau(string tk,string mk)
        {
            open();
            int i = 0;
            SqlCommand cmd = new SqlCommand("UPDATE Account SET MatKhau = @MatKhau WHERE TaiKhoan=@TaiKhoan", conn);
            cmd.Parameters.AddWithValue("@TaiKhoan",tk);
            cmd.Parameters.AddWithValue("@MatKhau",mk);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public override string ToString()
        {
            return $"{this.ngayhomqua}";
        }
    }
}
