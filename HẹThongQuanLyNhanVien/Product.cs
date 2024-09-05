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
using DevExpress.XtraPrinting;
using HẹThongQuanLyNhanVien.CONTROLER;
using HẹThongQuanLyNhanVien.DAO;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien
{
    
    public partial class Product : Form
    {
        banggiaDao dao = new banggiaDao();
        banggiaController controll = new banggiaController();
        DataTable data;
        SanPham obj;
        bool isShow;
        
        public Product()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (panel.Visible)
            //{
            //    //panel.Hide();
            //    isShow = false;
            //    timer1.Start();
            //}
            //else
            //{
            //    //panel.Show();
            //    isShow = true;
            //    panel.Show();
            //    timer1.Start();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (isShow)
            //{
            //    if(panel.Height >= 460)
            //        timer1.Stop();
            //    panel.Height += 150;
            //}
            //else
            //{
            //    if(panel.Height <= 0)
            //    {
            //        timer1.Stop();
            //        panel.Hide();
            //    }
            //    panel.Height -= 150;
            //}
        }
        private void load()
        {
            data = dao.getAllSP();
            TableSanPham.DataSource = dao.getAllSP();
            TableSanPham.Columns[0].HeaderText = "Mã";
            TableSanPham.Columns[1].HeaderText = "Tên";
            TableSanPham.Columns[2].HeaderText = "Giá";
            TableSanPham.Columns[3].HeaderText = "Số lượng";
            cbxSanPham.Items.Clear();
            cbxSanPham.Items.AddRange(dao.getListSP().Select(item => item.Ten).ToArray());
            cbxSanPham.SelectedIndex = 0;
        }
        private void loadLichSu()
        {
            tableLichSu.DataSource = dao.ALL_LS_SP();
            tableLichSu.Columns[0].HeaderText = "Mã"; tableLichSu.Columns[0].ReadOnly = true;
            tableLichSu.Columns[1].HeaderText = "Tên"; tableLichSu.Columns[1].ReadOnly = true;
            tableLichSu.Columns[2].HeaderText = "Số lượng"; tableLichSu.Columns[2].ReadOnly = true;
            tableLichSu.Columns[3].HeaderText = "Giá"; tableLichSu.Columns[3].ReadOnly = true;
            tableLichSu.Columns[4].HeaderText = "Thời gian"; tableLichSu.Columns[4].ReadOnly = true;


            tableLichSu.Columns[0].ReadOnly = true; tableLichSu.Columns[0].Width = 30;
            tableLichSu.Columns[2].ReadOnly = true; tableLichSu.Columns[2].Width = 50;
        }
        private void refresh()
        {
            txtGia.Texts = "";
            txtTen.Texts = String.Empty;
            txtsoluongsp.Texts = "";
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void Product_Load(object sender, EventArgs e)
        {
            
            load();
            loadLichSu();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(txtGia.Texts.Equals("") || txtTen.Texts.Equals("")  || txtsoluongsp.Texts.Equals(""))
            {
                function.mess("Bạn chưa nhập đủ dữ liệu !!");
            }
            else
            {
                if (controll.insertSanPham(
                   new SanPham(
                       txtTen.Texts.ToString(),
                       txtGia.Texts.ToString(),
                       Convert.ToInt32(txtsoluongsp.Texts.ToString())
                       )
                ) > 0)
                {
                    load();
                    refresh();
                    function.mess("Thêm thành công !!");

                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TableSanPham.Rows[TableSanPham.CurrentRow.Index].Cells[0].Value.ToString());
            if(controll.deleteSanPham(id) > 0)
            {
                load();
                refresh();
                function.mess("Xóa thành công !!");
            }
        }

        private void TableSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtGia.Texts = TableSanPham.Rows[i].Cells[2].Value.ToString();
            txtTen.Texts = TableSanPham.Rows[i].Cells[1].Value.ToString();
            txtsoluongsp.Texts = TableSanPham.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TableSanPham.Rows[TableSanPham.CurrentRow.Index].Cells[0].Value.ToString());
            if (controll.configSanPham(
                   new SanPham(
                       id,
                       txtTen.Texts.ToString(),
                       txtGia.Texts.ToString(),
                       Convert.ToInt32(txtsoluongsp.Texts.ToString())
                       )
                ) > 0)
            {
                load();
                refresh();
                function.mess("Sửa thành công !!");

            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            string str = txtTimKiem.Texts.ToLower();
            if (str.Equals(""))
            {
                TableSanPham.DataSource = dao.getAllSP();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã", typeof(string));
                dt.Columns.Add("Tên", typeof(string));
                dt.Columns.Add("Giá", typeof(string));
                dt.Columns.Add("Số lượng", typeof(string));
                foreach (DataRow i in data.Rows)
                {
                    if (i["ten"].ToString().ToLower().Contains(str))
                    {
                        dt.Rows.Add(i["id"].ToString(), i["ten"].ToString(), i["gia"].ToString(), i["soluong"].ToString());
                    }
                }
                TableSanPham.DataSource = dt;
            }
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (TableSanPham.Rows.Count >= 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save file Excels";
                saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        function.ExportExcels(saveFileDialog.FileName, TableSanPham);
                        function.mess("Xuất file thành công !!");
                    }
                    catch (Exception ex)
                    {
                        function.mess("Xuất file thành công !!" + ex.ToString());
                    }
                }
            }
            else
            {
                function.mess("Dữ liệu trống !!");
            }
        }

        private void txtsoluongsp__TextChanged(object sender, EventArgs e)
        {
            ktraTextNumber(txtsoluongsp.Texts.ToString());
        }
        private void ktraTextNumber(string str)
        {
            if (Regex.IsMatch(str, "[a-zA-Z]"))
            {
                timer2.Start();
                txtsoluongsp.Texts = "";
                errMessageSoluong.Text = "Vui lòng nhập số !";
            }
        }
        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (txtTen.Texts.Equals(""))
            {
                timer2.Start();
                errMessageTenLoai.Text = "mục này đang trống !!";

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TxtThongBao.Text = "";
            errMessageTenLoai.Text = "";
            errMessageSoluong.Text = "";
            errMessageGia.Text = "";
            errMessage.Text = "";
            timer2.Stop();
        }

        private void txtGia_Leave(object sender, EventArgs e)
        {
            if(txtGia.Texts.Equals(""))
            {
                timer2.Start();
                errMessageGia.Text = "mục này đang trống !!";

            }
        }
        private void tinhtong()
        {
            if (!txtSoluong.Texts.Equals(""))
            {
                int ketqua = Convert.ToInt32(txtSoluong.Texts) * function.ChangeStrToNumber(txtGiaTien.Text);
                txtTongGia.Text = "Tổng tiền: " + function.ChangeMoney(ketqua) + " đ";
            }
            else
            {
                txtTongGia.Text = "Tổng tiền: 0 đ";
            }
        }
        private void txtSoluong__TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSoluong.Texts, "[a-zA-Z]"))
            {
                timer2.Start();
                txtSoluong.Texts = String.Empty;
                errMessage.Text = "Không được nhạp chữ ";
            }
            else
            {
                tinhtong();
            }
        }

        private void cbxSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj = dao.getListSP().Find(item => item.Ten == cbxSanPham.Text);
            txtGiaTien.Text = obj.Gia;
            txtSlSp.Text = "Số lượng: " + obj.Soluong.ToString();
            tinhtong();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            //string tongtien = (function.ChangeStrToNumber(txtGiaTien.Text) * Convert.ToUInt32(txtSoluong.Texts)).ToString();
            //TxtThongBao
            if (txtSoluong.Texts.Equals("0") || txtSoluong.Texts.Equals("0"))
            {
                function.mess("Số lượng lớn hơn 0");
                return;
            }
            if(Convert.ToInt32(txtSoluong.Texts.ToString()) > obj.Soluong )
            {
                function.mess("Số lượng không đủ, hiện tại " + obj.Soluong);
            }
            else
            {
                obj.Soluong = Convert.ToInt32(txtSoluong.Texts);
                obj.Gia = function.ChangeMoney( Convert.ToInt32(txtSoluong.Texts) * function.ChangeStrToNumber(obj.Gia) ) + " vnd";
                if (controll.themLichSu(obj) + controll.capnhatSoluongSP(Convert.ToInt32(txtSoluong.Texts), obj.Id) > 1)
                {
                    timer2.Start();
                    loadLichSu();
                    load();
                    txtSoluong.Texts = "";

                    TxtThongBao.Text = "Cập nhật thành công !!";
                }
                    
            }
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            string str = txttimkiemLichSu.Texts.ToLower();
            if (str.Equals(""))
            {
                loadLichSu();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã", typeof(string));
                dt.Columns.Add("Tên", typeof(string));
                dt.Columns.Add("Số lượng", typeof(string));
                dt.Columns.Add("Giá", typeof(string));
                dt.Columns.Add("Thời gian", typeof(string));
                foreach (DataRow i in dao.ALL_LS_SP().Rows)
                {
                    if (i["Ten"].ToString().ToLower().Contains(str))
                    {
                        dt.Rows.Add(i["id"].ToString(), i["Ten"].ToString(), i["Soluong"].ToString(), i["Tien"].ToString(), i["thoigian"].ToString());
                    }
                }
                tableLichSu.DataSource = dt;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            txtTongTienCacSP.Text = controll.getTongTien();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            loadLichSu();
            controll.delLichSu();
        }
    }
}
 