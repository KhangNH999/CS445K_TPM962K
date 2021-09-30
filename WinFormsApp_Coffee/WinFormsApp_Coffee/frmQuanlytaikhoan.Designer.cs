
namespace WinFormsApp_Coffee
{
    partial class frmQuanlytaikhoan
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
            this.dgvQuanlytaikhoan = new System.Windows.Forms.DataGridView();
            this.btnKhoatk = new System.Windows.Forms.Button();
            this.btnXoatk = new System.Windows.Forms.Button();
            this.btnSuatk = new System.Windows.Forms.Button();
            this.btnThemtk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMataikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ccbTrangthaitk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccbLoaitk = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlytaikhoan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanlytaikhoan
            // 
            this.dgvQuanlytaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlytaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvQuanlytaikhoan.Location = new System.Drawing.Point(0, 3);
            this.dgvQuanlytaikhoan.Name = "dgvQuanlytaikhoan";
            this.dgvQuanlytaikhoan.RowHeadersWidth = 62;
            this.dgvQuanlytaikhoan.RowTemplate.Height = 33;
            this.dgvQuanlytaikhoan.Size = new System.Drawing.Size(1384, 800);
            this.dgvQuanlytaikhoan.TabIndex = 0;
            this.dgvQuanlytaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlytaikhoan_CellClick);
            // 
            // btnKhoatk
            // 
            this.btnKhoatk.Location = new System.Drawing.Point(496, 5);
            this.btnKhoatk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKhoatk.Name = "btnKhoatk";
            this.btnKhoatk.Size = new System.Drawing.Size(156, 78);
            this.btnKhoatk.TabIndex = 3;
            this.btnKhoatk.Text = "Khóa tài khoản";
            this.btnKhoatk.UseVisualStyleBackColor = true;
            // 
            // btnXoatk
            // 
            this.btnXoatk.Location = new System.Drawing.Point(333, 3);
            this.btnXoatk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(156, 78);
            this.btnXoatk.TabIndex = 2;
            this.btnXoatk.Text = "Xóa tài khoản";
            this.btnXoatk.UseVisualStyleBackColor = true;
            this.btnXoatk.Click += new System.EventHandler(this.btnXoatk_Click);
            // 
            // btnSuatk
            // 
            this.btnSuatk.Location = new System.Drawing.Point(169, 5);
            this.btnSuatk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSuatk.Name = "btnSuatk";
            this.btnSuatk.Size = new System.Drawing.Size(156, 78);
            this.btnSuatk.TabIndex = 1;
            this.btnSuatk.Text = "Sửa tài khoản";
            this.btnSuatk.UseVisualStyleBackColor = true;
            this.btnSuatk.Click += new System.EventHandler(this.btnSuatk_Click);
            // 
            // btnThemtk
            // 
            this.btnThemtk.Location = new System.Drawing.Point(6, 3);
            this.btnThemtk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemtk.Name = "btnThemtk";
            this.btnThemtk.Size = new System.Drawing.Size(156, 78);
            this.btnThemtk.TabIndex = 0;
            this.btnThemtk.Text = "Thêm tài khoản";
            this.btnThemtk.UseVisualStyleBackColor = true;
            this.btnThemtk.Click += new System.EventHandler(this.btnThemdouong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlytaikhoan);
            this.panel2.Location = new System.Drawing.Point(13, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 797);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoatk);
            this.panel1.Controls.Add(this.btnXoatk);
            this.panel1.Controls.Add(this.btnSuatk);
            this.panel1.Controls.Add(this.btnThemtk);
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 87);
            this.panel1.TabIndex = 5;
            // 
            // txtMataikhoan
            // 
            this.txtMataikhoan.Location = new System.Drawing.Point(156, 17);
            this.txtMataikhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMataikhoan.Name = "txtMataikhoan";
            this.txtMataikhoan.Size = new System.Drawing.Size(235, 31);
            this.txtMataikhoan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DateNgaysinh);
            this.panel3.Controls.Add(this.txtSdt);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtCmnd);
            this.panel3.Controls.Add(this.txtGioitinh);
            this.panel3.Controls.Add(this.txtTen);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ccbTrangthaitk);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ccbLoaitk);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtMatkhau);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtMataikhoan);
            this.panel3.Controls.Add(this.txtTendangnhap);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1401, 113);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 797);
            this.panel3.TabIndex = 7;
            // 
            // DateNgaysinh
            // 
            this.DateNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.DateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNgaysinh.Location = new System.Drawing.Point(151, 275);
            this.DateNgaysinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateNgaysinh.Name = "DateNgaysinh";
            this.DateNgaysinh.Size = new System.Drawing.Size(240, 31);
            this.DateNgaysinh.TabIndex = 27;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(154, 537);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(237, 31);
            this.txtSdt.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 468);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 31);
            this.txtEmail.TabIndex = 25;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(154, 402);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(237, 31);
            this.txtCmnd.TabIndex = 24;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(154, 338);
            this.txtGioitinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(237, 31);
            this.txtGioitinh.TabIndex = 23;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(154, 210);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(237, 31);
            this.txtTen.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 540);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Số điện thoại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 473);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 405);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "CMND:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên:";
            // 
            // ccbTrangthaitk
            // 
            this.ccbTrangthaitk.FormattingEnabled = true;
            this.ccbTrangthaitk.Items.AddRange(new object[] {
            "Bình thường",
            "Khóa"});
            this.ccbTrangthaitk.Location = new System.Drawing.Point(154, 673);
            this.ccbTrangthaitk.Name = "ccbTrangthaitk";
            this.ccbTrangthaitk.Size = new System.Drawing.Size(237, 33);
            this.ccbTrangthaitk.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 677);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái:";
            // 
            // ccbLoaitk
            // 
            this.ccbLoaitk.FormattingEnabled = true;
            this.ccbLoaitk.Location = new System.Drawing.Point(154, 603);
            this.ccbLoaitk.Name = "ccbLoaitk";
            this.ccbLoaitk.Size = new System.Drawing.Size(237, 33);
            this.ccbLoaitk.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 607);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại tài khoản:";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(154, 140);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(237, 31);
            this.txtMatkhau.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(156, 77);
            this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(235, 31);
            this.txtTendangnhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTaiKhoan";
            this.Column1.HeaderText = "Mã tài khoản";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDangNhap";
            this.Column2.HeaderText = "Tên đăng nhập";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatKhau";
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenNV";
            this.Column4.HeaderText = "Tên nhân viên";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GioiTinh";
            this.Column6.HeaderText = "Giới tính";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CMND";
            this.Column7.HeaderText = "CMND";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Email";
            this.Column8.HeaderText = "Email";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SDT";
            this.Column9.HeaderText = "Số đt";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Loaitk";
            this.Column10.HeaderText = "Loại tk";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TrangThaiTK";
            this.Column11.HeaderText = "Trạng thái";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // frmQuanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuanlytaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlytaikhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanlytaikhoan;
        private System.Windows.Forms.Button btnKhoatk;
        private System.Windows.Forms.Button btnXoatk;
        private System.Windows.Forms.Button btnSuatk;
        private System.Windows.Forms.Button btnThemtk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMataikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ccbLoaitk;
        private System.Windows.Forms.ComboBox ccbTrangthaitk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}