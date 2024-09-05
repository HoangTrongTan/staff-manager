using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HẹThongQuanLyNhanVien.Model
{
    public class Person
    {
        protected string manv, hoten, diachi, namsinh;
        public Person(string manv, string hoten, string diachi, string namsinh)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.namsinh = namsinh;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }

        public override string ToString()
        {
            return $"{this.manv}{this.hoten}{this.diachi}{this.namsinh}";
        }
    }
}
