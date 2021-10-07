
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
            this.txtMadotgia = new System.Windows.Forms.TextBox();
            this.txtMadouong = new System.Windows.Forms.TextBox();
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
            this.btnThemdouong.Location = new System.Drawing.Point(4, 3);
            this.btnThemdouong.Name = "btnThemdouong";
            this.btnThemdouong.Size = new System.Drawing.Size(125, 54);
            this.btnThemdouong.TabIndex = 3;
            this.btnThemdouong.Text = "Thêm đồ uống";
            this.btnThemdouong.UseVisualStyleBackColor = true;
            this.btnThemdouong.Click += new System.EventHandler(this.btnThemdouong_Click);
            // 
            // dgvChitietdotgia
            // 
            this.dgvChitietdotgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietdotgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDotgia,
            this.MaDoUong,
            this.GiaBan});
            this.dgvChitietdotgia.Location = new System.Drawing.Point(4, 4);
            this.dgvChitietdotgia.Name = "dgvChitietdotgia";
            this.dgvChitietdotgia.RowHeadersWidth = 51;
            this.dgvChitietdotgia.RowTemplate.Height = 29;
            this.dgvChitietdotgia.Size = new System.Drawing.Size(446, 344);
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
            this.MaDotgia.Width = 125;
            // 
            // MaDoUong
            // 
            this.MaDoUong.DataPropertyName = "MaDoUong";
            this.MaDoUong.HeaderText = "Mã đồ uống";
            this.MaDoUong.MinimumWidth = 6;
            this.MaDoUong.Name = "MaDoUong";
            this.MaDoUong.ReadOnly = true;
            this.MaDoUong.Width = 125;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvChitietdotgia);
            this.panel2.Location = new System.Drawing.Point(4, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 351);
            this.panel2.TabIndex = 0;
            // 
            // btnSuadouong
            // 
            this.btnSuadouong.Location = new System.Drawing.Point(135, 4);
            this.btnSuadouong.Name = "btnSuadouong";
            this.btnSuadouong.Size = new System.Drawing.Size(125, 54);
            this.btnSuadouong.TabIndex = 0;
            this.btnSuadouong.Text = "Sửa đồ uống";
            this.btnSuadouong.UseVisualStyleBackColor = true;
            this.btnSuadouong.Click += new System.EventHandler(this.btnSuadouong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã đồ uống:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt giá:";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(637, 4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(125, 54);
            this.btnLammoi.TabIndex = 2;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoadouong
            // 
            this.btnXoadouong.Location = new System.Drawing.Point(266, 4);
            this.btnXoadouong.Name = "btnXoadouong";
            this.btnXoadouong.Size = new System.Drawing.Size(125, 54);
            this.btnXoadouong.TabIndex = 1;
            this.btnXoadouong.Text = "Xóa sản phẩm";
            this.btnXoadouong.UseVisualStyleBackColor = true;
            this.btnXoadouong.Click += new System.EventHandler(this.btnXoadouong_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThemdouong);
            this.panel4.Controls.Add(this.btnLammoi);
            this.panel4.Controls.Add(this.btnXoadouong);
            this.panel4.Controls.Add(this.btnSuadouong);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 61);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMadotgia);
            this.panel3.Controls.Add(this.txtMadouong);
            this.panel3.Controls.Add(this.txtGiaban);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(464, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 351);
            this.panel3.TabIndex = 1;
            // 
            // txtMadotgia
            // 
            this.txtMadotgia.Location = new System.Drawing.Point(112, 11);
            this.txtMadotgia.Name = "txtMadotgia";
            this.txtMadotgia.Size = new System.Drawing.Size(193, 27);
            this.txtMadotgia.TabIndex = 9;
            // 
            // txtMadouong
            // 
            this.txtMadouong.Location = new System.Drawing.Point(112, 65);
            this.txtMadouong.Name = "txtMadouong";
            this.txtMadouong.Size = new System.Drawing.Size(193, 27);
            this.txtMadouong.TabIndex = 8;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(112, 118);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(193, 27);
            this.txtGiaban.TabIndex = 4;
            // 
            // frmChiTietDotGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDotgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.TextBox txtMadouong;
        private System.Windows.Forms.TextBox txtMadotgia;
    }
}