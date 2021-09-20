
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
            this.btnKhoaban = new System.Windows.Forms.Button();
            this.btnXoaban = new System.Windows.Forms.Button();
            this.btnSuaban = new System.Windows.Forms.Button();
            this.btnThemban = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvQuanlyban = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtSoghe = new System.Windows.Forms.TextBox();
            this.txtNgaysudung = new System.Windows.Forms.TextBox();
            this.txtTrangthaiban = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyban)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKhoaban
            // 
            this.btnKhoaban.Location = new System.Drawing.Point(397, 4);
            this.btnKhoaban.Name = "btnKhoaban";
            this.btnKhoaban.Size = new System.Drawing.Size(125, 63);
            this.btnKhoaban.TabIndex = 3;
            this.btnKhoaban.Text = "Khóa bàn";
            this.btnKhoaban.UseVisualStyleBackColor = true;
            // 
            // btnXoaban
            // 
            this.btnXoaban.Location = new System.Drawing.Point(266, 3);
            this.btnXoaban.Name = "btnXoaban";
            this.btnXoaban.Size = new System.Drawing.Size(125, 63);
            this.btnXoaban.TabIndex = 2;
            this.btnXoaban.Text = "Xóa bàn";
            this.btnXoaban.UseVisualStyleBackColor = true;

            // 
            // btnSuaban
            // 
            this.btnSuaban.Location = new System.Drawing.Point(135, 4);
            this.btnSuaban.Name = "btnSuaban";
            this.btnSuaban.Size = new System.Drawing.Size(125, 63);
            this.btnSuaban.TabIndex = 1;
            this.btnSuaban.Text = "Sửa bàn";
            this.btnSuaban.UseVisualStyleBackColor = true;
 
            // 
            // btnThemban
            // 
            this.btnThemban.Location = new System.Drawing.Point(4, 3);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.Size = new System.Drawing.Size(125, 63);
            this.btnThemban.TabIndex = 0;
            this.btnThemban.Text = "Thêm bàn";
            this.btnThemban.UseVisualStyleBackColor = true;

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoaban);
            this.panel1.Controls.Add(this.btnXoaban);
            this.panel1.Controls.Add(this.btnSuaban);
            this.panel1.Controls.Add(this.btnThemban);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 70);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlyban);
            this.panel2.Location = new System.Drawing.Point(10, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 397);
            this.panel2.TabIndex = 3;
            // 
            // dgvQuanlyban
            // 
            this.dgvQuanlyban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlyban.Location = new System.Drawing.Point(5, 2);
            this.dgvQuanlyban.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanlyban.Name = "dgvQuanlyban";
            this.dgvQuanlyban.ReadOnly = true;
            this.dgvQuanlyban.RowHeadersWidth = 62;
            this.dgvQuanlyban.RowTemplate.Height = 33;
            this.dgvQuanlyban.Size = new System.Drawing.Size(534, 395);
            this.dgvQuanlyban.TabIndex = 0;
 
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTrangthaiban);
            this.panel3.Controls.Add(this.txtNgaysudung);
            this.panel3.Controls.Add(this.txtSoghe);
            this.panel3.Controls.Add(this.txtTenban);
            this.panel3.Controls.Add(this.txtMaban);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(554, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 397);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã bàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sử dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số ghế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên bàn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái bàn:";
            // 
            // txtMaban
            // 
            this.txtMaban.Location = new System.Drawing.Point(113, 12);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(203, 27);
            this.txtMaban.TabIndex = 11;
            // 
            // txtTenban
            // 
            this.txtTenban.Location = new System.Drawing.Point(113, 61);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(203, 27);
            this.txtTenban.TabIndex = 12;
            // 
            // txtSoghe
            // 
            this.txtSoghe.Location = new System.Drawing.Point(113, 109);
            this.txtSoghe.Name = "txtSoghe";
            this.txtSoghe.Size = new System.Drawing.Size(203, 27);
            this.txtSoghe.TabIndex = 13;
            // 
            // txtNgaysudung
            // 
            this.txtNgaysudung.Location = new System.Drawing.Point(113, 163);
            this.txtNgaysudung.Name = "txtNgaysudung";
            this.txtNgaysudung.Size = new System.Drawing.Size(203, 27);
            this.txtNgaysudung.TabIndex = 14;
            // 
            // txtTrangthaiban
            // 
            this.txtTrangthaiban.Location = new System.Drawing.Point(113, 215);
            this.txtTrangthaiban.Name = "txtTrangthaiban";
            this.txtTrangthaiban.Size = new System.Drawing.Size(203, 27);
            this.txtTrangthaiban.TabIndex = 15;
            // 
            // frmQuanlyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 502);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtTrangthaiban;
        private System.Windows.Forms.TextBox txtNgaysudung;
        private System.Windows.Forms.TextBox txtSoghe;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.Label label5;
    }
}