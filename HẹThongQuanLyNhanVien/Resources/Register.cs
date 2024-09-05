using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace HẹThongQuanLyNhanVien.Resources
{
    public partial class Register : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2VOI5GT\\SQLEXPRESS;Initial Catalog=QLNHANVIEN;Integrated Security=True");
        private bool isDragging = false;
        private int mouseX;
        private int mouseY;
        public Register()
        {
            InitializeComponent();
        }
        private void BtnTao_Click(object sender, EventArgs e)
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into account values(@taikhoan,@matkhau,@hoten)", conn);
            cmd.Parameters.AddWithValue("@taikhoan", txtTaiKhoan.Texts);
            cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Texts);
            cmd.Parameters.AddWithValue("@hoten", txtTen.Texts);
            try
            {
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công !! \nMời đăng nhập.");
                    this.Dispose();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Trùng mã");
            }
        }

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
        private void Register_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            // Tạo một GraphicsPath mới với hình dạng tùy chỉnh
            GraphicsPath roundedRectPath = CreateRoundedRectPath(new Rectangle(0, 0, this.Width, this.Height), 7);

            // Tạo một Region mới từ GraphicsPath để có góc cong nhẹ
            Region roundedRegion = new Region(roundedRectPath);

            // Đặt Region cho form để có góc cong nhẹ
            this.Region = roundedRegion;
            //
            anhAcc.Load(Application.StartupPath + "\\iconacc.png");
            anhpass.Load(Application.StartupPath + "\\iconmk.png");
            anhTen.Load(Application.StartupPath + "\\iconTen.png");
        }



        private void Register_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kiểm tra xem có phải chuột trái đang được nhấn vào form không
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void Register_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void Register_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kết thúc di chuyển form
            isDragging = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gradientPanel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kiểm tra xem có phải chuột trái đang được nhấn vào form không
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void gradientPanel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void gradientPanel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Kết thúc di chuyển form
            isDragging = false;
        }
    }
}
