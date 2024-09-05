using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using HẹThongQuanLyNhanVien.SERVICE;
using HẹThongQuanLyNhanVien.Utils;
using HẹThongQuanLyNhanVien.CONTROLER;
using iTextSharp.text.pdf.parser;
using Microsoft.VisualBasic;

namespace HẹThongQuanLyNhanVien
{
    public partial class Dasboard : Form
    {
        private string ten = "";
        private string tk = "";
        private bool isDragging = false;
        private int mouseX;
        private int mouseY;
        private Form currchildFrom;
        private dasboardControll controll = new dasboardControll();
        public Dasboard(string ten,string tk)
        {
            InitializeComponent();
            timer1.Start();
            txtTen.BackColor = Color.Transparent;
            
            this.ten = ten;
            this.tk = tk;
            txtTen.Text = "Chào mừng " + this.ten + " !";
        }
        
        private void OpenChildFrom(Form child)
        {
            if (currchildFrom != null)
            {
                currchildFrom.Close();
            }
            currchildFrom = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(child);
            PanelMain.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void Dasboard_Load(object sender, EventArgs e)
        {
            if(controll.Kichhoat > 0)
            {
                controll.docThoiGian();
                controll.ghiThoiGian();
            } 
            GraphicsPath radiusForm = Form_style.CreateRoundedRectPath(new Rectangle(0, 0, this.Width, this.Height), 5);
            Region roundedRegion = new Region(radiusForm);
            this.Region = roundedRegion;
            avartar.BackColor = Color.Transparent;
            avartar.BorderStyle = BorderStyle.None;
            avartar.Load(Application.StartupPath + "\\dasboard.png");
            anhbg.Load(Application.StartupPath + "\\bg.jpg");

        }

        private void btnQlNV_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new NhanVien());
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new DiemDanh());
        }

        private void btn_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new BangGia());
        }

        private void btnThongtinCat_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new ThongtinCat());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLichSuLamViec_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new LichSu());
        }

        private void btnQlNV_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void btnQlNV_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kiểm tra xem có đang di chuyển form không
            if (isDragging)
            {
                // Tính toán vị trí mới của form dựa trên sự di chuyển của chuột
                int deltaX = e.X - mouseX;
                int deltaY = e.Y - mouseY;
                this.Location = new System.Drawing.Point(this.Left + deltaX, this.Top + deltaY);
            }
        }

        private void btnQlNV_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kết thúc di chuyển form
            isDragging = false;
        }

 

        private void Dasboard_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kiểm tra xem có đang di chuyển form không
            if (isDragging)
            {
                // Tính toán vị trí mới của form dựa trên sự di chuyển của chuột
                int deltaX = e.X - mouseX;
                int deltaY = e.Y - mouseY;
                this.Location = new System.Drawing.Point(this.Left + deltaX, this.Top + deltaY);
            }
        }

        private void Dasboard_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kết thúc di chuyển form
            isDragging = false;
        }

        private void Dasboard_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string content = "";
            using (Form passwordForm = new Form())
            {
                passwordForm.Text = "Đổi mật khẩu";
                passwordForm.Width = 300;
                passwordForm.Height = 150;

                Label label = new Label();
                label.Text = "Nhập mật khẩu mới:";
                label.Location = new Point(10, 20);
                passwordForm.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.PasswordChar = '?';
                textBox.Location = new Point(10, 50);
                passwordForm.Controls.Add(textBox);

                Button buttonOk = new Button();
                buttonOk.Text = "OK";
                buttonOk.DialogResult = DialogResult.OK;
                buttonOk.Location = new Point(10, 80);
                passwordForm.Controls.Add(buttonOk);

                passwordForm.AcceptButton = buttonOk;

                DialogResult result = passwordForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    content = textBox.Text;
                    // Xử lý mật khẩu mới...
                    if (controll.doimatkhau(this.tk, content) > 0)
                    {
                        function.mess("Đổi mật khẩu thành công !!");
                    }
                }
            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildFrom(new DoanhThu());
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildFrom(new home());
        }

        private void btnThoiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildFrom(new ThoiTiet());
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn đăng xuất !!","hả",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTen.Text = txtTen.Text.Substring(1, txtTen.Text.Length - 1) + txtTen.Text.Substring(0, 1);
        }

        private void btnSuaDoiDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            suadoidulieu sua = new suadoidulieu();
            sua.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Product());
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
