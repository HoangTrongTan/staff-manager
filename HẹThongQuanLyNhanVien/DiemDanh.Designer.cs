namespace HẹThongQuanLyNhanVien
{
    partial class DiemDanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNV_lietke = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TableDiemDanh = new System.Windows.Forms.DataGridView();
            this.vang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThoiGian = new System.Windows.Forms.Label();
            this.TableVang = new System.Windows.Forms.DataGridView();
            this.btnDiemDanh = new HẹThongQuanLyNhanVien.Controls.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableDiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableVang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNV_lietke
            // 
            this.txtNV_lietke.AutoSize = true;
            this.txtNV_lietke.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNV_lietke.ForeColor = System.Drawing.Color.Red;
            this.txtNV_lietke.Location = new System.Drawing.Point(512, 21);
            this.txtNV_lietke.Name = "txtNV_lietke";
            this.txtNV_lietke.Size = new System.Drawing.Size(0, 19);
            this.txtNV_lietke.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(171, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "Điểm Danh";
            // 
            // TableDiemDanh
            // 
            this.TableDiemDanh.AllowUserToAddRows = false;
            this.TableDiemDanh.BackgroundColor = System.Drawing.Color.White;
            this.TableDiemDanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableDiemDanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vang,
            this.LyDo});
            this.TableDiemDanh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TableDiemDanh.Location = new System.Drawing.Point(24, 314);
            this.TableDiemDanh.Name = "TableDiemDanh";
            this.TableDiemDanh.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TableDiemDanh.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TableDiemDanh.RowTemplate.Height = 24;
            this.TableDiemDanh.Size = new System.Drawing.Size(779, 221);
            this.TableDiemDanh.TabIndex = 5;
            // 
            // vang
            // 
            this.vang.HeaderText = "Vắng";
            this.vang.MinimumWidth = 6;
            this.vang.Name = "vang";
            this.vang.Width = 125;
            // 
            // LyDo
            // 
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 125;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.AutoSize = true;
            this.txtThoiGian.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.ForeColor = System.Drawing.Color.Red;
            this.txtThoiGian.Location = new System.Drawing.Point(348, 21);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(128, 19);
            this.txtThoiGian.TabIndex = 2;
            this.txtThoiGian.Text = "Số nhân viên vắng";
            // 
            // TableVang
            // 
            this.TableVang.BackgroundColor = System.Drawing.Color.White;
            this.TableVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableVang.Location = new System.Drawing.Point(114, 57);
            this.TableVang.Name = "TableVang";
            this.TableVang.RowHeadersWidth = 51;
            this.TableVang.RowTemplate.Height = 24;
            this.TableVang.Size = new System.Drawing.Size(471, 197);
            this.TableVang.TabIndex = 7;
            this.TableVang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableVang_CellClick);
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.BackColor = System.Drawing.Color.Lime;
            this.btnDiemDanh.BackgroundColor = System.Drawing.Color.Lime;
            this.btnDiemDanh.BorderColor = System.Drawing.Color.Aqua;
            this.btnDiemDanh.BorderRadius = 10;
            this.btnDiemDanh.BorderSize = 0;
            this.btnDiemDanh.FlatAppearance.BorderSize = 0;
            this.btnDiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemDanh.ForeColor = System.Drawing.Color.White;
            this.btnDiemDanh.Location = new System.Drawing.Point(287, 260);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Size = new System.Drawing.Size(114, 36);
            this.btnDiemDanh.TabIndex = 1;
            this.btnDiemDanh.Text = "Điểm Danh";
            this.btnDiemDanh.TextColor = System.Drawing.Color.White;
            this.btnDiemDanh.UseVisualStyleBackColor = false;
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 547);
            this.Controls.Add(this.TableVang);
            this.Controls.Add(this.TableDiemDanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.txtNV_lietke);
            this.Controls.Add(this.btnDiemDanh);
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "DiemDanh";
            this.Text = "DiemDanh";
            this.Load += new System.EventHandler(this.DiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableDiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableVang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.customButton btnDiemDanh;
        private System.Windows.Forms.Label txtNV_lietke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TableDiemDanh;
        private System.Windows.Forms.Label txtThoiGian;
        private System.Windows.Forms.DataGridView TableVang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
    }
}