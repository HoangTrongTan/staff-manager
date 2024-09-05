namespace HẹThongQuanLyNhanVien
{
    partial class suadoidulieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.Label();
            this.cbxmanv = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSongaylam = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtTongluong = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtLuonghientai = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtSongaynghi = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.btnSua = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số ngày làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số ngày nghỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(23, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lương hiện tại ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(23, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng lương";
            // 
            // txtKetQua
            // 
            this.txtKetQua.AutoSize = true;
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua.Location = new System.Drawing.Point(108, 9);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(0, 18);
            this.txtKetQua.TabIndex = 0;
            this.txtKetQua.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbxmanv
            // 
            this.cbxmanv.FormattingEnabled = true;
            this.cbxmanv.Location = new System.Drawing.Point(111, 32);
            this.cbxmanv.Name = "cbxmanv";
            this.cbxmanv.Size = new System.Drawing.Size(138, 24);
            this.cbxmanv.TabIndex = 9;
            this.cbxmanv.SelectedIndexChanged += new System.EventHandler(this.cbxmanv_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(26, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nv";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtSongaylam
            // 
            this.txtSongaylam.BackColor = System.Drawing.SystemColors.Window;
            this.txtSongaylam.BorderColor = System.Drawing.Color.Teal;
            this.txtSongaylam.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSongaylam.BorderRadius = 14;
            this.txtSongaylam.BorderSize = 2;
            this.txtSongaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongaylam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSongaylam.Location = new System.Drawing.Point(112, 63);
            this.txtSongaylam.Margin = new System.Windows.Forms.Padding(4);
            this.txtSongaylam.Multiline = false;
            this.txtSongaylam.Name = "txtSongaylam";
            this.txtSongaylam.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSongaylam.PasswordChar = false;
            this.txtSongaylam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSongaylam.PlaceholderText = "";
            this.txtSongaylam.Size = new System.Drawing.Size(138, 35);
            this.txtSongaylam.TabIndex = 10;
            this.txtSongaylam.Texts = "";
            this.txtSongaylam.UnderlinedStyle = false;
            this.txtSongaylam._TextChanged += new System.EventHandler(this.txtSongaylam__TextChanged);
            // 
            // txtTongluong
            // 
            this.txtTongluong.BackColor = System.Drawing.SystemColors.Window;
            this.txtTongluong.BorderColor = System.Drawing.Color.Teal;
            this.txtTongluong.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTongluong.BorderRadius = 14;
            this.txtTongluong.BorderSize = 2;
            this.txtTongluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTongluong.Location = new System.Drawing.Point(111, 228);
            this.txtTongluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongluong.Multiline = false;
            this.txtTongluong.Name = "txtTongluong";
            this.txtTongluong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTongluong.PasswordChar = false;
            this.txtTongluong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTongluong.PlaceholderText = "";
            this.txtTongluong.Size = new System.Drawing.Size(138, 35);
            this.txtTongluong.TabIndex = 8;
            this.txtTongluong.Texts = "";
            this.txtTongluong.UnderlinedStyle = false;
            this.txtTongluong._TextChanged += new System.EventHandler(this.txtTongluong__TextChanged);
            // 
            // txtLuonghientai
            // 
            this.txtLuonghientai.BackColor = System.Drawing.SystemColors.Window;
            this.txtLuonghientai.BorderColor = System.Drawing.Color.Teal;
            this.txtLuonghientai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLuonghientai.BorderRadius = 14;
            this.txtLuonghientai.BorderSize = 2;
            this.txtLuonghientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuonghientai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLuonghientai.Location = new System.Drawing.Point(111, 175);
            this.txtLuonghientai.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuonghientai.Multiline = false;
            this.txtLuonghientai.Name = "txtLuonghientai";
            this.txtLuonghientai.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLuonghientai.PasswordChar = false;
            this.txtLuonghientai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLuonghientai.PlaceholderText = "";
            this.txtLuonghientai.Size = new System.Drawing.Size(138, 35);
            this.txtLuonghientai.TabIndex = 6;
            this.txtLuonghientai.Texts = "";
            this.txtLuonghientai.UnderlinedStyle = false;
            this.txtLuonghientai._TextChanged += new System.EventHandler(this.txtLuonghientai__TextChanged);
            // 
            // txtSongaynghi
            // 
            this.txtSongaynghi.BackColor = System.Drawing.SystemColors.Window;
            this.txtSongaynghi.BorderColor = System.Drawing.Color.Teal;
            this.txtSongaynghi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSongaynghi.BorderRadius = 14;
            this.txtSongaynghi.BorderSize = 2;
            this.txtSongaynghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongaynghi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSongaynghi.Location = new System.Drawing.Point(111, 116);
            this.txtSongaynghi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSongaynghi.Multiline = false;
            this.txtSongaynghi.Name = "txtSongaynghi";
            this.txtSongaynghi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSongaynghi.PasswordChar = false;
            this.txtSongaynghi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSongaynghi.PlaceholderText = "";
            this.txtSongaynghi.Size = new System.Drawing.Size(138, 35);
            this.txtSongaynghi.TabIndex = 4;
            this.txtSongaynghi.Texts = "";
            this.txtSongaynghi.UnderlinedStyle = false;
            this.txtSongaynghi._TextChanged += new System.EventHandler(this.txtSongaynghi__TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Teal;
            this.btnSua.BackgroundColor = System.Drawing.Color.Teal;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 16;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(90, 289);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // suadoidulieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 365);
            this.Controls.Add(this.txtSongaylam);
            this.Controls.Add(this.cbxmanv);
            this.Controls.Add(this.txtTongluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLuonghientai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSongaynghi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "suadoidulieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suadoidulieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.customButton btnSua;
        private Controls.CustomTextBox txtSongaynghi;
        private System.Windows.Forms.Label label2;
        private Controls.CustomTextBox txtLuonghientai;
        private System.Windows.Forms.Label label3;
        private Controls.CustomTextBox txtTongluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtKetQua;
        private System.Windows.Forms.ComboBox cbxmanv;
        private System.Windows.Forms.Label label9;
        private Controls.CustomTextBox txtSongaylam;
        private System.Windows.Forms.Timer timer1;
    }
}