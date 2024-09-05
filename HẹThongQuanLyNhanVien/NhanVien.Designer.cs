namespace HẹThongQuanLyNhanVien
{
    partial class NhanVien
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.namsinh = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.TableNV = new HẹThongQuanLyNhanVien.Controls.CustomDataGridView();
            this.btnLammoi = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.btnThem = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.btnSua = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.txtDiachi = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtHoten = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtManv = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtTimekiem = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(109, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(109, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(109, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(109, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Năm sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(411, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(344, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh Sách Nhân Viên";
            // 
            // namsinh
            // 
            this.namsinh.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.namsinh.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.namsinh.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.namsinh.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.namsinh.CustomFormat = " ";
            this.namsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.namsinh.Location = new System.Drawing.Point(178, 223);
            this.namsinh.Name = "namsinh";
            this.namsinh.Size = new System.Drawing.Size(215, 22);
            this.namsinh.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Xoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // Xoa
            // 
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(104, 24);
            this.Xoa.Text = "Xóa";
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // TableNV
            // 
            this.TableNV.BackgroundColor = System.Drawing.Color.White;
            this.TableNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableNV.ContextMenuStrip = this.contextMenuStrip1;
            this.TableNV.Location = new System.Drawing.Point(84, 294);
            this.TableNV.Name = "TableNV";
            this.TableNV.RowHeadersWidth = 51;
            this.TableNV.RowTemplate.Height = 24;
            this.TableNV.Size = new System.Drawing.Size(844, 211);
            this.TableNV.TabIndex = 5;
            this.TableNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableNV_CellClick);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLammoi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLammoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLammoi.BorderRadius = 10;
            this.btnLammoi.BorderSize = 1;
            this.btnLammoi.FlatAppearance.BorderSize = 0;
            this.btnLammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLammoi.ForeColor = System.Drawing.Color.White;
            this.btnLammoi.Location = new System.Drawing.Point(754, 161);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(116, 34);
            this.btnLammoi.TabIndex = 2;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextColor = System.Drawing.Color.White;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 1;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(754, 109);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderSize = 1;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(754, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiachi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiachi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDiachi.BorderRadius = 10;
            this.txtDiachi.BorderSize = 1;
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiachi.Location = new System.Drawing.Point(178, 170);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Multiline = false;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiachi.PasswordChar = false;
            this.txtDiachi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiachi.PlaceholderText = "";
            this.txtDiachi.Size = new System.Drawing.Size(215, 35);
            this.txtDiachi.TabIndex = 1;
            this.txtDiachi.Texts = "";
            this.txtDiachi.UnderlinedStyle = false;
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoten.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHoten.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHoten.BorderRadius = 10;
            this.txtHoten.BorderSize = 1;
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoten.Location = new System.Drawing.Point(178, 127);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Multiline = false;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHoten.PasswordChar = false;
            this.txtHoten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoten.PlaceholderText = "";
            this.txtHoten.Size = new System.Drawing.Size(215, 35);
            this.txtHoten.TabIndex = 1;
            this.txtHoten.Texts = "";
            this.txtHoten.UnderlinedStyle = false;
            // 
            // txtManv
            // 
            this.txtManv.BackColor = System.Drawing.SystemColors.Window;
            this.txtManv.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtManv.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtManv.BorderRadius = 10;
            this.txtManv.BorderSize = 1;
            this.txtManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManv.Location = new System.Drawing.Point(178, 84);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4);
            this.txtManv.Multiline = false;
            this.txtManv.Name = "txtManv";
            this.txtManv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtManv.PasswordChar = false;
            this.txtManv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtManv.PlaceholderText = "";
            this.txtManv.Size = new System.Drawing.Size(215, 35);
            this.txtManv.TabIndex = 1;
            this.txtManv.Texts = "";
            this.txtManv.UnderlinedStyle = false;
            // 
            // txtTimekiem
            // 
            this.txtTimekiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimekiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimekiem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTimekiem.BorderRadius = 10;
            this.txtTimekiem.BorderSize = 1;
            this.txtTimekiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimekiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimekiem.Location = new System.Drawing.Point(480, 210);
            this.txtTimekiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimekiem.Multiline = false;
            this.txtTimekiem.Name = "txtTimekiem";
            this.txtTimekiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimekiem.PasswordChar = false;
            this.txtTimekiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimekiem.PlaceholderText = "";
            this.txtTimekiem.Size = new System.Drawing.Size(215, 35);
            this.txtTimekiem.TabIndex = 1;
            this.txtTimekiem.Texts = "";
            this.txtTimekiem.UnderlinedStyle = false;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 547);
            this.Controls.Add(this.TableNV);
            this.Controls.Add(this.namsinh);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.txtTimekiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.CustomTextBox txtTimekiem;
        private Controls.customButton btnSua;
        private System.Windows.Forms.Label label2;
        private Controls.CustomTextBox txtHoten;
        private Controls.CustomTextBox txtDiachi;
        private Controls.customButton btnThem;
        private Controls.customButton btnLammoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Controls.CustomTextBox txtManv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker namsinh;
        private Controls.CustomDataGridView TableNV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Xoa;
    }
}