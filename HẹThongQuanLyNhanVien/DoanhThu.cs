using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HẹThongQuanLyNhanVien.CONTROLER;
using HẹThongQuanLyNhanVien.DAO;
using HẹThongQuanLyNhanVien.SERVICE;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization;

namespace HẹThongQuanLyNhanVien
{
    public partial class DoanhThu : Form
    {
        dasboardControll dasboard = new dasboardControll();
        doanhthuDao dao = new doanhthuDao();
        doanhthuControll controll = new doanhthuControll();
        Dictionary<string, string> lsdoanhthu = new Dictionary<string, string>();
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            if(dasboard.Kichhoat > 0)
            {
                checkKichHoat.Checked = true;
            }
            TableDoanhThu.DataSource = dao.getAllDoanhThu();
            ChartDoanhThu.DataSource = dao.getChartAll();
            ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Họ tên";
            ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Lương";

            ChartDoanhThu.Series["Series1"].XValueMember = "hoten";
            ChartDoanhThu.Series["Series1"].YValueMembers = "tongluong";
            ChartDoanhThu.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;


            TableDoanhThu.Columns[0].HeaderText = "Mã"; TableDoanhThu.Columns[0].ReadOnly = true;
            TableDoanhThu.Columns[1].HeaderText = "Tên"; TableDoanhThu.Columns[1].ReadOnly = true;
            TableDoanhThu.Columns[2].HeaderText = "Địa chỉ"; TableDoanhThu.Columns[2].ReadOnly = true;
            TableDoanhThu.Columns[3].HeaderText = "Năm sinh"; TableDoanhThu.Columns[3].ReadOnly = true;
            TableDoanhThu.Columns[4].HeaderText = "Số ngày làm"; TableDoanhThu.Columns[4].ReadOnly = true;
            TableDoanhThu.Columns[5].HeaderText = "Số ngày nghỉ"; TableDoanhThu.Columns[5].ReadOnly = true;
            TableDoanhThu.Columns[6].HeaderText = "Thưởng thêm";
            TableDoanhThu.Columns[7].HeaderText = "Thời gian"; TableDoanhThu.Columns[7].ReadOnly = true;
            TableDoanhThu.Columns[8].HeaderText = "Lương hiện tại"; TableDoanhThu.Columns[8].ReadOnly = true;
            TableDoanhThu.Columns[9].HeaderText = "Tông lương"; TableDoanhThu.Columns[9].ReadOnly = true;
            if (!controll.TongDoanhThu().Equals(""))
            {
                txtTonhDoanhThu.Text = "Tổng tiền tất cả: " + function.ChangeMoney(Convert.ToInt32(controll.TongDoanhThu()) ) + " VNĐ" ;
            }
            foreach (DataRow i in dao.getAllDoanhThu().Rows)
            {
                lsdoanhthu.Add(i["hoten"].ToString(), i["manv"].ToString());
            }

            lbxdoanhthu.Items.AddRange(lsdoanhthu.Keys.ToArray());
            if(lbxdoanhthu.Items.Count > 0)
            {
                lbxdoanhthu.SelectedIndex = 0;
            }
        }

        private void TableDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i >= 0) {
                txtThuongthem.Texts = TableDoanhThu.Rows[i].Cells[6].Value.ToString();
            }
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
                if (txtThuongthem.Texts.Equals(""))
                {
                    function.mess("Bạn chưa nhập tiền để thêm");
                }
                else
                {
                    string thuongthem = function.ChangeStrToNumber(txtThuongthem.Texts).ToString();
                    string manv = lblmanv.Text;
                    if (controll.updateThuongthem(thuongthem, manv) > 0)
                    {
                        txtThuongthem.Texts = "";
                        TableDoanhThu.DataSource = dao.getAllDoanhThu();
                        ChartDoanhThu.DataSource = dao.getChartAll();
                        ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Họ tên";
                        ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Lương";

                        ChartDoanhThu.Series["Series1"].XValueMember = "hoten";
                        ChartDoanhThu.Series["Series1"].YValueMembers = "tongluong";
                        ChartDoanhThu.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                        timer1.Start();
                        txtKetQua.Text = "Cập nhật thành công !!";
                    }
                }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtketQuaKichHoat.Text = "";
            lblktratext.Text = "";
            txtKetQua.Text = String.Empty;
            timer1.Stop();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if(TableDoanhThu.Rows.Count >= 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save file Excels";
                saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        function.ExportExcels(saveFileDialog.FileName, TableDoanhThu);
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

        private void customButton2_Click(object sender, EventArgs e)
        {
            function.ExportPdf(TableDoanhThu);
        }

        private void lbxdoanhthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsdoanhthu.TryGetValue(lbxdoanhthu.SelectedItem.ToString(), out string manv))
            {
                lblmanv.Text = manv;
            }
        }

        private void txtThuongthem__TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtThuongthem.Texts, "[a-zA-Z]")){
                timer1.Start();
                txtThuongthem.Texts = "";
                lblktratext.Text = "không được nhập chữ !!";
            }
        }




        private void btnLammoi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn làm mới không ?","hả",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(dasboard.ThangMoi_LamMoi_NhanVien() > 0)
                {
                    TableDoanhThu.DataSource = dao.getAllDoanhThu();
                    ChartDoanhThu.DataSource = dao.getChartAll();
                    ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Họ tên";
                    ChartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Lương";

                    ChartDoanhThu.Series["Series1"].XValueMember = "hoten";
                    ChartDoanhThu.Series["Series1"].YValueMembers = "tongluong";
                    ChartDoanhThu.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    function.mess("Cập nhật thành công !!");
                }
            }
        }

        private void btnKicHoat_Click(object sender, EventArgs e)
        {
           bool chk = checkKichHoat.Checked;
            if (chk)
            {
                if (MessageBox.Show("khi cài đặt hệ thống sẽ tự làm mới cả tiền lương số ngày làm và nghỉ\n của nhân viên khi sang tháng mới", "lựa chọn", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        if (controll.capnhatKichHoat(checkKichHoat.Checked) > 0)
                        {
                            timer1.Start();
                            txtketQuaKichHoat.Text = "Đã kích hoạt thành công";

                        }

                }
                else
                {
                    checkKichHoat.Checked = false;
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn bỏ lựa chọn tự động cập nhật khum :>>>", "lựa chọn", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (controll.capnhatKichHoat(checkKichHoat.Checked) > 0)
                    {
                        timer1.Start();
                        txtketQuaKichHoat.Text = "Đã hủy bỏ tính năng";

                    }
                }
                else
                {
                    checkKichHoat.Checked = true;
                }
            }
        }
    }
}
