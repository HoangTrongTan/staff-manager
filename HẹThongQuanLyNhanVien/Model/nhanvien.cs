using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.Data.Helpers.FindSearchRichParser;

namespace HẹThongQuanLyNhanVien.Model
{
    public class nhanvien : Person
    {
        
        private int sodaucat, songaylam, songaynghi, thuongthem, trinhdo,loaiviec;
        private string lydo, thoigian, luonghientai, tongluong;
        public nhanvien(string manv, string hoten, string diachi, string namsinh, int sodaucat, int songaylam, int songaynghi, int thuongthem, string tongluong, int trinhdo, int loaiviec)
                : base(manv, hoten, diachi, namsinh)
        {
            this.sodaucat = sodaucat;
            this.songaylam = songaylam;
            this.songaynghi = songaynghi;
            this.thuongthem = thuongthem;
            this.tongluong = tongluong;
            this.trinhdo = trinhdo;
            this.loaiviec = loaiviec; 
        }

        public nhanvien(string manv, string hoten,int songaylam, int songaynghi,string lydo,string thoigian)
               : base(manv, hoten, "", "")
        {
            this.lydo = lydo;
            this.songaylam = songaylam;
            this.songaynghi = songaynghi;
            this.thoigian = thoigian;
        }
        public nhanvien(string manv, string hoten,string luonghientai,string tongluong)
               : base(manv, hoten, "", "")
        {
            this.luonghientai = luonghientai;
            this.tongluong = tongluong;
        }
        public nhanvien(string manv, string hoten,int sodaucat,int loaiviec,string thoigian)
               : base(manv, hoten, "", "")
        {
            this.sodaucat = sodaucat;
            this.loaiviec = loaiviec;
            this.thoigian = thoigian;
        }

        public nhanvien(string manv,int songaylam, int songaynghi, string luonghientai, string tongluong)
            : base(manv, "", "", "")
        {
            this.songaylam = songaylam;
            this.songaynghi = songaynghi;
            this.luonghientai = luonghientai;
            this.tongluong = tongluong;
        }

        public int Sodaucat { get => sodaucat; set => sodaucat = value; }
        public int Songaylam { get => songaylam; set => songaylam = value; }
        public int Songaynghi { get => songaynghi; set => songaynghi = value; }
        public int Thuongthem { get => thuongthem; set => thuongthem = value; }
        public string Tongluong { get => tongluong; set => tongluong = value; }
        public int Trinhdo { get => trinhdo; set => trinhdo = value; }
        public string Lydo { get => lydo; set => lydo = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string LuongHienTai { get => luonghientai; set => luonghientai = value; }
        public int LoaiViec { get => loaiviec; set => loaiviec = value; }

        public override string ToString()
        {
            return $"{base.ToString()}{this.Hoten}{this.sodaucat}{this.songaylam}{this.songaynghi}{this.thuongthem}{this.tongluong}{this.trinhdo}";
        }
    }
}
