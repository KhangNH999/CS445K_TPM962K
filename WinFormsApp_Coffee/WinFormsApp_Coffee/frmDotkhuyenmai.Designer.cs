
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
            this.btnXoasanpham = new System.Windows.Forms.Button();
            this.btnSuathongtin = new System.Windows.Forms.Button();
            this.btnThemsanpham = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDotkhuyenmai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbChondanhmuc = new System.Windows.Forms.ComboBox();
            this.cbChonsanpham = new System.Windows.Forms.ComboBox();
            this.cbChondot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotkhuyenmai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoasanpham
            // 
            this.btnXoasanpham.Location = new System.Drawing.Point(266, 3);
            this.btnXoasanpham.Name = "btnXoasanpham";
            this.btnXoasanpham.Size = new System.Drawing.Size(125, 63);
            this.btnXoasanpham.TabIndex = 2;
            this.btnXoasanpham.Text = "Xóa ";
            this.btnXoasanpham.UseVisualStyleBackColor = true;
            // 
            // btnSuathongtin
            // 
            this.btnSuathongtin.Location = new System.Drawing.Point(135, 4);
            this.btnSuathongtin.Name = "btnSuathongtin";
            this.btnSuathongtin.Size = new System.Drawing.Size(125, 63);
            this.btnSuathongtin.TabIndex = 1;
            this.btnSuathongtin.Text = "Sửa thông tin";
            this.btnSuathongtin.UseVisualStyleBackColor = true;
            // 
            // btnThemsanpham
            // 
            this.btnThemsanpham.Location = new System.Drawing.Point(4, 3);
            this.btnThemsanpham.Name = "btnThemsanpham";
            this.btnThemsanpham.Size = new System.Drawing.Size(125, 63);
            this.btnThemsanpham.TabIndex = 0;
            this.btnThemsanpham.Text = "Thêm sản phẩm";
            this.btnThemsanpham.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDotkhuyenmai);
            this.panel2.Location = new System.Drawing.Point(10, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 494);
            this.panel2.TabIndex = 6;
            // 
            // dgvDotkhuyenmai
            // 
            this.dgvDotkhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDotkhuyenmai.Location = new System.Drawing.Point(5, 2);
            this.dgvDotkhuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDotkhuyenmai.Name = "dgvDotkhuyenmai";
            this.dgvDotkhuyenmai.RowHeadersWidth = 62;
            this.dgvDotkhuyenmai.RowTemplate.Height = 33;
            this.dgvDotkhuyenmai.Size = new System.Drawing.Size(532, 489);
            this.dgvDotkhuyenmai.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoasanpham);
            this.panel1.Controls.Add(this.btnSuathongtin);
            this.panel1.Controls.Add(this.btnThemsanpham);
            this.panel1.Location = new System.Drawing.Point(10, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 70);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChondanhmuc);
            this.panel3.Controls.Add(this.cbChonsanpham);
            this.panel3.Controls.Add(this.cbChondot);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(561, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 494);
            this.panel3.TabIndex = 7;
            // 
            // cbChondanhmuc
            // 
            this.cbChondanhmuc.FormattingEnabled = true;
            this.cbChondanhmuc.Location = new System.Drawing.Point(2, 30);
            this.cbChondanhmuc.Margin = new System.Windows.Forms.Padding(2);
            this.cbChondanhmuc.Name = "cbChondanhmuc";
            this.cbChondanhmuc.Size = new System.Drawing.Size(307, 28);
            this.cbChondanhmuc.TabIndex = 8;
            // 
            // cbChonsanpham
            // 
            this.cbChonsanpham.FormattingEnabled = true;
            this.cbChonsanpham.Location = new System.Drawing.Point(4, 99);
            this.cbChonsanpham.Margin = new System.Windows.Forms.Padding(2);
            this.cbChonsanpham.Name = "cbChonsanpham";
            this.cbChonsanpham.Size = new System.Drawing.Size(307, 28);
            this.cbChonsanpham.TabIndex = 7;
            // 
            // cbChondot
            // 
            this.cbChondot.FormattingEnabled = true;
            this.cbChondot.Location = new System.Drawing.Point(2, 171);
            this.cbChondot.Margin = new System.Windows.Forms.Padding(2);
            this.cbChondot.Name = "cbChondot";
            this.cbChondot.Size = new System.Drawing.Size(307, 28);
            this.cbChondot.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn đợt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn danh mục";
            // 
            // frmDotkhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDotkhuyenmai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDotkhuyenmai";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotkhuyenmai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoasanpham;
        private System.Windows.Forms.Button btnSuathongtin;
        private System.Windows.Forms.Button btnThemsanpham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDotkhuyenmai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbChondot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChondanhmuc;
        private System.Windows.Forms.ComboBox cbChonsanpham;
    }
}