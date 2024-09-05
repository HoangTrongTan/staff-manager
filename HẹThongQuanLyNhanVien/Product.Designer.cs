namespace HẹThongQuanLyNhanVien
{
    partial class Product
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtThongBao = new System.Windows.Forms.Label();
            this.customButton3 = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaSanPham = new System.Windows.Forms.Label();
            this.txtSlSp = new System.Windows.Forms.Label();
            this.errMessage = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.Label();
            this.customButton2 = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongGia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.cbxSanPham = new System.Windows.Forms.ComboBox();
            this.tableLichSu = new System.Windows.Forms.DataGridView();
            this.txttimkiemLichSu = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTongTienCacSP = new System.Windows.Forms.Label();
            this.txtKtraText = new System.Windows.Forms.Label();
            this.TableSanPham = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errMessageSoluong = new System.Windows.Forms.Label();
            this.errMessageTenLoai = new System.Windows.Forms.Label();
            this.errMessageGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customButton1 = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.btnExcel = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.txtTimKiem = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtsoluongsp = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtGia = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.txtTen = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.btnLammoi = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.btnSua = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.btnThem = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLichSu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSanPham)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 552);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TxtThongBao);
            this.tabPage1.Controls.Add(this.customButton3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.tableLichSu);
            this.tabPage1.Controls.Add(this.txttimkiemLichSu);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thao tác";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(140, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 22);
            this.label9.TabIndex = 61;
            this.label9.Text = "Cập nhật hàng";
            // 
            // TxtThongBao
            // 
            this.TxtThongBao.AutoSize = true;
            this.TxtThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtThongBao.ForeColor = System.Drawing.Color.Lime;
            this.TxtThongBao.Location = new System.Drawing.Point(403, 20);
            this.TxtThongBao.Name = "TxtThongBao";
            this.TxtThongBao.Size = new System.Drawing.Size(0, 22);
            this.TxtThongBao.TabIndex = 60;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customButton3.BorderColor = System.Drawing.Color.Magenta;
            this.customButton3.BorderRadius = 10;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(839, 92);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(125, 37);
            this.customButton3.TabIndex = 3;
            this.customButton3.Text = "Xóa lịch sử";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaSanPham);
            this.panel1.Controls.Add(this.txtSlSp);
            this.panel1.Controls.Add(this.errMessage);
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Controls.Add(this.customButton2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTongGia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSoluong);
            this.panel1.Controls.Add(this.cbxSanPham);
            this.panel1.Location = new System.Drawing.Point(8, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 443);
            this.panel1.TabIndex = 59;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.AutoSize = true;
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMaSanPham.Location = new System.Drawing.Point(314, 110);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(0, 16);
            this.txtMaSanPham.TabIndex = 7;
            // 
            // txtSlSp
            // 
            this.txtSlSp.AutoSize = true;
            this.txtSlSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlSp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSlSp.Location = new System.Drawing.Point(144, 110);
            this.txtSlSp.Name = "txtSlSp";
            this.txtSlSp.Size = new System.Drawing.Size(0, 16);
            this.txtSlSp.TabIndex = 6;
            // 
            // errMessage
            // 
            this.errMessage.AutoSize = true;
            this.errMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMessage.ForeColor = System.Drawing.Color.Red;
            this.errMessage.Location = new System.Drawing.Point(154, 191);
            this.errMessage.Name = "errMessage";
            this.errMessage.Size = new System.Drawing.Size(0, 16);
            this.errMessage.TabIndex = 5;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.AutoSize = true;
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtGiaTien.Location = new System.Drawing.Point(144, 83);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(0, 16);
            this.txtGiaTien.TabIndex = 4;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customButton2.BorderColor = System.Drawing.Color.Magenta;
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(106, 219);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(246, 37);
            this.customButton2.TabIndex = 3;
            this.customButton2.Text = "Cập nhật";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng";
            // 
            // txtTongGia
            // 
            this.txtTongGia.AutoSize = true;
            this.txtTongGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongGia.ForeColor = System.Drawing.Color.Red;
            this.txtTongGia.Location = new System.Drawing.Point(148, 187);
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(0, 20);
            this.txtTongGia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên sản phẩm";
            // 
            // txtSoluong
            // 
            this.txtSoluong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoluong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoluong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoluong.BorderRadius = 10;
            this.txtSoluong.BorderSize = 2;
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoluong.Location = new System.Drawing.Point(147, 132);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Multiline = false;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoluong.PasswordChar = false;
            this.txtSoluong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoluong.PlaceholderText = "";
            this.txtSoluong.Size = new System.Drawing.Size(192, 35);
            this.txtSoluong.TabIndex = 1;
            this.txtSoluong.Texts = "";
            this.txtSoluong.UnderlinedStyle = false;
            this.txtSoluong._TextChanged += new System.EventHandler(this.txtSoluong__TextChanged);
            // 
            // cbxSanPham
            // 
            this.cbxSanPham.FormattingEnabled = true;
            this.cbxSanPham.Location = new System.Drawing.Point(147, 50);
            this.cbxSanPham.Name = "cbxSanPham";
            this.cbxSanPham.Size = new System.Drawing.Size(193, 24);
            this.cbxSanPham.TabIndex = 0;
            this.cbxSanPham.SelectedIndexChanged += new System.EventHandler(this.cbxSanPham_SelectedIndexChanged);
            // 
            // tableLichSu
            // 
            this.tableLichSu.BackgroundColor = System.Drawing.Color.White;
            this.tableLichSu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLichSu.Location = new System.Drawing.Point(448, 136);
            this.tableLichSu.Name = "tableLichSu";
            this.tableLichSu.RowHeadersWidth = 51;
            this.tableLichSu.RowTemplate.Height = 24;
            this.tableLichSu.Size = new System.Drawing.Size(538, 383);
            this.tableLichSu.TabIndex = 58;
            // 
            // txttimkiemLichSu
            // 
            this.txttimkiemLichSu.BackColor = System.Drawing.SystemColors.Window;
            this.txttimkiemLichSu.BorderColor = System.Drawing.Color.Fuchsia;
            this.txttimkiemLichSu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txttimkiemLichSu.BorderRadius = 10;
            this.txttimkiemLichSu.BorderSize = 2;
            this.txttimkiemLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemLichSu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttimkiemLichSu.Location = new System.Drawing.Point(626, 94);
            this.txttimkiemLichSu.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiemLichSu.Multiline = false;
            this.txttimkiemLichSu.Name = "txttimkiemLichSu";
            this.txttimkiemLichSu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txttimkiemLichSu.PasswordChar = false;
            this.txttimkiemLichSu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txttimkiemLichSu.PlaceholderText = "";
            this.txttimkiemLichSu.Size = new System.Drawing.Size(191, 35);
            this.txttimkiemLichSu.TabIndex = 57;
            this.txttimkiemLichSu.Texts = "";
            this.txttimkiemLichSu.UnderlinedStyle = false;
            this.txttimkiemLichSu._TextChanged += new System.EventHandler(this.customTextBox1__TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(531, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tìm kiếm";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTongTienCacSP);
            this.tabPage2.Controls.Add(this.txtKtraText);
            this.tabPage2.Controls.Add(this.TableSanPham);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.errMessageSoluong);
            this.tabPage2.Controls.Add(this.errMessageTenLoai);
            this.tabPage2.Controls.Add(this.errMessageGia);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.customButton1);
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.txtTimKiem);
            this.tabPage2.Controls.Add(this.txtsoluongsp);
            this.tabPage2.Controls.Add(this.txtGia);
            this.tabPage2.Controls.Add(this.txtTen);
            this.tabPage2.Controls.Add(this.btnLammoi);
            this.tabPage2.Controls.Add(this.btnSua);
            this.tabPage2.Controls.Add(this.btnThem);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTongTienCacSP
            // 
            this.txtTongTienCacSP.AutoSize = true;
            this.txtTongTienCacSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienCacSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTongTienCacSP.Location = new System.Drawing.Point(786, 260);
            this.txtTongTienCacSP.Name = "txtTongTienCacSP";
            this.txtTongTienCacSP.Size = new System.Drawing.Size(0, 19);
            this.txtTongTienCacSP.TabIndex = 59;
            // 
            // txtKtraText
            // 
            this.txtKtraText.AutoSize = true;
            this.txtKtraText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKtraText.ForeColor = System.Drawing.Color.Red;
            this.txtKtraText.Location = new System.Drawing.Point(333, 182);
            this.txtKtraText.Name = "txtKtraText";
            this.txtKtraText.Size = new System.Drawing.Size(0, 16);
            this.txtKtraText.TabIndex = 56;
            // 
            // TableSanPham
            // 
            this.TableSanPham.BackgroundColor = System.Drawing.Color.White;
            this.TableSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSanPham.ContextMenuStrip = this.contextMenuStrip1;
            this.TableSanPham.Location = new System.Drawing.Point(173, 295);
            this.TableSanPham.Name = "TableSanPham";
            this.TableSanPham.RowHeadersWidth = 51;
            this.TableSanPham.RowTemplate.Height = 24;
            this.TableSanPham.Size = new System.Drawing.Size(676, 209);
            this.TableSanPham.TabIndex = 55;
            this.TableSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableSanPham_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(104, 24);
            this.delete.Text = "Xóa";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(212, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(307, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(212, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "giá";
            // 
            // errMessageSoluong
            // 
            this.errMessageSoluong.AutoSize = true;
            this.errMessageSoluong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMessageSoluong.ForeColor = System.Drawing.Color.Red;
            this.errMessageSoluong.Location = new System.Drawing.Point(332, 221);
            this.errMessageSoluong.Name = "errMessageSoluong";
            this.errMessageSoluong.Size = new System.Drawing.Size(0, 15);
            this.errMessageSoluong.TabIndex = 51;
            // 
            // errMessageTenLoai
            // 
            this.errMessageTenLoai.AutoSize = true;
            this.errMessageTenLoai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMessageTenLoai.ForeColor = System.Drawing.Color.Red;
            this.errMessageTenLoai.Location = new System.Drawing.Point(333, 108);
            this.errMessageTenLoai.Name = "errMessageTenLoai";
            this.errMessageTenLoai.Size = new System.Drawing.Size(0, 15);
            this.errMessageTenLoai.TabIndex = 51;
            // 
            // errMessageGia
            // 
            this.errMessageGia.AutoSize = true;
            this.errMessageGia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMessageGia.ForeColor = System.Drawing.Color.Red;
            this.errMessageGia.Location = new System.Drawing.Point(332, 165);
            this.errMessageGia.Name = "errMessageGia";
            this.errMessageGia.Size = new System.Drawing.Size(0, 15);
            this.errMessageGia.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(212, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tên loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(426, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 45;
            this.label1.Text = "Sản Phẩm";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(624, 247);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(116, 40);
            this.customButton1.TabIndex = 58;
            this.customButton1.Text = "Tổng tiền";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Red;
            this.btnExcel.BackgroundColor = System.Drawing.Color.Red;
            this.btnExcel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExcel.BorderRadius = 10;
            this.btnExcel.BorderSize = 0;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(764, 78);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(116, 42);
            this.btnExcel.TabIndex = 57;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.TextColor = System.Drawing.Color.White;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Fuchsia;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.BorderSize = 2;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Location = new System.Drawing.Point(404, 252);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(191, 35);
            this.txtTimKiem.TabIndex = 52;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            this.txtTimKiem._TextChanged += new System.EventHandler(this.txtTimKiem__TextChanged);
            // 
            // txtsoluongsp
            // 
            this.txtsoluongsp.BackColor = System.Drawing.SystemColors.Window;
            this.txtsoluongsp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtsoluongsp.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtsoluongsp.BorderRadius = 10;
            this.txtsoluongsp.BorderSize = 2;
            this.txtsoluongsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluongsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsoluongsp.Location = new System.Drawing.Point(311, 182);
            this.txtsoluongsp.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluongsp.Multiline = false;
            this.txtsoluongsp.Name = "txtsoluongsp";
            this.txtsoluongsp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtsoluongsp.PasswordChar = false;
            this.txtsoluongsp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtsoluongsp.PlaceholderText = "";
            this.txtsoluongsp.Size = new System.Drawing.Size(191, 35);
            this.txtsoluongsp.TabIndex = 53;
            this.txtsoluongsp.Texts = "";
            this.txtsoluongsp.UnderlinedStyle = false;
            this.txtsoluongsp._TextChanged += new System.EventHandler(this.txtsoluongsp__TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtGia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtGia.BorderRadius = 10;
            this.txtGia.BorderSize = 2;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGia.Location = new System.Drawing.Point(311, 125);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Multiline = false;
            this.txtGia.Name = "txtGia";
            this.txtGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGia.PasswordChar = false;
            this.txtGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGia.PlaceholderText = "";
            this.txtGia.Size = new System.Drawing.Size(191, 35);
            this.txtGia.TabIndex = 53;
            this.txtGia.Texts = "";
            this.txtGia.UnderlinedStyle = false;
            this.txtGia.Leave += new System.EventHandler(this.txtGia_Leave);
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtTen.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTen.BorderRadius = 10;
            this.txtTen.BorderSize = 2;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTen.Location = new System.Drawing.Point(311, 69);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Multiline = false;
            this.txtTen.Name = "txtTen";
            this.txtTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTen.PasswordChar = false;
            this.txtTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTen.PlaceholderText = "";
            this.txtTen.Size = new System.Drawing.Size(191, 35);
            this.txtTen.TabIndex = 54;
            this.txtTen.Texts = "";
            this.txtTen.UnderlinedStyle = false;
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLammoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLammoi.BorderColor = System.Drawing.Color.Aqua;
            this.btnLammoi.BorderRadius = 10;
            this.btnLammoi.BorderSize = 0;
            this.btnLammoi.FlatAppearance.BorderSize = 0;
            this.btnLammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLammoi.ForeColor = System.Drawing.Color.White;
            this.btnLammoi.Location = new System.Drawing.Point(624, 192);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(116, 40);
            this.btnLammoi.TabIndex = 46;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextColor = System.Drawing.Color.White;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.BorderColor = System.Drawing.Color.Aqua;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(624, 134);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 40);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.BorderColor = System.Drawing.Color.Aqua;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(624, 78);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 42);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 552);
            this.Controls.Add(this.tabControl1);
            this.Name = "Product";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Product_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLichSu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSanPham)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label txtKtraText;
        private System.Windows.Forms.DataGridView TableSanPham;
        private Controls.CustomTextBox txtTimKiem;
        private Controls.CustomTextBox txtGia;
        private Controls.CustomTextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Controls.customButton btnLammoi;
        private Controls.customButton btnSua;
        private Controls.customButton btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableLichSu;
        private Controls.CustomTextBox txttimkiemLichSu;
        private System.Windows.Forms.Label label5;
        private Controls.customButton btnExcel;
        private System.Windows.Forms.Panel panel1;
        private Controls.customButton customButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtTongGia;
        private System.Windows.Forms.Label label6;
        private Controls.CustomTextBox txtSoluong;
        private System.Windows.Forms.ComboBox cbxSanPham;
        private Controls.customButton customButton3;
        private Controls.CustomTextBox txtsoluongsp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.Label errMessageSoluong;
        private System.Windows.Forms.Label errMessageTenLoai;
        private System.Windows.Forms.Label errMessageGia;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label txtGiaTien;
        private System.Windows.Forms.Label errMessage;
        private System.Windows.Forms.Label txtTongTienCacSP;
        private Controls.customButton customButton1;
        private System.Windows.Forms.Label TxtThongBao;
        private System.Windows.Forms.Label txtSlSp;
        private System.Windows.Forms.Label txtMaSanPham;
        private System.Windows.Forms.Label label9;
    }
}