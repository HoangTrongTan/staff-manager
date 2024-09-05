using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HẹThongQuanLyNhanVien.Model
{
    public class banggia
    {
        private int id;
        private string ten;
        private string gia;

        public banggia(int id, string ten, string gia)
        {
            this.id = id;
            this.ten = ten;
            this.gia = gia;
        }

        public banggia(string ten, string gia)
        {
            this.ten = ten;
            this.gia = gia;
        }
        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gia { get => gia; set => gia = value; }

        public override string ToString()
        {
            return $"{id}{ten}{gia}";
        }
    }
}
