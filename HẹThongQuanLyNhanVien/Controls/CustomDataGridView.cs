using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HẹThongQuanLyNhanVien.Controls
{
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            // Thiết lập DoubleBuffered để tránh hiện tượng flickering khi vẽ
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Gọi phương thức OnPaint của lớp cơ sở để vẽ nội dung DataGridView
            base.OnPaint(e);

            // Vẽ góc cong cho khung của DataGridView
            int cornerRadius = 10;
            Rectangle borderRect = new Rectangle(0, 0, Width - 1, Height - 1);
            GraphicsPath borderPath = GetRoundedRectPath(borderRect, cornerRadius);

            using (Pen borderPen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawPath(borderPen, borderPath);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            path.AddArc(rect.Right - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Bottom - cornerRadius * 2);
            path.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            path.CloseFigure();

            return path;
        }
    }
}
