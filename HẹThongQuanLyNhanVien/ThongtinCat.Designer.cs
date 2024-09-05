namespace HẹThongQuanLyNhanVien
{
    partial class ThongtinCat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbxDichVu = new System.Windows.Forms.ComboBox();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuonghienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableTinhCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.Label();
            this.txtChonNv = new System.Windows.Forms.Label();
            this.txtTinhTuDong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoluong = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.btnCapNhat = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.lbxNhanVien = new System.Windows.Forms.ListBox();
            this.timerText = new System.Windows.Forms.Timer(this.components);
            this.txtLuLicSuKQ = new System.Windows.Forms.Label();
            this.txtKtratext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableTinhCong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDichVu
            // 
            this.cbxDichVu.FormattingEnabled = true;
            this.cbxDichVu.Location = new System.Drawing.Point(177, 93);
            this.cbxDichVu.Name = "cbxDichVu";
            this.cbxDichVu.Size = new System.Drawing.Size(165, 24);
            this.cbxDichVu.TabIndex = 0;
            this.cbxDichVu.SelectedIndexChanged += new System.EventHandler(this.cbxDichVu_SelectedIndexChanged);
            // 
            // TongLuong
            // 
            this.TongLuong.HeaderText = "Tổng Lương";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.Width = 125;
            // 
            // LuonghienTai
            // 
            this.LuonghienTai.HeaderText = "Lương hiện tại";
            this.LuonghienTai.MinimumWidth = 6;
            this.LuonghienTai.Name = "LuonghienTai";
            this.LuonghienTai.Width = 125;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 150;
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 70;
            // 
            // TableTinhCong
            // 
            this.TableTinhCong.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.TableTinhCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableTinhCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableTinhCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.Ten,
            this.LuonghienTai,
            this.TongLuong});
            this.TableTinhCong.Location = new System.Drawing.Point(140, 336);
            this.TableTinhCong.Name = "TableTinhCong";
            this.TableTinhCong.RowHeadersWidth = 51;
            this.TableTinhCong.RowTemplate.Height = 24;
            this.TableTinhCong.Size = new System.Drawing.Size(787, 199);
            this.TableTinhCong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(101, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(101, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dịch Vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(101, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gía tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.AutoSize = true;
            this.txtGiaTien.ForeColor = System.Drawing.Color.Red;
            this.txtGiaTien.Location = new System.Drawing.Point(183, 146);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(0, 16);
            this.txtGiaTien.TabIndex = 2;
            // 
            // txtChonNv
            // 
            this.txtChonNv.AutoSize = true;
            this.txtChonNv.ForeColor = System.Drawing.Color.Red;
            this.txtChonNv.Location = new System.Drawing.Point(769, 58);
            this.txtChonNv.Name = "txtChonNv";
            this.txtChonNv.Size = new System.Drawing.Size(67, 16);
            this.txtChonNv.TabIndex = 2;
            this.txtChonNv.Text = "Nhân viên";
            // 
            // txtTinhTuDong
            // 
            this.txtTinhTuDong.AutoSize = true;
            this.txtTinhTuDong.Location = new System.Drawing.Point(174, 257);
            this.txtTinhTuDong.Name = "txtTinhTuDong";
            this.txtTinhTuDong.Size = new System.Drawing.Size(0, 16);
            this.txtTinhTuDong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(392, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bảng Tính Công";
            // 
            // txtSoluong
            // 
            this.txtSoluong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoluong.BorderColor = System.Drawing.Color.Aqua;
            this.txtSoluong.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSoluong.BorderRadius = 10;
            this.txtSoluong.BorderSize = 2;
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoluong.Location = new System.Drawing.Point(177, 192);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Multiline = false;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoluong.PasswordChar = false;
            this.txtSoluong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoluong.PlaceholderText = "";
            this.txtSoluong.Size = new System.Drawing.Size(153, 35);
            this.txtSoluong.TabIndex = 3;
            this.txtSoluong.Texts = "";
            this.txtSoluong.UnderlinedStyle = false;
            this.txtSoluong._TextChanged += new System.EventHandler(this.txtSoluong__TextChanged_1);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 10;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(429, 290);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(158, 40);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbxNhanVien
            // 
            this.lbxNhanVien.FormattingEnabled = true;
            this.lbxNhanVien.HorizontalScrollbar = true;
            this.lbxNhanVien.ItemHeight = 16;
            this.lbxNhanVien.Location = new System.Drawing.Point(635, 77);
            this.lbxNhanVien.Name = "lbxNhanVien";
            this.lbxNhanVien.ScrollAlwaysVisible = true;
            this.lbxNhanVien.Size = new System.Drawing.Size(333, 196);
            this.lbxNhanVien.Sorted = true;
            this.lbxNhanVien.TabIndex = 5;
            this.lbxNhanVien.SelectedIndexChanged += new System.EventHandler(this.lbxNhanVien_SelectedIndexChanged);
            // 
            // timerText
            // 
            this.timerText.Interval = 3000;
            this.timerText.Tick += new System.EventHandler(this.timerText_Tick);
            // 
            // txtLuLicSuKQ
            // 
            this.txtLuLicSuKQ.AutoSize = true;
            this.txtLuLicSuKQ.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuLicSuKQ.ForeColor = System.Drawing.Color.Red;
            this.txtLuLicSuKQ.Location = new System.Drawing.Point(12, 9);
            this.txtLuLicSuKQ.Name = "txtLuLicSuKQ";
            this.txtLuLicSuKQ.Size = new System.Drawing.Size(0, 30);
            this.txtLuLicSuKQ.TabIndex = 2;
            // 
            // txtKtratext
            // 
            this.txtKtratext.AutoSize = true;
            this.txtKtratext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKtratext.ForeColor = System.Drawing.Color.Red;
            this.txtKtratext.Location = new System.Drawing.Point(194, 235);
            this.txtKtratext.Name = "txtKtratext";
            this.txtKtratext.Size = new System.Drawing.Size(0, 16);
            this.txtKtratext.TabIndex = 6;
            // 
            // ThongtinCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 547);
            this.Controls.Add(this.txtKtratext);
            this.Controls.Add(this.lbxNhanVien);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtLuLicSuKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTinhTuDong);
            this.Controls.Add(this.txtChonNv);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableTinhCong);
            this.Controls.Add(this.cbxDichVu);
            this.Name = "ThongtinCat";
            this.Text = "HGHGHG";
            this.Load += new System.EventHandler(this.ThongtinCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableTinhCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuonghienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridView TableTinhCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtGiaTien;
        private System.Windows.Forms.Label txtChonNv;
        private System.Windows.Forms.Label txtTinhTuDong;
        private System.Windows.Forms.Label label4;
        private Controls.CustomTextBox txtSoluong;
        private Controls.customButton btnCapNhat;
        private System.Windows.Forms.ListBox lbxNhanVien;
        private System.Windows.Forms.Timer timerText;
        private System.Windows.Forms.Label txtLuLicSuKQ;
        private System.Windows.Forms.Label txtKtratext;
    }
}