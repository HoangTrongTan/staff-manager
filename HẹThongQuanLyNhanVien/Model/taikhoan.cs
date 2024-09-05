using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HẹThongQuanLyNhanVien.Model
{
    public class taikhoan
    {
        private string taiKhoan, matkhau, hoten;

        public taikhoan(string taiKhoan, string matkhau, string hoten)
        {
            this.taiKhoan = taiKhoan;
            this.matkhau = matkhau;
            this.hoten = hoten;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Hoten { get => hoten; set => hoten = value; }

        public override string ToString()
        {
            return $"taikhoan: {this.taiKhoan}, matkhau: {this.matkhau}, Hoten: {this.hoten}";
        }
    }
}
