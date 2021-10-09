
namespace WinFormsApp_Coffee
{
    partial class frmXemHoaDonChoNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemhoadon = new System.Windows.Forms.Button();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQlhoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(373, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem hóa đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemhoadon);
            this.panel1.Controls.Add(this.txtTenban);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNgay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvQlhoadon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 490);
            this.panel1.TabIndex = 1;
            // 
            // btnXemhoadon
            // 
            this.btnXemhoadon.Location = new System.Drawing.Point(335, 172);
            this.btnXemhoadon.Name = "btnXemhoadon";
            this.btnXemhoadon.Size = new System.Drawing.Size(343, 40);
            this.btnXemhoadon.TabIndex = 10;
            this.btnXemhoadon.Text = "Xem chi tiết hóa đơn";
            this.btnXemhoadon.UseVisualStyleBackColor = true;
            this.btnXemhoadon.Click += new System.EventHandler(this.btnXemhoadon_Click);
            // 
            // txtTenban
            // 
            this.txtTenban.BackColor = System.Drawing.Color.White;
            this.txtTenban.Location = new System.Drawing.Point(641, 127);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.ReadOnly = true;
            this.txtTenban.Size = new System.Drawing.Size(223, 31);
            this.txtTenban.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên bàn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.White;
            this.txtMaHD.Location = new System.Drawing.Point(641, 77);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(223, 31);
            this.txtMaHD.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên nhân viên";
            // 
            // txtNV
            // 
            this.txtNV.BackColor = System.Drawing.Color.White;
            this.txtNV.Location = new System.Drawing.Point(214, 127);
            this.txtNV.Name = "txtNV";
            this.txtNV.ReadOnly = true;
            this.txtNV.Size = new System.Drawing.Size(223, 31);
            this.txtNV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày lập";
            // 
            // txtNgay
            // 
            this.txtNgay.BackColor = System.Drawing.Color.White;
            this.txtNgay.Location = new System.Drawing.Point(214, 77);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(223, 31);
            this.txtNgay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã HĐ";
            // 
            // dgvQlhoadon
            // 
            this.dgvQlhoadon.AllowUserToAddRows = false;
            this.dgvQlhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQlhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvQlhoadon.Location = new System.Drawing.Point(2, 232);
            this.dgvQlhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQlhoadon.Name = "dgvQlhoadon";
            this.dgvQlhoadon.RowHeadersWidth = 62;
            this.dgvQlhoadon.RowTemplate.Height = 25;
            this.dgvQlhoadon.Size = new System.Drawing.Size(1019, 256);
            this.dgvQlhoadon.TabIndex = 1;
            this.dgvQlhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQlhoadon_CellClick);
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
            this.Column2.DataPropertyName = "Tentk";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngaylap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Ngày lập";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tenban";
            this.Column4.HeaderText = "Tên bàn";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Trangthaihoadon";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmXemHoaDonChoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 515);
            this.Controls.Add(this.panel1);
            this.Name = "frmXemHoaDonChoNV";
            this.Text = "Xem hóa đơn";
            this.Load += new System.EventHandler(this.frmXemHoaDonChoNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlhoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQlhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemhoadon;
    }
}