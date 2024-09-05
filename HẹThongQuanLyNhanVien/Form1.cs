using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using HẹThongQuanLyNhanVien.DAO;
using HẹThongQuanLyNhanVien.Model;
using HẹThongQuanLyNhanVien.Resources;
using HẹThongQuanLyNhanVien.SERVICE;

namespace HẹThongQuanLyNhanVien
{
    public partial class Form1 : Form
    {
        taikhoanDAO dao = new taikhoanDAO();
        public Form1()
        {
            InitializeComponent();
        }
        private bool isDragging = false;
        private int mouseX;
        private int mouseY;
        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = new Icon(Application.StartupPath + "\\iconForm.ico");
            pictureBox1.Load(Application.StartupPath + "\\iconForm.png");
            // Đặt FormBorderStyle thành None để loại bỏ thanh tiêu đề của form
            this.FormBorderStyle = FormBorderStyle.None;

            // Tạo một GraphicsPath mới với hình dạng tùy chỉnh
            GraphicsPath roundedRectPath = CreateRoundedRectPath(new Rectangle(0, 0, this.Width, this.Height), 7);

            // Tạo một Region mới từ GraphicsPath để có góc cong nhẹ
            Region roundedRegion = new Region(roundedRectPath);

            // Đặt Region cho form để có góc cong nhẹ
            this.Region = roundedRegion;
            acc.Load(Application.StartupPath + "\\iconacc.png");
            pass.Load(Application.StartupPath + "\\iconmk.png");
        }

        // Hàm tạo GraphicsPath với góc cong nhẹ
        private GraphicsPath CreateRoundedRectPath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRectPath = new GraphicsPath();

            roundedRectPath.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRectPath.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRectPath.AddArc(rect.Right - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRectPath.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Bottom - cornerRadius * 2);
            roundedRectPath.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRectPath.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRectPath.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRectPath.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);

            roundedRectPath.CloseFigure();

            return roundedRectPath;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kiểm tra xem có phải chuột trái đang được nhấn vào form không
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kết thúc di chuyển form
            isDragging = false;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Register dk = new Register();
            dk.Show();

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            taikhoan tk = dao.checkLogin(new taikhoan(txtTaiKhoan.Texts, txtMatKhau.Texts, ""));
            if (tk != null)
            {
                Dasboard ql = new Dasboard(tk.Hoten,tk.TaiKhoan);
                ql.Show();
                this.Hide();
            }
            else
            {
                function.mess("sai tên đăng nhập hoặc mật khẩu ");
            }
        }
    }
}
