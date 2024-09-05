namespace HẹThongQuanLyNhanVien
{
    partial class DoanhThu
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.commandBarGalleryDropDown1 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.chartBarController1 = new DevExpress.XtraCharts.UI.ChartBarController(this.components);
            this.TableDoanhThu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customButton2 = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.btnExcel = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.txtThuongthem = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.btnCapNhat = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.txtTonhDoanhThu = new System.Windows.Forms.Label();
            this.ChartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbxdoanhthu = new System.Windows.Forms.ListBox();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lblktratext = new System.Windows.Forms.Label();
            this.btnLammoi = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtketQuaKichHoat = new System.Windows.Forms.Label();
            this.checkKichHoat = new System.Windows.Forms.CheckBox();
            this.btnKicHoat = new HẹThongQuanLyNhanVien.Controls.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // commandBarGalleryDropDown1
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown1.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.commandBarGalleryDropDown1.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.commandBarGalleryDropDown1.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.commandBarGalleryDropDown1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown1.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown1.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown1.Gallery.ShowItemImage = false;
            this.commandBarGalleryDropDown1.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown1.Manager = null;
            this.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1";
            // 
            // TableDoanhThu
            // 
            this.TableDoanhThu.AllowUserToAddRows = false;
            this.TableDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDoanhThu.Location = new System.Drawing.Point(3, 271);
            this.TableDoanhThu.Name = "TableDoanhThu";
            this.TableDoanhThu.RowHeadersWidth = 51;
            this.TableDoanhThu.RowTemplate.Height = 24;
            this.TableDoanhThu.Size = new System.Drawing.Size(670, 283);
            this.TableDoanhThu.TabIndex = 8;
            this.TableDoanhThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableDoanhThu_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thưởng thêm";
            // 
            // txtKetQua
            // 
            this.txtKetQua.AutoSize = true;
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua.Location = new System.Drawing.Point(21, 20);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(0, 25);
            this.txtKetQua.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Tomato;
            this.customButton2.BackgroundColor = System.Drawing.Color.Tomato;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 16;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(520, 123);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(123, 39);
            this.customButton2.TabIndex = 12;
            this.customButton2.Text = "Xuất PDF";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExcel.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcel.BorderRadius = 16;
            this.btnExcel.BorderSize = 0;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(520, 64);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(123, 39);
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "Xuất Excels";
            this.btnExcel.TextColor = System.Drawing.Color.White;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtThuongthem
            // 
            this.txtThuongthem.BackColor = System.Drawing.SystemColors.Window;
            this.txtThuongthem.BorderColor = System.Drawing.Color.YellowGreen;
            this.txtThuongthem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtThuongthem.BorderRadius = 14;
            this.txtThuongthem.BorderSize = 3;
            this.txtThuongthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuongthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThuongthem.Location = new System.Drawing.Point(94, 64);
            this.txtThuongthem.Margin = new System.Windows.Forms.Padding(4);
            this.txtThuongthem.Multiline = false;
            this.txtThuongthem.Name = "txtThuongthem";
            this.txtThuongthem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtThuongthem.PasswordChar = false;
            this.txtThuongthem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtThuongthem.PlaceholderText = "";
            this.txtThuongthem.Size = new System.Drawing.Size(180, 35);
            this.txtThuongthem.TabIndex = 10;
            this.txtThuongthem.Texts = "";
            this.txtThuongthem.UnderlinedStyle = false;
            this.txtThuongthem._TextChanged += new System.EventHandler(this.txtThuongthem__TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnCapNhat.BorderColor = System.Drawing.Color.Lime;
            this.btnCapNhat.BorderRadius = 16;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(98, 123);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(176, 41);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextColor = System.Drawing.Color.White;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTonhDoanhThu
            // 
            this.txtTonhDoanhThu.AutoSize = true;
            this.txtTonhDoanhThu.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonhDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTonhDoanhThu.Location = new System.Drawing.Point(230, 202);
            this.txtTonhDoanhThu.Name = "txtTonhDoanhThu";
            this.txtTonhDoanhThu.Size = new System.Drawing.Size(144, 25);
            this.txtTonhDoanhThu.TabIndex = 9;
            this.txtTonhDoanhThu.Text = "Thưởng thêm";
            // 
            // ChartDoanhThu
            // 
            this.ChartDoanhThu.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.ChartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartDoanhThu.Legends.Add(legend1);
            this.ChartDoanhThu.Location = new System.Drawing.Point(679, 12);
            this.ChartDoanhThu.Name = "ChartDoanhThu";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.YValuesPerPoint = 4;
            this.ChartDoanhThu.Series.Add(series1);
            this.ChartDoanhThu.Size = new System.Drawing.Size(318, 539);
            this.ChartDoanhThu.TabIndex = 13;
            this.ChartDoanhThu.Text = "chart1";
            // 
            // lbxdoanhthu
            // 
            this.lbxdoanhthu.FormattingEnabled = true;
            this.lbxdoanhthu.ItemHeight = 16;
            this.lbxdoanhthu.Location = new System.Drawing.Point(281, 56);
            this.lbxdoanhthu.Name = "lbxdoanhthu";
            this.lbxdoanhthu.Size = new System.Drawing.Size(233, 132);
            this.lbxdoanhthu.TabIndex = 14;
            this.lbxdoanhthu.SelectedIndexChanged += new System.EventHandler(this.lbxdoanhthu_SelectedIndexChanged);
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.ForeColor = System.Drawing.Color.Red;
            this.lblmanv.Location = new System.Drawing.Point(388, 39);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(0, 16);
            this.lblmanv.TabIndex = 15;
            // 
            // lblktratext
            // 
            this.lblktratext.AutoSize = true;
            this.lblktratext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblktratext.ForeColor = System.Drawing.Color.Red;
            this.lblktratext.Location = new System.Drawing.Point(118, 104);
            this.lblktratext.Name = "lblktratext";
            this.lblktratext.Size = new System.Drawing.Size(0, 16);
            this.lblktratext.TabIndex = 16;
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.Gold;
            this.btnLammoi.BackgroundColor = System.Drawing.Color.Gold;
            this.btnLammoi.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnLammoi.BorderRadius = 16;
            this.btnLammoi.BorderSize = 0;
            this.btnLammoi.FlatAppearance.BorderSize = 0;
            this.btnLammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLammoi.ForeColor = System.Drawing.Color.White;
            this.btnLammoi.Location = new System.Drawing.Point(520, 188);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(123, 39);
            this.btnLammoi.TabIndex = 17;
            this.btnLammoi.Text = "làm mới nhân viên";
            this.btnLammoi.TextColor = System.Drawing.Color.White;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "cập nhật ngày đi làm nghày nghỉ và lương,tông lương về ban đầu ";
            // 
            // txtketQuaKichHoat
            // 
            this.txtketQuaKichHoat.AutoSize = true;
            this.txtketQuaKichHoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketQuaKichHoat.ForeColor = System.Drawing.Color.Red;
            this.txtketQuaKichHoat.Location = new System.Drawing.Point(398, 20);
            this.txtketQuaKichHoat.Name = "txtketQuaKichHoat";
            this.txtketQuaKichHoat.Size = new System.Drawing.Size(0, 20);
            this.txtketQuaKichHoat.TabIndex = 19;
            // 
            // checkKichHoat
            // 
            this.checkKichHoat.AutoSize = true;
            this.checkKichHoat.BackColor = System.Drawing.Color.White;
            this.checkKichHoat.Location = new System.Drawing.Point(242, 20);
            this.checkKichHoat.Name = "checkKichHoat";
            this.checkKichHoat.Size = new System.Drawing.Size(132, 20);
            this.checkKichHoat.TabIndex = 20;
            this.checkKichHoat.Text = "Tự động làm mới ";
            this.checkKichHoat.UseVisualStyleBackColor = false;
            // 
            // btnKicHoat
            // 
            this.btnKicHoat.BackColor = System.Drawing.Color.Red;
            this.btnKicHoat.BackgroundColor = System.Drawing.Color.Red;
            this.btnKicHoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKicHoat.BorderRadius = 15;
            this.btnKicHoat.BorderSize = 0;
            this.btnKicHoat.FlatAppearance.BorderSize = 0;
            this.btnKicHoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKicHoat.ForeColor = System.Drawing.Color.White;
            this.btnKicHoat.Location = new System.Drawing.Point(173, 5);
            this.btnKicHoat.Name = "btnKicHoat";
            this.btnKicHoat.Size = new System.Drawing.Size(63, 48);
            this.btnKicHoat.TabIndex = 21;
            this.btnKicHoat.Text = "Chấp nhận";
            this.btnKicHoat.TextColor = System.Drawing.Color.White;
            this.btnKicHoat.UseVisualStyleBackColor = false;
            this.btnKicHoat.Click += new System.EventHandler(this.btnKicHoat_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 552);
            this.Controls.Add(this.btnKicHoat);
            this.Controls.Add(this.checkKichHoat);
            this.Controls.Add(this.txtketQuaKichHoat);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.ChartDoanhThu);
            this.Controls.Add(this.lblktratext);
            this.Controls.Add(this.lblmanv);
            this.Controls.Add(this.lbxdoanhthu);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtThuongthem);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtTonhDoanhThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableDoanhThu);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown1;
        private DevExpress.XtraCharts.UI.ChartBarController chartBarController1;
        private Controls.customButton btnCapNhat;
        private System.Windows.Forms.DataGridView TableDoanhThu;
        private System.Windows.Forms.Label label1;
        private Controls.CustomTextBox txtThuongthem;
        private Controls.customButton btnExcel;
        private Controls.customButton customButton2;
        private System.Windows.Forms.Label txtKetQua;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtTonhDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDoanhThu;
        private System.Windows.Forms.ListBox lbxdoanhthu;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lblktratext;
        private Controls.customButton btnLammoi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label txtketQuaKichHoat;
        private System.Windows.Forms.CheckBox checkKichHoat;
        private Controls.customButton btnKicHoat;
    }
}