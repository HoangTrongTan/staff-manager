namespace HẹThongQuanLyNhanVien
{
    partial class LichSu
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
            this.TableLichSu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxthoigian = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioTen = new System.Windows.Forms.RadioButton();
            this.radioMa = new System.Windows.Forms.RadioButton();
            this.txtketqua = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnPdf = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.btnXuatExcels = new HẹThongQuanLyNhanVien.Controls.customButton();
            this.txtTimKiem = new HẹThongQuanLyNhanVien.Controls.CustomTextBox();
            this.btnXoaLichSu = new HẹThongQuanLyNhanVien.Controls.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLichSu
            // 
            this.TableLichSu.AllowUserToAddRows = false;
            this.TableLichSu.BackgroundColor = System.Drawing.Color.White;
            this.TableLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLichSu.Location = new System.Drawing.Point(50, 248);
            this.TableLichSu.Name = "TableLichSu";
            this.TableLichSu.RowHeadersWidth = 51;
            this.TableLichSu.RowTemplate.Height = 24;
            this.TableLichSu.Size = new System.Drawing.Size(917, 285);
            this.TableLichSu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(386, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch sử làm việc";
            // 
            // cbxthoigian
            // 
            this.cbxthoigian.FormattingEnabled = true;
            this.cbxthoigian.Location = new System.Drawing.Point(755, 211);
            this.cbxthoigian.Name = "cbxthoigian";
            this.cbxthoigian.Size = new System.Drawing.Size(171, 24);
            this.cbxthoigian.TabIndex = 4;
            this.cbxthoigian.SelectedIndexChanged += new System.EventHandler(this.cbxthoigian_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(686, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(393, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm kiếm";
            // 
            // radioTen
            // 
            this.radioTen.AutoSize = true;
            this.radioTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioTen.Location = new System.Drawing.Point(462, 180);
            this.radioTen.Name = "radioTen";
            this.radioTen.Size = new System.Drawing.Size(52, 20);
            this.radioTen.TabIndex = 5;
            this.radioTen.TabStop = true;
            this.radioTen.Text = "Tên";
            this.radioTen.UseVisualStyleBackColor = true;
            // 
            // radioMa
            // 
            this.radioMa.AutoSize = true;
            this.radioMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioMa.Location = new System.Drawing.Point(462, 154);
            this.radioMa.Name = "radioMa";
            this.radioMa.Size = new System.Drawing.Size(47, 20);
            this.radioMa.TabIndex = 5;
            this.radioMa.TabStop = true;
            this.radioMa.Text = "Mã";
            this.radioMa.UseVisualStyleBackColor = true;
            // 
            // txtketqua
            // 
            this.txtketqua.AutoSize = true;
            this.txtketqua.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketqua.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtketqua.Location = new System.Drawing.Point(7, 9);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(0, 32);
            this.txtketqua.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPdf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPdf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPdf.BorderRadius = 10;
            this.btnPdf.BorderSize = 0;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(171, 78);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(150, 45);
            this.btnPdf.TabIndex = 7;
            this.btnPdf.Text = "Xuất PDF";
            this.btnPdf.TextColor = System.Drawing.Color.White;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnXuatExcels
            // 
            this.btnXuatExcels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcels.BorderColor = System.Drawing.Color.Lime;
            this.btnXuatExcels.BorderRadius = 10;
            this.btnXuatExcels.BorderSize = 0;
            this.btnXuatExcels.FlatAppearance.BorderSize = 0;
            this.btnXuatExcels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcels.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcels.Location = new System.Drawing.Point(171, 140);
            this.btnXuatExcels.Name = "btnXuatExcels";
            this.btnXuatExcels.Size = new System.Drawing.Size(152, 42);
            this.btnXuatExcels.TabIndex = 6;
            this.btnXuatExcels.Text = "Xuất Excels";
            this.btnXuatExcels.TextColor = System.Drawing.Color.White;
            this.btnXuatExcels.UseVisualStyleBackColor = false;
            this.btnXuatExcels.Click += new System.EventHandler(this.btnXuatExcels_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Blue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.BorderSize = 2;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Location = new System.Drawing.Point(462, 206);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(161, 35);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            this.txtTimKiem._TextChanged += new System.EventHandler(this.customTextBox1__TextChanged);
            // 
            // btnXoaLichSu
            // 
            this.btnXoaLichSu.BackColor = System.Drawing.Color.Red;
            this.btnXoaLichSu.BackgroundColor = System.Drawing.Color.Red;
            this.btnXoaLichSu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaLichSu.BorderRadius = 10;
            this.btnXoaLichSu.BorderSize = 0;
            this.btnXoaLichSu.FlatAppearance.BorderSize = 0;
            this.btnXoaLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLichSu.ForeColor = System.Drawing.Color.White;
            this.btnXoaLichSu.Location = new System.Drawing.Point(171, 196);
            this.btnXoaLichSu.Name = "btnXoaLichSu";
            this.btnXoaLichSu.Size = new System.Drawing.Size(152, 45);
            this.btnXoaLichSu.TabIndex = 2;
            this.btnXoaLichSu.Text = "Xóa Lịch Sử";
            this.btnXoaLichSu.TextColor = System.Drawing.Color.White;
            this.btnXoaLichSu.UseVisualStyleBackColor = false;
            this.btnXoaLichSu.Click += new System.EventHandler(this.btnXoaLichSu_Click);
            // 
            // LichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 547);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnXuatExcels);
            this.Controls.Add(this.radioMa);
            this.Controls.Add(this.radioTen);
            this.Controls.Add(this.cbxthoigian);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoaLichSu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableLichSu);
            this.Name = "LichSu";
            this.Text = "LichSu";
            this.Load += new System.EventHandler(this.LichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableLichSu;
        private System.Windows.Forms.Label label1;
        private Controls.customButton btnXoaLichSu;
        private Controls.CustomTextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbxthoigian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioTen;
        private System.Windows.Forms.RadioButton radioMa;
        private System.Windows.Forms.Label txtketqua;
        private System.Windows.Forms.Timer timer;
        private Controls.customButton btnXuatExcels;
        private Controls.customButton btnPdf;
    }
}