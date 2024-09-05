using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HẹThongQuanLyNhanVien.Controls;
using HẹThongQuanLyNhanVien.DAO;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien
{
    public partial class NhanVien : Form
    {
        nhanvienDAO dao = new nhanvienDAO();
        public NhanVien()
        {
            InitializeComponent();
            txtTimekiem._TextChanged += TxtTimekiem__TextChanged;
        }

        private void TxtTimekiem__TextChanged(object sender, EventArgs e)
        {
            string str = txtTimekiem.Texts.ToString().ToLower();
            if (str.Equals(""))
            {
                TableNV.DataSource = dao.getList();
            }
            else
            {
                List<Person> ls = new List<Person>();
                foreach(Person i in dao.getList())
                {
                    if (i.Hoten.ToString().ToLower().Contains(str))
                    {
                        ls.Add(i);
                    }
                }
                TableNV.DataSource = ls;
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();
        }
        private void Lammoi()
        {
            txtManv.Texts = "";
            txtManv.Enabled = true;
            txtHoten.Texts = "";
            txtDiachi.Texts = "";

        }
        private void load()
        {
            TableNV.DataSource = dao.ALL();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtManv.Texts.Equals("") || txtHoten.Texts.Equals(""))
            {
                function.mess("vui lòng nhập thông tin đày đủ !!");
                return;
            }
            if (dao.insert(
                new Person(
                txtManv.Texts.ToString(),
                txtHoten.Texts.ToString(),
                txtDiachi.Texts.ToString(),
                function.convert_YYYY_MM_DD(namsinh.Value)
                )
                ) > 0 ) 
            {
                load();
                Lammoi();
                function.mess("Thêm thành công !!");
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dao.config(
                new Person(
                txtManv.Texts.ToString(),
                txtHoten.Texts.ToString(),
                txtDiachi.Texts.ToString(),
                function.convert_YYYY_MM_DD(namsinh.Value)
                )
                ) > 0)
            {
                load();
                Lammoi();
                function.mess("Sửa thành công !!");

            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Lammoi();
        }

        private void TableNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtManv.Enabled = false;
            txtManv.Texts = TableNV.Rows[i].Cells[0].Value.ToString();
            txtHoten.Texts = TableNV.Rows[i].Cells[1].Value.ToString();
            txtDiachi.Texts = TableNV.Rows[i].Cells[2].Value.ToString();
            namsinh.Text = TableNV.Rows[i].Cells[3].Value.ToString();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            int i = TableNV.CurrentRow.Index;
            string str = TableNV.Rows[i].Cells[0].Value.ToString();
            string ten = TableNV.Rows[i].Cells[1].Value.ToString();
            if (
                MessageBox.Show($"Bạn có chắc muốn xóa {ten} không !!", "hả",MessageBoxButtons.YesNo)
                == DialogResult.Yes
                ) 
            {
                if(dao.delete(str) > 0)
                {
                    load();
                    Lammoi();
                    function.mess("Đã xóa !");
                }
            }
            
        }
    }
}
