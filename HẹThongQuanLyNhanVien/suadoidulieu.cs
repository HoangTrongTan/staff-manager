using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien
{
    public partial class suadoidulieu : Form
    {
        nhanvien nv = null;
        SqlConnection conn = new SqlConnection(Database.conn);
        List<nhanvien> lsnv = new List<nhanvien>();
        private List<nhanvien> All()
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            List<nhanvien> ls = new List<nhanvien>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ls.Add(
                    new nhanvien(
                        rd["manv"].ToString(),
                        Convert.ToInt32(rd["songaylam"].ToString()),
                        Convert.ToInt32(rd["songaynghi"].ToString()),
                        rd["luonghientai"].ToString(),
                        rd["tongluong"].ToString()
                        )
                    );
            }
            conn.Close();
            return ls;
        }
        private int sua(nhanvien nv)
        {
            if(this.nv == null)
            {
                function.mess("bị null");
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int i = 0;
            List<nhanvien> ls = new List<nhanvien>();
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET songaylam=@songaylam ,songaynghi=@songaynghi ,luonghientai=@luonghientai ,tongluong=@tongluong WHERE manv=@manv", conn);
            cmd.Parameters.AddWithValue("@manv",nv.Manv);
            cmd.Parameters.AddWithValue("@songaylam", nv.Songaylam);
            cmd.Parameters.AddWithValue("@songaynghi", nv.Songaynghi);
            cmd.Parameters.AddWithValue("@luonghientai", nv.LuongHienTai);
            cmd.Parameters.AddWithValue("@tongluong", nv.Tongluong);
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        private void loadData()
        {
            lsnv.Clear();
            cbxmanv.Items.Clear();
            lsnv = All();
            cbxmanv.Items.AddRange(lsnv.Select(i => i.Manv).ToArray());
            if(cbxmanv.Items.Count > 0)
            {
                cbxmanv.SelectedIndex = 0;
            }
        }
        public suadoidulieu()
        {
            InitializeComponent();
            loadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSongaylam__TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSongaylam.Texts, "[a-zA-Z]") ){
                txtKetQua.Text = "không nhập chữ";
            }
        }

        private void txtSongaynghi__TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSongaylam.Texts, "[a-zA-Z]"))
            {
                txtKetQua.Text = "không nhập chữ";
            }
        }

        private void txtLuonghientai__TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtLuonghientai.Texts, "[a-zA-Z]"))
            {
                txtKetQua.Text = "không nhập chữ";
            }
        }

        private void txtTongluong__TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTongluong.Texts, "[a-zA-Z]"))
            {
                txtKetQua.Text = "không nhập chữ";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
            timer1.Stop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(sua(new nhanvien(
                        cbxmanv.SelectedItem.ToString(),
                        Convert.ToInt32(txtSongaylam.Texts.ToString()),
                        Convert.ToInt32(txtSongaynghi.Texts.ToString()),
                        txtLuonghientai.Texts.ToString(),
                        txtTongluong.Texts.ToString()
                        )) > 0)
            {
                loadData();
                function.mess("Sửa thành công !!");
            }
        }

        private void cbxmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nv = lsnv.Find(i => i.Manv.Equals(cbxmanv.SelectedItem));
            txtSongaylam.Texts = nv.Songaylam.ToString();
            txtSongaynghi.Texts = nv.Songaynghi.ToString();
            txtLuonghientai.Texts = nv.LuongHienTai.ToString();
            txtTongluong.Texts = nv.Tongluong.ToString();
        }
    }
}
