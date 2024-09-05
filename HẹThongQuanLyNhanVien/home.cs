using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HẹThongQuanLyNhanVien
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        private async void AnimateText()
        {
            while (true)
            {
                // Lấy font hiện tại của chữ
                Font currentFont = label1.Font;

                // Tạo font mới với kích thước lớn hơn
                Font bigFont = new Font(currentFont.FontFamily, currentFont.Size * 2, FontStyle.Bold);

                // Đặt font mới cho chữ
                label1.Font = bigFont;

                // Đặt màu sắc ngẫu nhiên cho chữ
                Random random = new Random();
                label1.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                // Đợi một khoảng thời gian nhỏ
                await Task.Delay(500);

                // Tạo font mới với kích thước nhỏ hơn
                Font smallFont = new Font(currentFont.FontFamily, currentFont.Size / 1, FontStyle.Regular);

                // Đặt font mới cho chữ
                label1.Font = smallFont;

                // Đặt màu sắc ngẫu nhiên cho chữ
                label1.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                // Đợi một khoảng thời gian nhỏ
                await Task.Delay(500);
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            AnimateText();
        }
    }
}
