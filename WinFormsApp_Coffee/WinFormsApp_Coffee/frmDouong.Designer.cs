
namespace WinFormsApp_Coffee
{
    partial class frmDouong
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
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnKhoadouong = new System.Windows.Forms.Button();
            this.btnXoadouong = new System.Windows.Forms.Button();
            this.btnSuadouong = new System.Windows.Forms.Button();
            this.btnThemdouong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDmdouong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTrangthai = new System.Windows.Forms.ComboBox();
            this.cbbMadanhmuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMadouong = new System.Windows.Forms.TextBox();
            this.txtTendouong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDmdouong)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.btnKhoadouong);
            this.panel1.Controls.Add(this.btnXoadouong);
            this.panel1.Controls.Add(this.btnSuadouong);
            this.panel1.Controls.Add(this.btnThemdouong);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 88);
            this.panel1.TabIndex = 1;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(914, 5);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(154, 79);
            this.btnLammoi.TabIndex = 4;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnKhoadouong
            // 
            this.btnKhoadouong.Location = new System.Drawing.Point(496, 5);
            this.btnKhoadouong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhoadouong.Name = "btnKhoadouong";
            this.btnKhoadouong.Size = new System.Drawing.Size(156, 79);
            this.btnKhoadouong.TabIndex = 3;
            this.btnKhoadouong.Text = "Khóa đồ uống";
            this.btnKhoadouong.UseVisualStyleBackColor = true;
            this.btnKhoadouong.Click += new System.EventHandler(this.btnKhoadouong_Click);
            // 
            // btnXoadouong
            // 
            this.btnXoadouong.Location = new System.Drawing.Point(332, 5);
            this.btnXoadouong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoadouong.Name = "btnXoadouong";
            this.btnXoadouong.Size = new System.Drawing.Size(156, 79);
            this.btnXoadouong.TabIndex = 2;
            this.btnXoadouong.Text = "Xóa đồ uống";
            this.btnXoadouong.UseVisualStyleBackColor = true;
            this.btnXoadouong.Click += new System.EventHandler(this.btnXoadouong_Click);
            // 
            // btnSuadouong
            // 
            this.btnSuadouong.Location = new System.Drawing.Point(169, 5);
            this.btnSuadouong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuadouong.Name = "btnSuadouong";
            this.btnSuadouong.Size = new System.Drawing.Size(156, 79);
            this.btnSuadouong.TabIndex = 1;
            this.btnSuadouong.Text = "Sửa đồ uống";
            this.btnSuadouong.UseVisualStyleBackColor = true;
            this.btnSuadouong.Click += new System.EventHandler(this.btnSuadouong_Click);
            // 
            // btnThemdouong
            // 
            this.btnThemdouong.Location = new System.Drawing.Point(5, 5);
            this.btnThemdouong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemdouong.Name = "btnThemdouong";
            this.btnThemdouong.Size = new System.Drawing.Size(156, 79);
            this.btnThemdouong.TabIndex = 0;
            this.btnThemdouong.Text = "Thêm đồ uống";
            this.btnThemdouong.UseVisualStyleBackColor = true;
            this.btnThemdouong.Click += new System.EventHandler(this.btnThemdouong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDmdouong);
            this.panel2.Location = new System.Drawing.Point(15, 112);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 484);
            this.panel2.TabIndex = 2;
            // 
            // dgvDmdouong
            // 
            this.dgvDmdouong.AllowUserToAddRows = false;
            this.dgvDmdouong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDmdouong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDmdouong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dgvDmdouong.Location = new System.Drawing.Point(4, 5);
            this.dgvDmdouong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDmdouong.Name = "dgvDmdouong";
            this.dgvDmdouong.RowHeadersWidth = 51;
            this.dgvDmdouong.RowTemplate.Height = 29;
            this.dgvDmdouong.Size = new System.Drawing.Size(665, 475);
            this.dgvDmdouong.TabIndex = 0;
            this.dgvDmdouong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdouong_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDoUong";
            this.Column1.HeaderText = "Mã đồ uống";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDoUong";
            this.Column2.HeaderText = "Tên đồ uống";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TrangThai";
            this.Column4.HeaderText = "Trạng thái";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Tendanhmuc";
            this.Column5.HeaderText = "Tên danh mục";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbTrangthai);
            this.panel3.Controls.Add(this.cbbMadanhmuc);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMadouong);
            this.panel3.Controls.Add(this.txtTendouong);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(696, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 484);
            this.panel3.TabIndex = 3;
            // 
            // cbbTrangthai
            // 
            this.cbbTrangthai.FormattingEnabled = true;
            this.cbbTrangthai.Items.AddRange(new object[] {
            "Hết",
            "Còn",
            "Đã khóa"});
            this.cbbTrangthai.Location = new System.Drawing.Point(139, 218);
            this.cbbTrangthai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTrangthai.Name = "cbbTrangthai";
            this.cbbTrangthai.Size = new System.Drawing.Size(246, 33);
            this.cbbTrangthai.TabIndex = 20;
            // 
            // cbbMadanhmuc
            // 
            this.cbbMadanhmuc.FormattingEnabled = true;
            this.cbbMadanhmuc.Location = new System.Drawing.Point(139, 15);
            this.cbbMadanhmuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMadanhmuc.Name = "cbbMadanhmuc";
            this.cbbMadanhmuc.Size = new System.Drawing.Size(246, 33);
            this.cbbMadanhmuc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trạng thái:";
            // 
            // txtMadouong
            // 
            this.txtMadouong.Enabled = false;
            this.txtMadouong.Location = new System.Drawing.Point(139, 84);
            this.txtMadouong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMadouong.Name = "txtMadouong";
            this.txtMadouong.Size = new System.Drawing.Size(246, 31);
            this.txtMadouong.TabIndex = 3;
            // 
            // txtTendouong
            // 
            this.txtTendouong.Location = new System.Drawing.Point(139, 151);
            this.txtTendouong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTendouong.Name = "txtTendouong";
            this.txtTendouong.Size = new System.Drawing.Size(246, 31);
            this.txtTendouong.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên đồ uống:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đồ uống:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã danh mục:";
            // 
            // frmDouong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmDouong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đồ uống";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDmdouong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoadouong;
        private System.Windows.Forms.Button btnSuadouong;
        private System.Windows.Forms.Button btnThemdouong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDmdouong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMadouong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhoadouong;
        private System.Windows.Forms.ComboBox cbbMadanhmuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTendouong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnLammoi;
    }
}