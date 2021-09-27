
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlytaikhoan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanlytaikhoan
            // 
            this.dgvQuanlytaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlytaikhoan.Location = new System.Drawing.Point(0, 2);
            this.dgvQuanlytaikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanlytaikhoan.Name = "dgvQuanlytaikhoan";
            this.dgvQuanlytaikhoan.RowHeadersWidth = 62;
            this.dgvQuanlytaikhoan.RowTemplate.Height = 33;
            this.dgvQuanlytaikhoan.Size = new System.Drawing.Size(969, 480);
            this.dgvQuanlytaikhoan.TabIndex = 0;
            this.dgvQuanlytaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlytaikhoan_CellClick);
            // 
            // btnKhoatk
            // 
            this.btnKhoatk.Location = new System.Drawing.Point(347, 3);
            this.btnKhoatk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoatk.Name = "btnKhoatk";
            this.btnKhoatk.Size = new System.Drawing.Size(109, 47);
            this.btnKhoatk.TabIndex = 3;
            this.btnKhoatk.Text = "Khóa tài khoản";
            this.btnKhoatk.UseVisualStyleBackColor = true;
            // 
            // btnXoatk
            // 
            this.btnXoatk.Location = new System.Drawing.Point(233, 2);
            this.btnXoatk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(109, 47);
            this.btnXoatk.TabIndex = 2;
            this.btnXoatk.Text = "Xóa tài khoản";
            this.btnXoatk.UseVisualStyleBackColor = true;
            this.btnXoatk.Click += new System.EventHandler(this.btnXoatk_Click);
            // 
            // btnSuatk
            // 
            this.btnSuatk.Location = new System.Drawing.Point(118, 3);
            this.btnSuatk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuatk.Name = "btnSuatk";
            this.btnSuatk.Size = new System.Drawing.Size(109, 47);
            this.btnSuatk.TabIndex = 1;
            this.btnSuatk.Text = "Sửa tài khoản";
            this.btnSuatk.UseVisualStyleBackColor = true;
            this.btnSuatk.Click += new System.EventHandler(this.btnSuatk_Click);
            // 
            // btnThemtk
            // 
            this.btnThemtk.Location = new System.Drawing.Point(4, 2);
            this.btnThemtk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemtk.Name = "btnThemtk";
            this.btnThemtk.Size = new System.Drawing.Size(109, 47);
            this.btnThemtk.TabIndex = 0;
            this.btnThemtk.Text = "Thêm tài khoản";
            this.btnThemtk.UseVisualStyleBackColor = true;
            this.btnThemtk.Click += new System.EventHandler(this.btnThemdouong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlytaikhoan);
            this.panel2.Location = new System.Drawing.Point(9, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 478);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoatk);
            this.panel1.Controls.Add(this.btnXoatk);
            this.panel1.Controls.Add(this.btnSuatk);
            this.panel1.Controls.Add(this.btnThemtk);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 52);
            this.panel1.TabIndex = 5;
            // 
            // txtMataikhoan
            // 
            this.txtMataikhoan.Location = new System.Drawing.Point(109, 10);
            this.txtMataikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMataikhoan.Name = "txtMataikhoan";
            this.txtMataikhoan.Size = new System.Drawing.Size(166, 23);
            this.txtMataikhoan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
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
            this.panel3.Location = new System.Drawing.Point(981, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 478);
            this.panel3.TabIndex = 7;
            // 
            // DateNgaysinh
            // 
            this.DateNgaysinh.Location = new System.Drawing.Point(106, 165);
            this.DateNgaysinh.Name = "DateNgaysinh";
            this.DateNgaysinh.Size = new System.Drawing.Size(169, 23);
            this.DateNgaysinh.TabIndex = 27;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(108, 322);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(167, 23);
            this.txtSdt.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 281);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 23);
            this.txtEmail.TabIndex = 25;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(108, 241);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(167, 23);
            this.txtCmnd.TabIndex = 24;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(108, 203);
            this.txtGioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(167, 23);
            this.txtGioitinh.TabIndex = 23;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(108, 126);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(167, 23);
            this.txtTen.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Số điện thoại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "CMND:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên:";
            // 
            // ccbTrangthaitk
            // 
            this.ccbTrangthaitk.FormattingEnabled = true;
            this.ccbTrangthaitk.Location = new System.Drawing.Point(108, 404);
            this.ccbTrangthaitk.Margin = new System.Windows.Forms.Padding(2);
            this.ccbTrangthaitk.Name = "ccbTrangthaitk";
            this.ccbTrangthaitk.Size = new System.Drawing.Size(167, 23);
            this.ccbTrangthaitk.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái:";
            // 
            // ccbLoaitk
            // 
            this.ccbLoaitk.FormattingEnabled = true;
            this.ccbLoaitk.Location = new System.Drawing.Point(108, 362);
            this.ccbLoaitk.Margin = new System.Windows.Forms.Padding(2);
            this.ccbLoaitk.Name = "ccbLoaitk";
            this.ccbLoaitk.Size = new System.Drawing.Size(167, 23);
            this.ccbLoaitk.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại tài khoản:";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(108, 84);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(167, 23);
            this.txtMatkhau.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(109, 46);
            this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(166, 23);
            this.txtTendangnhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // frmQuanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}