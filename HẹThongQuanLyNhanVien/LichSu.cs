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
using HẹThongQuanLyNhanVien.CONTROLER;
using System.Security.Cryptography.X509Certificates;
using HẹThongQuanLyNhanVien.SERVICE;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace HẹThongQuanLyNhanVien
{
    public partial class LichSu : Form
    {
        lichsuDao dao = new lichsuDao();
        lichsuControll controll = new lichsuControll();
        public LichSu()
        {
            InitializeComponent();
        }
        private void loadThoiGian()
        {
            cbxthoigian.DataSource = dao.getAllTime();
        }
        private void LichSu_Load(object sender, EventArgs e)

        {
            loadThoiGian();
            TableLichSu.DataSource = dao.getAll();
           
            radioMa.Checked = true;
        }

        private void btnXoaLichSu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có chắc muốn xóa !!","?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(controll.delete() > 0)
                {
                    TableLichSu.DataSource = dao.getAll();
                    txtketqua.Text = "Xóa thành công !!";
                    timer.Start();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtketqua.Text = String.Empty;
            timer.Stop();
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            string str = txtTimKiem.Texts.ToLower();
            if (str.Equals(""))
            {
                TableLichSu.DataSource = dao.getAll();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã", typeof(string));
                dt.Columns.Add("Tên", typeof(string));
                dt.Columns.Add("Số đầu cắt", typeof(string));
                dt.Columns.Add("dịch vụ", typeof(string));
                dt.Columns.Add("Thời gian", typeof(string));

                if (radioMa.Checked)
                {
                    foreach(DataRow i in dao.getAll().Rows)
                    {
                        if (i["Mã nv"].ToString().ToLower().Contains(str))
                        {
                            dt.Rows.Add(i["Mã nv"].ToString(), i["name"].ToString(), i["số đầu cắt"].ToString(), i["DV"].ToString(), i["thoigian"].ToString());
                        }
                    }
                }
                else
                {
                    foreach (DataRow i in dao.getAll().Rows)
                    {
                        if (i["name"].ToString().ToLower().Contains(str))
                        {
                            dt.Rows.Add(i["Mã nv"].ToString(), i["name"].ToString(), i["số đầu cắt"].ToString(), i["DV"].ToString(), i["thoigian"].ToString());
                        }
                    }
                }
                TableLichSu.DataSource = dt;
            }
        }
        private void cbxthoigian_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cbxthoigian.SelectedItem.ToString();
            if (str.Equals(""))
            {
                TableLichSu.DataSource = dao.getAll();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã", typeof(string));
                dt.Columns.Add("Tên", typeof(string));
                dt.Columns.Add("Số đầu cắt", typeof(string));
                dt.Columns.Add("tên", typeof(string));
                dt.Columns.Add("Thời gian", typeof(string));
                foreach (DataRow i in dao.getAll().Rows)
                {
                    if (i["thoigian"].ToString().Contains(str))
                    {
                        dt.Rows.Add(i["manv"].ToString(), i["hoten"].ToString(), i["sodaucat"].ToString(), i["ten"].ToString(), i["thoigian"].ToString());
                    }
                }
                TableLichSu.DataSource = dt;
            }
        }
        

        private void btnXuatExcels_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    function.ExportExcels(saveFileDialog.FileName,TableLichSu);
                    function.mess("Xuất file thành công !!");
                }
                catch(Exception ex)
                {
                    function.mess("Xuất file thành công !!" + ex.ToString());
                }
            }
        }
        
        private void btnPdf_Click(object sender, EventArgs e)
        {
            function.ExportPdf(TableLichSu);
        }
    }
}
