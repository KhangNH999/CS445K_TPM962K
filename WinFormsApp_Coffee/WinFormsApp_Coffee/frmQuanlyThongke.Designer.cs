
namespace WinFormsApp_Coffee
{
    partial class frmQuanlythongke
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvQuanlythongke = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbtendouong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbtennhanvien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthongke = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnthongkebanchay = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvdouongbanchay = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTongbanbc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlythongke)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdouongbanchay)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvQuanlythongke);
            this.panel1.Location = new System.Drawing.Point(15, 201);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 463);
            this.panel1.TabIndex = 0;
            // 
            // dgvQuanlythongke
            // 
            this.dgvQuanlythongke.AllowUserToAddRows = false;
            this.dgvQuanlythongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlythongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlythongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvQuanlythongke.Location = new System.Drawing.Point(4, 4);
            this.dgvQuanlythongke.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQuanlythongke.Name = "dgvQuanlythongke";
            this.dgvQuanlythongke.RowHeadersWidth = 51;
            this.dgvQuanlythongke.RowTemplate.Height = 29;
            this.dgvQuanlythongke.Size = new System.Drawing.Size(988, 455);
            this.dgvQuanlythongke.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tenban";
            this.Column2.HeaderText = "Tên bàn";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tendouong";
            this.Column3.HeaderText = "Tên món";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sl";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Giamgia";
            this.Column5.HeaderText = "KM";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Thanhtien";
            dataGridViewCellStyle1.Format = "#,###";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "T.Tiền";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Ngaylap";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "Ngày lập";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Tennhanvien";
            this.Column8.HeaderText = "Tên nhân viên";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbtendouong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbbtennhanvien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnthongke);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 179);
            this.panel2.TabIndex = 1;
            // 
            // cbbtendouong
            // 
            this.cbbtendouong.FormattingEnabled = true;
            this.cbbtendouong.Location = new System.Drawing.Point(716, 70);
            this.cbbtendouong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbtendouong.Name = "cbbtendouong";
            this.cbbtendouong.Size = new System.Drawing.Size(267, 33);
            this.cbbtendouong.TabIndex = 8;
            this.cbbtendouong.SelectedIndexChanged += new System.EventHandler(this.cbbtendouong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên danh mục đồ uống:";
            // 
            // cbbtennhanvien
            // 
            this.cbbtennhanvien.FormattingEnabled = true;
            this.cbbtennhanvien.Location = new System.Drawing.Point(154, 70);
            this.cbbtennhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cbbtennhanvien.Name = "cbbtennhanvien";
            this.cbbtennhanvien.Size = new System.Drawing.Size(312, 33);
            this.cbbtennhanvien.TabIndex = 6;
            this.cbbtennhanvien.SelectedIndexChanged += new System.EventHandler(this.cbbtennhanvien_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ:";
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(19, 129);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(964, 40);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(564, 10);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(419, 31);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2021, 10, 8, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 9);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(404, 31);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 10, 8, 0, 0, 0, 0);
            // 
            // btnthongkebanchay
            // 
            this.btnthongkebanchay.Location = new System.Drawing.Point(122, 111);
            this.btnthongkebanchay.Margin = new System.Windows.Forms.Padding(4);
            this.btnthongkebanchay.Name = "btnthongkebanchay";
            this.btnthongkebanchay.Size = new System.Drawing.Size(458, 40);
            this.btnthongkebanchay.TabIndex = 9;
            this.btnthongkebanchay.Text = "Thống kê đồ uống bán chạy";
            this.btnthongkebanchay.UseVisualStyleBackColor = true;
            this.btnthongkebanchay.Click += new System.EventHandler(this.btnthongkebanchay_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnthongkebanchay);
            this.panel3.Controls.Add(this.dgvdouongbanchay);
            this.panel3.Controls.Add(this.btn);
            this.panel3.Location = new System.Drawing.Point(1035, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 649);
            this.panel3.TabIndex = 2;
            // 
            // dgvdouongbanchay
            // 
            this.dgvdouongbanchay.AllowUserToAddRows = false;
            this.dgvdouongbanchay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdouongbanchay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdouongbanchay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvdouongbanchay.Location = new System.Drawing.Point(3, 190);
            this.dgvdouongbanchay.Name = "dgvdouongbanchay";
            this.dgvdouongbanchay.RowHeadersWidth = 62;
            this.dgvdouongbanchay.RowTemplate.Height = 33;
            this.dgvdouongbanchay.Size = new System.Drawing.Size(681, 455);
            this.dgvdouongbanchay.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(25, 15);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(642, 54);
            this.btn.TabIndex = 0;
            this.btn.Text = "THỐNG KÊ ĐỒ UỐNG BÁN CHẠY";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTong);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(15, 667);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(996, 73);
            this.panel4.TabIndex = 3;
            // 
            // txtTong
            // 
            this.txtTong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTong.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtTong.Location = new System.Drawing.Point(569, 16);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(423, 45);
            this.txtTong.TabIndex = 1;
            this.txtTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(416, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng cộng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTongbanbc);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(1035, 667);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(687, 73);
            this.panel5.TabIndex = 4;
            // 
            // txtTongbanbc
            // 
            this.txtTongbanbc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTongbanbc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTongbanbc.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtTongbanbc.Location = new System.Drawing.Point(289, 19);
            this.txtTongbanbc.Name = "txtTongbanbc";
            this.txtTongbanbc.ReadOnly = true;
            this.txtTongbanbc.Size = new System.Drawing.Size(395, 45);
            this.txtTongbanbc.TabIndex = 13;
            this.txtTongbanbc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(138, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng cộng";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Tendouong";
            this.Column9.HeaderText = "Tên món";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Soluong";
            this.Column10.HeaderText = "Số lượng";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Tong";
            dataGridViewCellStyle3.Format = "#,###";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column11.HeaderText = "Tổng cộng";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Tendm";
            this.Column12.HeaderText = "Tên danh mục";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // frmQuanlythongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 743);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanlythongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thống kê";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlythongke)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdouongbanchay)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQuanlythongke;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbtendouong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbtennhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthongkebanchay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvdouongbanchay;
        private System.Windows.Forms.Label btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongbanbc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}