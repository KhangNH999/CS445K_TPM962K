
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
            this.panel1.Location = new System.Drawing.Point(18, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 89);
            this.panel1.TabIndex = 4;
            // 
            // btnKhoahd
            // 
            this.btnKhoahd.Location = new System.Drawing.Point(660, 6);
            this.btnKhoahd.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhoahd.Name = "btnKhoahd";
            this.btnKhoahd.Size = new System.Drawing.Size(156, 79);
            this.btnKhoahd.TabIndex = 4;
            this.btnKhoahd.Text = "Khóa hóa đơn";
            this.btnKhoahd.UseVisualStyleBackColor = true;
            // 
            // btnXoahd
            // 
            this.btnXoahd.Location = new System.Drawing.Point(496, 5);
            this.btnXoahd.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoahd.Name = "btnXoahd";
            this.btnXoahd.Size = new System.Drawing.Size(156, 79);
            this.btnXoahd.TabIndex = 3;
            this.btnXoahd.Text = "Xóa hóa đơn";
            this.btnXoahd.UseVisualStyleBackColor = true;
            // 
            // btnSuahd
            // 
            this.btnSuahd.Location = new System.Drawing.Point(331, 4);
            this.btnSuahd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuahd.Name = "btnSuahd";
            this.btnSuahd.Size = new System.Drawing.Size(156, 79);
            this.btnSuahd.TabIndex = 2;
            this.btnSuahd.Text = "Sửa hóa đơn";
            this.btnSuahd.UseVisualStyleBackColor = true;
            // 
            // btnThemhd
            // 
            this.btnThemhd.Location = new System.Drawing.Point(169, 5);
            this.btnThemhd.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(156, 79);
            this.btnThemhd.TabIndex = 1;
            this.btnThemhd.Text = "Thêm hóa đơn";
            this.btnThemhd.UseVisualStyleBackColor = true;
            // 
            // btnXemhd
            // 
            this.btnXemhd.Location = new System.Drawing.Point(6, 4);
            this.btnXemhd.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemhd.Name = "btnXemhd";
            this.btnXemhd.Size = new System.Drawing.Size(156, 79);
            this.btnXemhd.TabIndex = 0;
            this.btnXemhd.Text = "Xem hóa đơn";
            this.btnXemhd.UseVisualStyleBackColor = true;
            this.btnXemhd.Click += new System.EventHandler(this.btnXemhd_Click);
            // 
            // pnlDShd
            // 
            this.pnlDShd.Controls.Add(this.dgvQlhoadon);
            this.pnlDShd.Location = new System.Drawing.Point(18, 116);
            this.pnlDShd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDShd.Name = "pnlDShd";
            this.pnlDShd.Size = new System.Drawing.Size(595, 431);
            this.pnlDShd.TabIndex = 12;
            // 
            // dgvQlhoadon
            // 
            this.dgvQlhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlhoadon.Location = new System.Drawing.Point(4, 5);
            this.dgvQlhoadon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvQlhoadon.Name = "dgvQlhoadon";
            this.dgvQlhoadon.RowHeadersWidth = 51;
            this.dgvQlhoadon.RowTemplate.Height = 25;
            this.dgvQlhoadon.Size = new System.Drawing.Size(588, 421);
            this.dgvQlhoadon.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(616, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 431);
            this.panel2.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTrangthaihd);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(6, 299);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(374, 64);
            this.panel7.TabIndex = 7;
            // 
            // txtTrangthaihd
            // 
            this.txtTrangthaihd.Location = new System.Drawing.Point(142, 15);
            this.txtTrangthaihd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrangthaihd.Name = "txtTrangthaihd";
            this.txtTrangthaihd.Size = new System.Drawing.Size(226, 31);
            this.txtTrangthaihd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtMabanhd);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(6, 225);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 64);
            this.panel6.TabIndex = 6;
            // 
            // txtMabanhd
            // 
            this.txtMabanhd.Location = new System.Drawing.Point(142, 15);
            this.txtMabanhd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMabanhd.Name = "txtMabanhd";
            this.txtMabanhd.Size = new System.Drawing.Size(226, 31);
            this.txtMabanhd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã bàn:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtGiolaphd);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 151);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 64);
            this.panel5.TabIndex = 5;
            // 
            // txtGiolaphd
            // 
            this.txtGiolaphd.Location = new System.Drawing.Point(142, 15);
            this.txtGiolaphd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiolaphd.Name = "txtGiolaphd";
            this.txtGiolaphd.Size = new System.Drawing.Size(226, 31);
            this.txtGiolaphd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giờ lập:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMatkhd);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(4, 79);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 64);
            this.panel4.TabIndex = 4;
            // 
            // txtMatkhd
            // 
            this.txtMatkhd.Location = new System.Drawing.Point(145, 15);
            this.txtMatkhd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatkhd.Name = "txtMatkhd";
            this.txtMatkhd.Size = new System.Drawing.Size(226, 31);
            this.txtMatkhd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã tài khoản:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMahd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 64);
            this.panel3.TabIndex = 3;
            // 
            // txtMahd
            // 
            this.txtMahd.Enabled = false;
            this.txtMahd.Location = new System.Drawing.Point(142, 15);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(226, 31);
            this.txtMahd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // frmQuanlyhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDShd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
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