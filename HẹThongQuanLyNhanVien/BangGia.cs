using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HẹThongQuanLyNhanVien.CONTROLER;
using HẹThongQuanLyNhanVien.DAO;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien
{
    public partial class BangGia : Form
    {
        banggiaDao dao = new banggiaDao();
        banggiaController controll = new banggiaController();
        public BangGia()
        {
            InitializeComponent();
            txtTimKiem._TextChanged += TxtTimKiem__TextChanged;
        }
        private void Lammoi()
        {
            txtTen.Texts = "";
            txtGia.Texts = "";
        }
        private void BangGia_Load(object sender, EventArgs e)
        {

            TableBangGia.DataSource = dao.getAll();
        }
        private void TxtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string str = txtTimKiem.Texts.ToString().ToLower();
            if (str.Equals(""))
            {
                TableBangGia.DataSource = dao.getAll();
            }
            else
            {
                List<banggia> ls = new List<banggia>();
                foreach (banggia item in dao.getList())
                {
                    if (item.Ten.ToString().ToLower().Contains(str))
                    {
                        ls.Add(item);
                    }
                }
                TableBangGia.DataSource = ls;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTen.Texts.Equals("") || txtGia.Texts.Equals(""))
            {
                if (txtTen.Texts.Equals("")) function.mess("Bạn chưa nhập tên !");
                if (txtGia.Texts.Equals("")) function.mess("Bạn chưa nhập giá !!");
            }
            else
            {
                if (controll.insert(
                new banggia(
                    txtTen.Texts,
                    txtGia.Texts
                    )) > 0)
                {
                    TableBangGia.DataSource = dao.getAll();
                    Lammoi();
                    function.mess("Thêm thành công !!");

                }
            }
            
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(TableBangGia.Rows[TableBangGia.CurrentRow.Index].Cells[0].Value.ToString() );
            if(MessageBox.Show("Bạn có chắc muốn xóa ?","hả",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(controll.delete(ma) > 0)
                {
                    TableBangGia.DataSource = dao.getAll();
                    Lammoi();
                    function.mess("Xóa thành công !!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(TableBangGia.Rows[TableBangGia.CurrentRow.Index].Cells[0].Value.ToString());
            if (controll.config(
                new banggia(ma,
                    txtTen.Texts,
                    txtGia.Texts
                    )) > 0)
            {
                TableBangGia.DataSource = dao.getAll();
                Lammoi();
                function.mess("Sửa thành công !!");

            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Lammoi();
        }

       

        private void TableBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtTen.Texts = TableBangGia.Rows[i].Cells[1].Value.ToString();
                txtGia.Texts = TableBangGia.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void txtGia__TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtGia.Texts, "[a-zA-Z]"))
            {
                timer1.Start();
                txtGia.Texts = "";
                txtKtraText.Text = "Không được nhập chữ !!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtKtraText.Text = String.Empty;
            timer1.Stop();
        }
    }
}
