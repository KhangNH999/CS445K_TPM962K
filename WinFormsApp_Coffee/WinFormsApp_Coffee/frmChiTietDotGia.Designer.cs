
namespace WinFormsApp_Coffee
{
    partial class frmChiTietDotGia
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
            this.btnThemdouong = new System.Windows.Forms.Button();
            this.dgvChitietdotgia = new System.Windows.Forms.DataGridView();
            this.MaDotgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuadouong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoadouong = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbMadotgia = new System.Windows.Forms.ComboBox();
            this.cbTenmon = new System.Windows.Forms.ComboBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietdotgia)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemdouong
            // 
            this.btnThemdouong.Location = new System.Drawing.Point(5, 4);
            this.btnThemdouong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemdouong.Name = "btnThemdouong";
            this.btnThemdouong.Size = new System.Drawing.Size(156, 68);
            this.btnThemdouong.TabIndex = 3;
            this.btnThemdouong.Text = "Thêm đồ uống";
            this.btnThemdouong.UseVisualStyleBackColor = true;
            this.btnThemdouong.Click += new System.EventHandler(this.btnThemdouong_Click);
            // 
            // dgvChitietdotgia
            // 
            this.dgvChitietdotgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChitietdotgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietdotgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDotgia,
            this.MaDoUong,
            this.GiaBan});
            this.dgvChitietdotgia.Location = new System.Drawing.Point(5, 5);
            this.dgvChitietdotgia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChitietdotgia.Name = "dgvChitietdotgia";
            this.dgvChitietdotgia.RowHeadersWidth = 51;
            this.dgvChitietdotgia.RowTemplate.Height = 29;
            this.dgvChitietdotgia.Size = new System.Drawing.Size(558, 430);
            this.dgvChitietdotgia.TabIndex = 0;
            this.dgvChitietdotgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitietdotgia_CellClick);
            // 
            // MaDotgia
            // 
            this.MaDotgia.DataPropertyName = "MaDotGia";
            this.MaDotgia.HeaderText = "Mã đợt giá";
            this.MaDotgia.MinimumWidth = 6;
            this.MaDotgia.Name = "MaDotgia";
            this.MaDotgia.ReadOnly = true;
            // 
            // MaDoUong
            // 
            this.MaDoUong.DataPropertyName = "TenDoUong";
            this.MaDoUong.HeaderText = "Tên món";
            this.MaDoUong.MinimumWidth = 6;
            this.MaDoUong.Name = "MaDoUong";
            this.MaDoUong.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.Format = "#,###";
            this.GiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvChitietdotgia);
            this.panel2.Location = new System.Drawing.Point(5, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 439);
            this.panel2.TabIndex = 0;
            // 
            // btnSuadouong
            // 
            this.btnSuadouong.Location = new System.Drawing.Point(169, 5);
            this.btnSuadouong.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuadouong.Name = "btnSuadouong";
            this.btnSuadouong.Size = new System.Drawing.Size(156, 68);
            this.btnSuadouong.TabIndex = 0;
            this.btnSuadouong.Text = "Sửa đồ uống";
            this.btnSuadouong.UseVisualStyleBackColor = true;
            this.btnSuadouong.Click += new System.EventHandler(this.btnSuadouong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt giá:";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(796, 5);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(156, 68);
            this.btnLammoi.TabIndex = 2;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoadouong
            // 
            this.btnXoadouong.Location = new System.Drawing.Point(332, 5);
            this.btnXoadouong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoadouong.Name = "btnXoadouong";
            this.btnXoadouong.Size = new System.Drawing.Size(156, 68);
            this.btnXoadouong.TabIndex = 1;
            this.btnXoadouong.Text = "Xóa đồ uống";
            this.btnXoadouong.UseVisualStyleBackColor = true;
            this.btnXoadouong.Click += new System.EventHandler(this.btnXoadouong_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThemdouong);
            this.panel4.Controls.Add(this.btnLammoi);
            this.panel4.Controls.Add(this.btnXoadouong);
            this.panel4.Controls.Add(this.btnSuadouong);
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(956, 76);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 531);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbMadotgia);
            this.panel3.Controls.Add(this.cbTenmon);
            this.panel3.Controls.Add(this.txtGiaban);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(580, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 439);
            this.panel3.TabIndex = 1;
            // 
            // cbMadotgia
            // 
            this.cbMadotgia.FormattingEnabled = true;
            this.cbMadotgia.Location = new System.Drawing.Point(140, 18);
            this.cbMadotgia.Name = "cbMadotgia";
            this.cbMadotgia.Size = new System.Drawing.Size(237, 33);
            this.cbMadotgia.TabIndex = 11;
            // 
            // cbTenmon
            // 
            this.cbTenmon.FormattingEnabled = true;
            this.cbTenmon.Location = new System.Drawing.Point(140, 85);
            this.cbTenmon.Name = "cbTenmon";
            this.cbTenmon.Size = new System.Drawing.Size(237, 33);
            this.cbTenmon.TabIndex = 10;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(140, 148);
            this.txtGiaban.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(240, 31);
            this.txtGiaban.TabIndex = 4;
            // 
            // frmChiTietDotGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietDotGia";
            this.Text = "frmChiTietDotGia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietdotgia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemdouong;
        private System.Windows.Forms.DataGridView dgvChitietdotgia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuadouong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoadouong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.ComboBox cbTenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDotgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.ComboBox cbMadotgia;
    }
}