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
    public partial class ThongtinCat : Form
    {
        thongtinCatController thongtinControl = new thongtinCatController();
        ThongTinCatDao thongtindao = new ThongTinCatDao();
        banggiaDao bg = new banggiaDao();
        nhanvienDAO nvdao = new nhanvienDAO();
        Dictionary<string, string> danhsachDichVu;
        Dictionary<string, string> nhanvienls;
        List<banggia> lsdv;
        List<nhanvien> lsnv;
        public ThongtinCat()
        {
            InitializeComponent();
            txtSoluong._TextChanged += TxtSoluong__TextChanged;
        }

        private void tinhtong()
        {
            if (!txtSoluong.Texts.Equals(""))
            {
                int ketqua = Convert.ToInt32(txtSoluong.Texts) * function.ChangeStrToNumber(txtGiaTien.Text);
                txtTinhTuDong.Text = "Tổng tiền: " + function.ChangeMoney(ketqua)+ " đ";
            }
            else
            {
                txtTinhTuDong.Text = "Tổng tiền: 0 đ";
            }
        }
        private void TxtSoluong__TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSoluong.Texts, "[a-zA-Z]") )
            {
                timerText.Start();
                txtSoluong.Texts = String.Empty;
                txtKtratext.Text = "Không được nhạp chữ ";
            }
            else
            {
                tinhtong();
            }
            
        }

        public void LoadData()
        {
            foreach(nhanvien i in nvdao.getListNhanVienTinhCong())
            {
                TableTinhCong.Rows.Add(i.Manv,i.Hoten,i.LuongHienTai,i.Tongluong);
            }
        }
        private void ThongtinCat_Load(object sender, EventArgs e)
        {
            lsdv = bg.getList();
            lsnv = nvdao.getListNhanVienTinhCong();

            danhsachDichVu = lsdv.ToDictionary(i => i.Ten, i => i.Gia);
            nhanvienls = lsnv.ToDictionary(i => i.Hoten, i => i.Manv);

            cbxDichVu.Items.AddRange(lsdv.Select(item => item.Ten).ToArray());
            cbxDichVu.SelectedIndex = 0;
            txtGiaTien.Text = lsdv[0].Gia.ToString();
            lbxNhanVien.Items.AddRange(lsnv.Select(i => i.Hoten).ToArray());
            if (lsnv.Count > 0)
            {
                lbxNhanVien.SelectedIndex = 0;
            }
            LoadData();

            
        }

        private void cbxDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(danhsachDichVu.TryGetValue(cbxDichVu.Text, out string ten))
            {
                txtGiaTien.Text = ten+" đ";
            }
            tinhtong();
        }

        private void lbxNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(nhanvienls.TryGetValue(lbxNhanVien.SelectedItem.ToString(),out string ma))
            {
                txtChonNv.Text = ma;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int id = lsdv.Find(i => i.Ten.Equals(cbxDichVu.Text.ToString())).Id;
            if (thongtinControl.capnhatthongtin(
                new nhanvien(
                    txtChonNv.Text.ToString(),
                    lbxNhanVien.SelectedItem.ToString(),
                    Convert.ToInt32(txtSoluong.Texts.ToString()),
                    id,
                    function.curentDate() 
                    )
                ) > 0)
            {
                timerText.Start();
                txtLuLicSuKQ.Text = "Đã cập nhật " + lbxNhanVien.SelectedItem + " !!";
            }

            string tongtien = (function.ChangeStrToNumber(txtGiaTien.Text) * Convert.ToUInt32(txtSoluong.Texts) ).ToString();
            if(thongtinControl.capnhatTien(tongtien,txtChonNv.Text ) > 0)
            {
                TableTinhCong.Rows.Clear();
                LoadData();
                function.mess("cập nhật thành công");
            }
        }
        private void timerText_Tick(object sender, EventArgs e)
        {
            txtKtratext.Text = "";
            txtLuLicSuKQ.Text = String.Empty;
            timerText.Stop();
        }
        private void txtSoluong__TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
