using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HẹThongQuanLyNhanVien.DAO;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien
{
    public partial class DiemDanh : Form
    {
        diemdanh dd = new diemdanh();
        string tong = "";
        public DiemDanh()
        {
            InitializeComponent();
        }

        private void DiemDanh_Load(object sender, EventArgs e)
        {
            TableVang.DataSource = dd.getAllVang(function.curentDate());
            txtThoiGian.Text = function.curentDate();
            DataTable dt = dd.getAll();
            TableDiemDanh.DataSource = dt;
            tong = dt.Rows.Count.ToString();
            TableDiemDanh.Columns[0].HeaderText = "Vắng"; TableDiemDanh.Columns[0].Width = 50;
            TableDiemDanh.Columns[1].HeaderText = "Lý do"; 
            TableDiemDanh.Columns[2].HeaderText = "Mã"; TableDiemDanh.Columns[2].ReadOnly = true;
            TableDiemDanh.Columns[3].HeaderText = "Tên"; TableDiemDanh.Columns[3].ReadOnly = true;
            TableDiemDanh.Columns[4].HeaderText = "Số ngày làm"; TableDiemDanh.Columns[4].ReadOnly = true; TableDiemDanh.Columns[4].Width = 60;
            TableDiemDanh.Columns[5].HeaderText = "Số ngày nghỉ"; TableDiemDanh.Columns[5].ReadOnly = true; TableDiemDanh.Columns[5].Width = 60;
            TableDiemDanh.Columns[6].HeaderText = "Thời gian"; TableDiemDanh.Columns[6].ReadOnly = true;

        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            if(dd.checkDiemDanh(function.curentDate()) >= 1)
            {
                function.mess("Bạn đã điểm danh rồi !!");
            }
            else
            {
                foreach (DataGridViewRow row in TableDiemDanh.Rows)
                {
                    bool check = false;
                    if (row.Cells[0].Value != null)
                    {
                        check = Convert.ToBoolean(row.Cells[0].Value);
                    }
                    Console.WriteLine(check.ToString());
                    if (check)
                    {
                        string ma = row.Cells[2].Value.ToString();
                        string lydo = row.Cells[1].Value.ToString();
                        dd.capnhat(ma, check, function.curentDate());
                        dd.vang(ma, function.curentDate(), lydo);
                    }
                    else
                    {
                        string ma = row.Cells[2].Value.ToString();
                        dd.capnhat(ma, check, function.curentDate());
                    }
                }
                
            }
            DataTable dt = dd.getAllVang(function.curentDate());

            TableVang.DataSource = dt;
            TableDiemDanh.DataSource = dd.getAll();
            txtNV_lietke.Text = "Tổng số nhân viên vắng: " + dt.Rows.Count.ToString() + "//" + tong;

        }

        private void TableVang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TableVang.Columns[0].HeaderText = "Mã nv"; TableVang.Columns[0].ReadOnly = true;
            TableVang.Columns[1].HeaderText = "Họ tên"; TableVang.Columns[1].ReadOnly = true;
            TableVang.Columns[2].HeaderText = "thời gian"; TableVang.Columns[2].ReadOnly = true;
            TableVang.Columns[3].HeaderText = "Lý do"; TableVang.Columns[3].ReadOnly = true;
        }
    }
}
