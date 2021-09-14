
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
            this.btnKhoadouong = new System.Windows.Forms.Button();
            this.btnXoadouong = new System.Windows.Forms.Button();
            this.btnSuadouong = new System.Windows.Forms.Button();
            this.btnThemdouong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttentk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbTThai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLoaitk = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSocmnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenht = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlytaikhoan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanlytaikhoan
            // 
            this.dgvQuanlytaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlytaikhoan.Location = new System.Drawing.Point(5, 2);
            this.dgvQuanlytaikhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQuanlytaikhoan.Name = "dgvQuanlytaikhoan";
            this.dgvQuanlytaikhoan.RowHeadersWidth = 62;
            this.dgvQuanlytaikhoan.RowTemplate.Height = 33;
            this.dgvQuanlytaikhoan.Size = new System.Drawing.Size(532, 628);
            this.dgvQuanlytaikhoan.TabIndex = 0;
            // 
            // btnKhoadouong
            // 
            this.btnKhoadouong.Location = new System.Drawing.Point(397, 4);
            this.btnKhoadouong.Name = "btnKhoadouong";
            this.btnKhoadouong.Size = new System.Drawing.Size(125, 63);
            this.btnKhoadouong.TabIndex = 3;
            this.btnKhoadouong.Text = "Khóa tài khoản";
            this.btnKhoadouong.UseVisualStyleBackColor = true;
            // 
            // btnXoadouong
            // 
            this.btnXoadouong.Location = new System.Drawing.Point(266, 3);
            this.btnXoadouong.Name = "btnXoadouong";
            this.btnXoadouong.Size = new System.Drawing.Size(125, 63);
            this.btnXoadouong.TabIndex = 2;
            this.btnXoadouong.Text = "Xóa tài khoản";
            this.btnXoadouong.UseVisualStyleBackColor = true;
            // 
            // btnSuadouong
            // 
            this.btnSuadouong.Location = new System.Drawing.Point(135, 4);
            this.btnSuadouong.Name = "btnSuadouong";
            this.btnSuadouong.Size = new System.Drawing.Size(125, 63);
            this.btnSuadouong.TabIndex = 1;
            this.btnSuadouong.Text = "Sửa tài khoản";
            this.btnSuadouong.UseVisualStyleBackColor = true;
            // 
            // btnThemdouong
            // 
            this.btnThemdouong.Location = new System.Drawing.Point(4, 3);
            this.btnThemdouong.Name = "btnThemdouong";
            this.btnThemdouong.Size = new System.Drawing.Size(125, 63);
            this.btnThemdouong.TabIndex = 0;
            this.btnThemdouong.Text = "Thêm tài khoản";
            this.btnThemdouong.UseVisualStyleBackColor = true;
            this.btnThemdouong.Click += new System.EventHandler(this.btnThemdouong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlytaikhoan);
            this.panel2.Location = new System.Drawing.Point(10, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 633);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoadouong);
            this.panel1.Controls.Add(this.btnXoadouong);
            this.panel1.Controls.Add(this.btnSuadouong);
            this.panel1.Controls.Add(this.btnThemdouong);
            this.panel1.Location = new System.Drawing.Point(11, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 70);
            this.panel1.TabIndex = 5;
            // 
            // txttentk
            // 
            this.txttentk.Location = new System.Drawing.Point(6, 215);
            this.txttentk.Name = "txttentk";
            this.txttentk.Size = new System.Drawing.Size(307, 27);
            this.txttentk.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cbTThai);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbLoaitk);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSocmnd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txttentk);
            this.panel3.Controls.Add(this.txttenht);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(557, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 633);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 177);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbTThai
            // 
            this.cbTThai.FormattingEnabled = true;
            this.cbTThai.Location = new System.Drawing.Point(6, 591);
            this.cbTThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTThai.Name = "cbTThai";
            this.cbTThai.Size = new System.Drawing.Size(306, 28);
            this.cbTThai.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái";
            // 
            // cbLoaitk
            // 
            this.cbLoaitk.FormattingEnabled = true;
            this.cbLoaitk.Location = new System.Drawing.Point(7, 515);
            this.cbLoaitk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaitk.Name = "cbLoaitk";
            this.cbLoaitk.Size = new System.Drawing.Size(306, 28);
            this.cbLoaitk.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại tài khoản";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(6, 451);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(307, 27);
            this.txtSDT.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 389);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtSocmnd
            // 
            this.txtSocmnd.Location = new System.Drawing.Point(6, 328);
            this.txtSocmnd.Name = "txtSocmnd";
            this.txtSocmnd.Size = new System.Drawing.Size(307, 27);
            this.txtSocmnd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số cmnd";
            // 
            // txttenht
            // 
            this.txttenht.Location = new System.Drawing.Point(6, 272);
            this.txttenht.Name = "txttenht";
            this.txttenht.Size = new System.Drawing.Size(307, 27);
            this.txttenht.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hiển thị";
            // 
            // frmQuanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanlytaikhoan";
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlytaikhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanlytaikhoan;
        private System.Windows.Forms.Button btnKhoadouong;
        private System.Windows.Forms.Button btnXoadouong;
        private System.Windows.Forms.Button btnSuadouong;
        private System.Windows.Forms.Button btnThemdouong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSocmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaitk;
        private System.Windows.Forms.ComboBox cbTThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}