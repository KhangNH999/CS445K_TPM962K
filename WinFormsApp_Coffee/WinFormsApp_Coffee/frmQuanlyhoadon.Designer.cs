
namespace WinFormsApp_Coffee
{
    partial class frmQuanlyhoadon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKhoahd = new System.Windows.Forms.Button();
            this.btnXoahd = new System.Windows.Forms.Button();
            this.btnSuahd = new System.Windows.Forms.Button();
            this.btnThemhd = new System.Windows.Forms.Button();
            this.btnXemhd = new System.Windows.Forms.Button();
            this.pnlDShd = new System.Windows.Forms.Panel();
            this.dgvQlhoadon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTrangthaihd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtMabanhd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGiolaphd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMatkhd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDShd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlhoadon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoahd);
            this.panel1.Controls.Add(this.btnXoahd);
            this.panel1.Controls.Add(this.btnSuahd);
            this.panel1.Controls.Add(this.btnThemhd);
            this.panel1.Controls.Add(this.btnXemhd);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 71);
            this.panel1.TabIndex = 4;
            // 
            // btnKhoahd
            // 
            this.btnKhoahd.Location = new System.Drawing.Point(528, 5);
            this.btnKhoahd.Name = "btnKhoahd";
            this.btnKhoahd.Size = new System.Drawing.Size(125, 63);
            this.btnKhoahd.TabIndex = 4;
            this.btnKhoahd.Text = "Khóa hóa đơn";
            this.btnKhoahd.UseVisualStyleBackColor = true;
            // 
            // btnXoahd
            // 
            this.btnXoahd.Location = new System.Drawing.Point(397, 4);
            this.btnXoahd.Name = "btnXoahd";
            this.btnXoahd.Size = new System.Drawing.Size(125, 63);
            this.btnXoahd.TabIndex = 3;
            this.btnXoahd.Text = "Xóa hóa đơn";
            this.btnXoahd.UseVisualStyleBackColor = true;
            // 
            // btnSuahd
            // 
            this.btnSuahd.Location = new System.Drawing.Point(265, 3);
            this.btnSuahd.Name = "btnSuahd";
            this.btnSuahd.Size = new System.Drawing.Size(125, 63);
            this.btnSuahd.TabIndex = 2;
            this.btnSuahd.Text = "Sửa hóa đơn";
            this.btnSuahd.UseVisualStyleBackColor = true;
            // 
            // btnThemhd
            // 
            this.btnThemhd.Location = new System.Drawing.Point(135, 4);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(125, 63);
            this.btnThemhd.TabIndex = 1;
            this.btnThemhd.Text = "Thêm hóa đơn";
            this.btnThemhd.UseVisualStyleBackColor = true;
            // 
            // btnXemhd
            // 
            this.btnXemhd.Location = new System.Drawing.Point(5, 3);
            this.btnXemhd.Name = "btnXemhd";
            this.btnXemhd.Size = new System.Drawing.Size(125, 63);
            this.btnXemhd.TabIndex = 0;
            this.btnXemhd.Text = "Xem hóa đơn";
            this.btnXemhd.UseVisualStyleBackColor = true;
            this.btnXemhd.Click += new System.EventHandler(this.btnXemhd_Click);
            // 
            // pnlDShd
            // 
            this.pnlDShd.Controls.Add(this.dgvQlhoadon);
            this.pnlDShd.Location = new System.Drawing.Point(14, 93);
            this.pnlDShd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDShd.Name = "pnlDShd";
            this.pnlDShd.Size = new System.Drawing.Size(476, 345);
            this.pnlDShd.TabIndex = 12;
            // 
            // dgvQlhoadon
            // 
            this.dgvQlhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlhoadon.Location = new System.Drawing.Point(3, 4);
            this.dgvQlhoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvQlhoadon.Name = "dgvQlhoadon";
            this.dgvQlhoadon.RowHeadersWidth = 51;
            this.dgvQlhoadon.RowTemplate.Height = 25;
            this.dgvQlhoadon.Size = new System.Drawing.Size(470, 337);
            this.dgvQlhoadon.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(493, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 345);
            this.panel2.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTrangthaihd);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(5, 239);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(299, 51);
            this.panel7.TabIndex = 7;
            // 
            // txtTrangthaihd
            // 
            this.txtTrangthaihd.Location = new System.Drawing.Point(114, 12);
            this.txtTrangthaihd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangthaihd.Name = "txtTrangthaihd";
            this.txtTrangthaihd.Size = new System.Drawing.Size(182, 27);
            this.txtTrangthaihd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtMabanhd);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(5, 180);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 51);
            this.panel6.TabIndex = 6;
            // 
            // txtMabanhd
            // 
            this.txtMabanhd.Location = new System.Drawing.Point(114, 12);
            this.txtMabanhd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMabanhd.Name = "txtMabanhd";
            this.txtMabanhd.Size = new System.Drawing.Size(182, 27);
            this.txtMabanhd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã bàn:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtGiolaphd);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(5, 121);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 51);
            this.panel5.TabIndex = 5;
            // 
            // txtGiolaphd
            // 
            this.txtGiolaphd.Location = new System.Drawing.Point(114, 12);
            this.txtGiolaphd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiolaphd.Name = "txtGiolaphd";
            this.txtGiolaphd.Size = new System.Drawing.Size(182, 27);
            this.txtGiolaphd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giờ lập:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMatkhd);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 63);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 51);
            this.panel4.TabIndex = 4;
            // 
            // txtMatkhd
            // 
            this.txtMatkhd.Location = new System.Drawing.Point(116, 12);
            this.txtMatkhd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatkhd.Name = "txtMatkhd";
            this.txtMatkhd.Size = new System.Drawing.Size(182, 27);
            this.txtMatkhd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã tài khoản:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMahd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(5, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 51);
            this.panel3.TabIndex = 3;
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(114, 12);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(182, 27);
            this.txtMahd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // frmQuanlyhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDShd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuanlyhoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.panel1.ResumeLayout(false);
            this.pnlDShd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlhoadon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKhoahd;
        private System.Windows.Forms.Button btnXoahd;
        private System.Windows.Forms.Button btnSuahd;
        private System.Windows.Forms.Button btnThemhd;
        private System.Windows.Forms.Button btnXemhd;
        private System.Windows.Forms.Panel pnlDShd;
        private System.Windows.Forms.DataGridView dgvQlhoadon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtTrangthaihd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtMabanhd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGiolaphd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMatkhd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Label label3;
    }
}