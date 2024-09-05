using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HẹThongQuanLyNhanVien.Model
{
    public class SanPham : banggia
    {
        private int soluong = 0;

        public SanPham(string ten, string gia,int soluong) : base(ten, gia)
        {
            this.soluong = soluong;
        }
        public SanPham(int id,string ten, string gia, int soluong) : base(id,ten, gia)
        {
            this.soluong = soluong;
        }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
