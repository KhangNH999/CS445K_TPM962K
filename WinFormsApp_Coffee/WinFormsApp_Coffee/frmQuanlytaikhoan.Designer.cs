
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
            this.ccbTrangthaitk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccbLoaitk = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNgaysinh = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlytaikhoan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanlytaikhoan
            // 
            this.dgvQuanlytaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlytaikhoan.Location = new System.Drawing.Point(5, 2);
            this.dgvQuanlytaikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanlytaikhoan.Name = "dgvQuanlytaikhoan";
            this.dgvQuanlytaikhoan.RowHeadersWidth = 62;
            this.dgvQuanlytaikhoan.RowTemplate.Height = 33;
            this.dgvQuanlytaikhoan.Size = new System.Drawing.Size(532, 633);
            this.dgvQuanlytaikhoan.TabIndex = 0;
            // 
            // btnKhoatk
            // 
            this.btnKhoatk.Location = new System.Drawing.Point(397, 4);
            this.btnKhoatk.Name = "btnKhoatk";
            this.btnKhoatk.Size = new System.Drawing.Size(125, 63);
            this.btnKhoatk.TabIndex = 3;
            this.btnKhoatk.Text = "Khóa tài khoản";
            this.btnKhoatk.UseVisualStyleBackColor = true;
            // 
            // btnXoatk
            // 
            this.btnXoatk.Location = new System.Drawing.Point(266, 3);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(125, 63);
            this.btnXoatk.TabIndex = 2;
            this.btnXoatk.Text = "Xóa tài khoản";
            this.btnXoatk.UseVisualStyleBackColor = true;
            // 
            // btnSuatk
            // 
            this.btnSuatk.Location = new System.Drawing.Point(135, 4);
            this.btnSuatk.Name = "btnSuatk";
            this.btnSuatk.Size = new System.Drawing.Size(125, 63);
            this.btnSuatk.TabIndex = 1;
            this.btnSuatk.Text = "Sửa tài khoản";
            this.btnSuatk.UseVisualStyleBackColor = true;
            // 
            // btnThemtk
            // 
            this.btnThemtk.Location = new System.Drawing.Point(4, 3);
            this.btnThemtk.Name = "btnThemtk";
            this.btnThemtk.Size = new System.Drawing.Size(125, 63);
            this.btnThemtk.TabIndex = 0;
            this.btnThemtk.Text = "Thêm tài khoản";
            this.btnThemtk.UseVisualStyleBackColor = true;
            this.btnThemtk.Click += new System.EventHandler(this.btnThemdouong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlytaikhoan);
            this.panel2.Location = new System.Drawing.Point(10, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 637);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoatk);
            this.panel1.Controls.Add(this.btnXoatk);
            this.panel1.Controls.Add(this.btnSuatk);
            this.panel1.Controls.Add(this.btnThemtk);
            this.panel1.Location = new System.Drawing.Point(11, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 70);
            this.panel1.TabIndex = 5;
            // 
            // txtMataikhoan
            // 
            this.txtMataikhoan.Location = new System.Drawing.Point(125, 13);
            this.txtMataikhoan.Name = "txtMataikhoan";
            this.txtMataikhoan.Size = new System.Drawing.Size(189, 27);
            this.txtMataikhoan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSdt);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtCmnd);
            this.panel3.Controls.Add(this.txtGioitinh);
            this.panel3.Controls.Add(this.txtNgaysinh);
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
            this.panel3.Location = new System.Drawing.Point(557, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 637);
            this.panel3.TabIndex = 7;
            // 
            // ccbTrangthaitk
            // 
            this.ccbTrangthaitk.FormattingEnabled = true;
            this.ccbTrangthaitk.Location = new System.Drawing.Point(124, 538);
            this.ccbTrangthaitk.Margin = new System.Windows.Forms.Padding(2);
            this.ccbTrangthaitk.Name = "ccbTrangthaitk";
            this.ccbTrangthaitk.Size = new System.Drawing.Size(190, 28);
            this.ccbTrangthaitk.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái:";
            // 
            // ccbLoaitk
            // 
            this.ccbLoaitk.FormattingEnabled = true;
            this.ccbLoaitk.Location = new System.Drawing.Point(124, 483);
            this.ccbLoaitk.Margin = new System.Windows.Forms.Padding(2);
            this.ccbLoaitk.Name = "ccbLoaitk";
            this.ccbLoaitk.Size = new System.Drawing.Size(190, 28);
            this.ccbLoaitk.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại tài khoản:";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(124, 112);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(190, 27);
            this.txtMatkhau.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(125, 62);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(189, 27);
            this.txtTendangnhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giới tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "CMND:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Số điện thoại:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(124, 168);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(190, 27);
            this.txtTen.TabIndex = 21;
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Location = new System.Drawing.Point(124, 217);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(190, 27);
            this.txtNgaysinh.TabIndex = 22;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(124, 268);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(190, 27);
            this.txtGioitinh.TabIndex = 23;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(124, 321);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(190, 27);
            this.txtCmnd.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 375);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 27);
            this.txtEmail.TabIndex = 25;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(124, 429);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(190, 27);
            this.txtSdt.TabIndex = 26;
            // 
            // frmQuanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 739);
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
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}