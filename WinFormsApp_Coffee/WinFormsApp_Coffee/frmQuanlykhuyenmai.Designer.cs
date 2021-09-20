
namespace WinFormsApp_Coffee
{
    partial class frmQuanlykhuyenmai
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
            this.cbbTrangthai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNgaykt = new System.Windows.Forms.TextBox();
            this.txtNgaybd = new System.Windows.Forms.TextBox();
            this.txtMadot = new System.Windows.Forms.TextBox();
            this.txtTendot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvQuanlykhuyenmai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemdotkm = new System.Windows.Forms.Button();
            this.btnXoadotkhuyenmai = new System.Windows.Forms.Button();
            this.btnSuathongtin = new System.Windows.Forms.Button();
            this.btnThemdotkhuyenmai = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlykhuyenmai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTrangthai
            // 
            this.cbbTrangthai.FormattingEnabled = true;
            this.cbbTrangthai.Location = new System.Drawing.Point(115, 220);
            this.cbbTrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTrangthai.Name = "cbbTrangthai";
            this.cbbTrangthai.Size = new System.Drawing.Size(200, 28);
            this.cbbTrangthai.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đợt:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNgaykt);
            this.panel3.Controls.Add(this.txtNgaybd);
            this.panel3.Controls.Add(this.cbbTrangthai);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMadot);
            this.panel3.Controls.Add(this.txtTendot);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(554, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 292);
            this.panel3.TabIndex = 10;
            // 
            // txtNgaykt
            // 
            this.txtNgaykt.Location = new System.Drawing.Point(115, 168);
            this.txtNgaykt.Name = "txtNgaykt";
            this.txtNgaykt.Size = new System.Drawing.Size(200, 27);
            this.txtNgaykt.TabIndex = 16;
            // 
            // txtNgaybd
            // 
            this.txtNgaybd.Location = new System.Drawing.Point(115, 113);
            this.txtNgaybd.Name = "txtNgaybd";
            this.txtNgaybd.Size = new System.Drawing.Size(200, 27);
            this.txtNgaybd.TabIndex = 15;
            // 
            // txtMadot
            // 
            this.txtMadot.Location = new System.Drawing.Point(115, 12);
            this.txtMadot.Name = "txtMadot";
            this.txtMadot.Size = new System.Drawing.Size(200, 27);
            this.txtMadot.TabIndex = 4;
            // 
            // txtTendot
            // 
            this.txtTendot.Location = new System.Drawing.Point(115, 62);
            this.txtTendot.Name = "txtTendot";
            this.txtTendot.Size = new System.Drawing.Size(200, 27);
            this.txtTendot.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlykhuyenmai);
            this.panel2.Location = new System.Drawing.Point(7, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 292);
            this.panel2.TabIndex = 9;
            // 
            // dgvQuanlykhuyenmai
            // 
            this.dgvQuanlykhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlykhuyenmai.Location = new System.Drawing.Point(5, 2);
            this.dgvQuanlykhuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanlykhuyenmai.Name = "dgvQuanlykhuyenmai";
            this.dgvQuanlykhuyenmai.RowHeadersWidth = 62;
            this.dgvQuanlykhuyenmai.RowTemplate.Height = 33;
            this.dgvQuanlykhuyenmai.Size = new System.Drawing.Size(532, 285);
            this.dgvQuanlykhuyenmai.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemdotkm);
            this.panel1.Controls.Add(this.btnXoadotkhuyenmai);
            this.panel1.Controls.Add(this.btnSuathongtin);
            this.panel1.Controls.Add(this.btnThemdotkhuyenmai);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 70);
            this.panel1.TabIndex = 8;
            // 
            // btnXemdotkm
            // 
            this.btnXemdotkm.Location = new System.Drawing.Point(4, 3);
            this.btnXemdotkm.Name = "btnXemdotkm";
            this.btnXemdotkm.Size = new System.Drawing.Size(125, 63);
            this.btnXemdotkm.TabIndex = 3;
            this.btnXemdotkm.Text = "Xem đợt khuyến mãi";
            this.btnXemdotkm.UseVisualStyleBackColor = true;
            this.btnXemdotkm.Click += new System.EventHandler(this.btnXemdotkm_Click);
            // 
            // btnXoadotkhuyenmai
            // 
            this.btnXoadotkhuyenmai.Location = new System.Drawing.Point(397, 3);
            this.btnXoadotkhuyenmai.Name = "btnXoadotkhuyenmai";
            this.btnXoadotkhuyenmai.Size = new System.Drawing.Size(125, 63);
            this.btnXoadotkhuyenmai.TabIndex = 2;
            this.btnXoadotkhuyenmai.Text = "Xóa đợt khuyến mãi";
            this.btnXoadotkhuyenmai.UseVisualStyleBackColor = true;
            // 
            // btnSuathongtin
            // 
            this.btnSuathongtin.Location = new System.Drawing.Point(266, 3);
            this.btnSuathongtin.Name = "btnSuathongtin";
            this.btnSuathongtin.Size = new System.Drawing.Size(125, 63);
            this.btnSuathongtin.TabIndex = 1;
            this.btnSuathongtin.Text = "Sửa đợt khuyến mãi";
            this.btnSuathongtin.UseVisualStyleBackColor = true;
            // 
            // btnThemdotkhuyenmai
            // 
            this.btnThemdotkhuyenmai.Location = new System.Drawing.Point(135, 3);
            this.btnThemdotkhuyenmai.Name = "btnThemdotkhuyenmai";
            this.btnThemdotkhuyenmai.Size = new System.Drawing.Size(125, 63);
            this.btnThemdotkhuyenmai.TabIndex = 0;
            this.btnThemdotkhuyenmai.Text = "Thêm đợt khuyến mãi";
            this.btnThemdotkhuyenmai.UseVisualStyleBackColor = true;
            this.btnThemdotkhuyenmai.Click += new System.EventHandler(this.btnThemdotkhuyenmai_Click);
            // 
            // frmQuanlykhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 389);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuanlykhuyenmai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanlykhuyenmai";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlykhuyenmai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTrangthai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMadot;
        private System.Windows.Forms.TextBox txtTendot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQuanlykhuyenmai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoadotkhuyenmai;
        private System.Windows.Forms.Button btnSuathongtin;
        private System.Windows.Forms.Button btnThemdotkhuyenmai;
        private System.Windows.Forms.TextBox txtNgaykt;
        private System.Windows.Forms.TextBox txtNgaybd;
        private System.Windows.Forms.Button btnXemdotkm;
    }
}