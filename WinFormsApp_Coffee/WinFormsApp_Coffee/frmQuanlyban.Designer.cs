
namespace WinFormsApp_Coffee
{
    partial class frmQuanlyban
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
            this.btnKhoaban = new System.Windows.Forms.Button();
            this.btnXoaban = new System.Windows.Forms.Button();
            this.btnSuaban = new System.Windows.Forms.Button();
            this.btnThemban = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvQuanlyban = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.txtSoghe = new System.Windows.Forms.TextBox();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyban)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKhoaban
            // 
            this.btnKhoaban.Location = new System.Drawing.Point(347, 3);
            this.btnKhoaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoaban.Name = "btnKhoaban";
            this.btnKhoaban.Size = new System.Drawing.Size(109, 47);
            this.btnKhoaban.TabIndex = 3;
            this.btnKhoaban.Text = "Khóa bàn";
            this.btnKhoaban.UseVisualStyleBackColor = true;
            // 
            // btnXoaban
            // 
            this.btnXoaban.Location = new System.Drawing.Point(232, 2);
            this.btnXoaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaban.Name = "btnXoaban";
            this.btnXoaban.Size = new System.Drawing.Size(109, 47);
            this.btnXoaban.TabIndex = 2;
            this.btnXoaban.Text = "Xóa bàn";
            this.btnXoaban.UseVisualStyleBackColor = true;
            this.btnXoaban.Click += new System.EventHandler(this.btnXoaban_Click);
            // 
            // btnSuaban
            // 
            this.btnSuaban.Location = new System.Drawing.Point(118, 3);
            this.btnSuaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaban.Name = "btnSuaban";
            this.btnSuaban.Size = new System.Drawing.Size(109, 47);
            this.btnSuaban.TabIndex = 1;
            this.btnSuaban.Text = "Sửa bàn";
            this.btnSuaban.UseVisualStyleBackColor = true;
            this.btnSuaban.Click += new System.EventHandler(this.btnSuaban_Click);
            // 
            // btnThemban
            // 
            this.btnThemban.Location = new System.Drawing.Point(4, 2);
            this.btnThemban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.Size = new System.Drawing.Size(109, 47);
            this.btnThemban.TabIndex = 0;
            this.btnThemban.Text = "Thêm bàn";
            this.btnThemban.UseVisualStyleBackColor = true;
            this.btnThemban.Click += new System.EventHandler(this.btnThemban_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoaban);
            this.panel1.Controls.Add(this.btnXoaban);
            this.panel1.Controls.Add(this.btnSuaban);
            this.panel1.Controls.Add(this.btnThemban);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 53);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlyban);
            this.panel2.Location = new System.Drawing.Point(8, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 298);
            this.panel2.TabIndex = 3;
            // 
            // dgvQuanlyban
            // 
            this.dgvQuanlyban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlyban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvQuanlyban.Location = new System.Drawing.Point(4, 1);
            this.dgvQuanlyban.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvQuanlyban.Name = "dgvQuanlyban";
            this.dgvQuanlyban.ReadOnly = true;
            this.dgvQuanlyban.RowHeadersWidth = 62;
            this.dgvQuanlyban.RowTemplate.Height = 33;
            this.dgvQuanlyban.Size = new System.Drawing.Size(468, 296);
            this.dgvQuanlyban.TabIndex = 0;
            this.dgvQuanlyban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlyban_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaBan";
            this.Column1.HeaderText = "Mã bàn";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenBan";
            this.Column2.HeaderText = "Tên bàn";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoGhe";
            this.Column3.HeaderText = "Số ghế";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayBatDauSD";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Ngày bắt đầu sử dụng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TrangThai";
            this.Column5.HeaderText = "Trạng thái bàn";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbTrangThai);
            this.panel3.Controls.Add(this.dateBD);
            this.panel3.Controls.Add(this.txtSoghe);
            this.panel3.Controls.Add(this.txtTenban);
            this.panel3.Controls.Add(this.txtMaban);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(484, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 298);
            this.panel3.TabIndex = 4;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cbTrangThai.Location = new System.Drawing.Point(99, 163);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(178, 23);
            this.cbTrangThai.TabIndex = 17;
            // 
            // dateBD
            // 
            this.dateBD.CustomFormat = "dd/MM/yyyy";
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD.Location = new System.Drawing.Point(99, 125);
            this.dateBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(178, 23);
            this.dateBD.TabIndex = 16;
            this.dateBD.Value = new System.DateTime(2021, 9, 23, 0, 0, 0, 0);
            // 
            // txtSoghe
            // 
            this.txtSoghe.Location = new System.Drawing.Point(99, 82);
            this.txtSoghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoghe.Name = "txtSoghe";
            this.txtSoghe.Size = new System.Drawing.Size(178, 23);
            this.txtSoghe.TabIndex = 13;
            // 
            // txtTenban
            // 
            this.txtTenban.Location = new System.Drawing.Point(99, 46);
            this.txtTenban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(178, 23);
            this.txtTenban.TabIndex = 12;
            // 
            // txtMaban
            // 
            this.txtMaban.Location = new System.Drawing.Point(99, 9);
            this.txtMaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(178, 23);
            this.txtMaban.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã bàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sử dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số ghế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên bàn:";
            // 
            // frmQuanlyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 377);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmQuanlyban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyban)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKhoaban;
        private System.Windows.Forms.Button btnXoaban;
        private System.Windows.Forms.Button btnSuaban;
        private System.Windows.Forms.Button btnThemban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQuanlyban;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoghe;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}