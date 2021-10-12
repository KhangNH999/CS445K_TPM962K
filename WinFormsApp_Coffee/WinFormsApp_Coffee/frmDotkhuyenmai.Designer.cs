
namespace WinFormsApp_Coffee
{
    partial class frmDotkhuyenmai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDotkhuyenmai));
            this.btnXoasanpham = new System.Windows.Forms.Button();
            this.btnSuasanpham = new System.Windows.Forms.Button();
            this.btnThemsanpham = new System.Windows.Forms.Button();
            this.dgvDotkhuyenmai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.cbbMadouong = new System.Windows.Forms.ComboBox();
            this.txtTilegiam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotkhuyenmai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoasanpham
            // 
            this.btnXoasanpham.Location = new System.Drawing.Point(266, 3);
            this.btnXoasanpham.Name = "btnXoasanpham";
            this.btnXoasanpham.Size = new System.Drawing.Size(125, 63);
            this.btnXoasanpham.TabIndex = 2;
            this.btnXoasanpham.Text = "Xóa sản phẩm";
            this.btnXoasanpham.UseVisualStyleBackColor = true;
            this.btnXoasanpham.Click += new System.EventHandler(this.btnXoasanpham_Click);
            // 
            // btnSuasanpham
            // 
            this.btnSuasanpham.Location = new System.Drawing.Point(135, 4);
            this.btnSuasanpham.Name = "btnSuasanpham";
            this.btnSuasanpham.Size = new System.Drawing.Size(125, 63);
            this.btnSuasanpham.TabIndex = 1;
            this.btnSuasanpham.Text = "Sửa sản phẩm";
            this.btnSuasanpham.UseVisualStyleBackColor = true;
            this.btnSuasanpham.Click += new System.EventHandler(this.btnSuasanpham_Click);
            // 
            // btnThemsanpham
            // 
            this.btnThemsanpham.Location = new System.Drawing.Point(4, 4);
            this.btnThemsanpham.Name = "btnThemsanpham";
            this.btnThemsanpham.Size = new System.Drawing.Size(125, 62);
            this.btnThemsanpham.TabIndex = 0;
            this.btnThemsanpham.Text = "Thêm sản phẩm";
            this.btnThemsanpham.UseVisualStyleBackColor = true;
            this.btnThemsanpham.Click += new System.EventHandler(this.btnThemsanpham_Click);
            // 
            // dgvDotkhuyenmai
            // 
            this.dgvDotkhuyenmai.AllowUserToAddRows = false;
            this.dgvDotkhuyenmai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDotkhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDotkhuyenmai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDotkhuyenmai.Location = new System.Drawing.Point(6, 23);
            this.dgvDotkhuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDotkhuyenmai.Name = "dgvDotkhuyenmai";
            this.dgvDotkhuyenmai.RowHeadersWidth = 62;
            this.dgvDotkhuyenmai.RowTemplate.Height = 33;
            this.dgvDotkhuyenmai.Size = new System.Drawing.Size(593, 294);
            this.dgvDotkhuyenmai.TabIndex = 0;
            this.dgvDotkhuyenmai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDotkhuyenmai_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tendotkm";
            this.Column1.HeaderText = "Tên đợt km";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tendouong";
            this.Column2.HeaderText = "Tên đồ uống";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tlgiamgia";
            this.Column3.HeaderText = "Tỷ lệ giảm giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntLammoi);
            this.panel1.Controls.Add(this.btnXoasanpham);
            this.panel1.Controls.Add(this.btnSuasanpham);
            this.panel1.Controls.Add(this.btnThemsanpham);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 70);
            this.panel1.TabIndex = 5;
            // 
            // bntLammoi
            // 
            this.bntLammoi.Location = new System.Drawing.Point(396, 3);
            this.bntLammoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(124, 63);
            this.bntLammoi.TabIndex = 3;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtKM);
            this.panel3.Controls.Add(this.cbbMadouong);
            this.panel3.Controls.Add(this.txtTilegiam);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(6, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 292);
            this.panel3.TabIndex = 7;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(149, 14);
            this.txtKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKM.Name = "txtKM";
            this.txtKM.ReadOnly = true;
            this.txtKM.Size = new System.Drawing.Size(194, 27);
            this.txtKM.TabIndex = 4;
            // 
            // cbbMadouong
            // 
            this.cbbMadouong.FormattingEnabled = true;
            this.cbbMadouong.Location = new System.Drawing.Point(149, 59);
            this.cbbMadouong.Name = "cbbMadouong";
            this.cbbMadouong.Size = new System.Drawing.Size(194, 28);
            this.cbbMadouong.TabIndex = 5;
            // 
            // txtTilegiam
            // 
            this.txtTilegiam.Location = new System.Drawing.Point(149, 107);
            this.txtTilegiam.Name = "txtTilegiam";
            this.txtTilegiam.Size = new System.Drawing.Size(194, 27);
            this.txtTilegiam.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tỉ lệ giảm giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đồ uống:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đợt km:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(602, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDotkhuyenmai);
            this.groupBox2.Location = new System.Drawing.Point(10, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(602, 321);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đồ uống khuyến mãi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(617, 112);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(366, 321);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đồ uống khuyến mãi";
            // 
            // frmDotkhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDotkhuyenmai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đợt khuyến mãi";
            this.Load += new System.EventHandler(this.frmDotkhuyenmai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotkhuyenmai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoasanpham;
        private System.Windows.Forms.Button btnSuasanpham;
        private System.Windows.Forms.Button btnThemsanpham;
        private System.Windows.Forms.DataGridView dgvDotkhuyenmai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbMadouong;
        private System.Windows.Forms.TextBox txtTilegiam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button bntLammoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKM;
    }
}