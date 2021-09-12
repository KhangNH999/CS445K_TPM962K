
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
            this.btnKhoadouong = new System.Windows.Forms.Button();
            this.btnXoadouong = new System.Windows.Forms.Button();
            this.btnSuadouong = new System.Windows.Forms.Button();
            this.btnThemdouong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDmdouong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDdotgia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.cbbIDdanhmuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTendm = new System.Windows.Forms.TextBox();
            this.txtTendouong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGiaapdung = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDmdouong)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoadouong);
            this.panel1.Controls.Add(this.btnXoadouong);
            this.panel1.Controls.Add(this.btnSuadouong);
            this.panel1.Controls.Add(this.btnThemdouong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnKhoadouong
            // 
            this.btnKhoadouong.Location = new System.Drawing.Point(397, 4);
            this.btnKhoadouong.Name = "btnKhoadouong";
            this.btnKhoadouong.Size = new System.Drawing.Size(125, 63);
            this.btnKhoadouong.TabIndex = 3;
            this.btnKhoadouong.Text = "Khóa đồ uống";
            this.btnKhoadouong.UseVisualStyleBackColor = true;
            // 
            // btnXoadouong
            // 
            this.btnXoadouong.Location = new System.Drawing.Point(266, 4);
            this.btnXoadouong.Name = "btnXoadouong";
            this.btnXoadouong.Size = new System.Drawing.Size(125, 63);
            this.btnXoadouong.TabIndex = 2;
            this.btnXoadouong.Text = "Xóa đồ uống";
            this.btnXoadouong.UseVisualStyleBackColor = true;
            // 
            // btnSuadouong
            // 
            this.btnSuadouong.Location = new System.Drawing.Point(135, 4);
            this.btnSuadouong.Name = "btnSuadouong";
            this.btnSuadouong.Size = new System.Drawing.Size(125, 63);
            this.btnSuadouong.TabIndex = 1;
            this.btnSuadouong.Text = "Sửa đồ uống";
            this.btnSuadouong.UseVisualStyleBackColor = true;
            // 
            // btnThemdouong
            // 
            this.btnThemdouong.Location = new System.Drawing.Point(4, 4);
            this.btnThemdouong.Name = "btnThemdouong";
            this.btnThemdouong.Size = new System.Drawing.Size(125, 63);
            this.btnThemdouong.TabIndex = 0;
            this.btnThemdouong.Text = "Thêm đồ uống";
            this.btnThemdouong.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDmdouong);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 496);
            this.panel2.TabIndex = 2;
            // 
            // dgvDmdouong
            // 
            this.dgvDmdouong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDmdouong.Location = new System.Drawing.Point(4, 4);
            this.dgvDmdouong.Name = "dgvDmdouong";
            this.dgvDmdouong.RowHeadersWidth = 51;
            this.dgvDmdouong.RowTemplate.Height = 29;
            this.dgvDmdouong.Size = new System.Drawing.Size(532, 489);
            this.dgvDmdouong.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGiaapdung);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtGiaban);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtIDdotgia);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTrangthai);
            this.panel3.Controls.Add(this.cbbIDdanhmuc);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTendm);
            this.panel3.Controls.Add(this.txtTendouong);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(557, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 496);
            this.panel3.TabIndex = 3;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(4, 412);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(307, 27);
            this.txtGiaban.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giá bán";
            // 
            // txtIDdotgia
            // 
            this.txtIDdotgia.Location = new System.Drawing.Point(4, 359);
            this.txtIDdotgia.Name = "txtIDdotgia";
            this.txtIDdotgia.Size = new System.Drawing.Size(307, 27);
            this.txtIDdotgia.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID đợt giá";
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(4, 306);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(307, 27);
            this.txtTrangthai.TabIndex = 13;
            // 
            // cbbIDdanhmuc
            // 
            this.cbbIDdanhmuc.FormattingEnabled = true;
            this.cbbIDdanhmuc.Location = new System.Drawing.Point(4, 146);
            this.cbbIDdanhmuc.Name = "cbbIDdanhmuc";
            this.cbbIDdanhmuc.Size = new System.Drawing.Size(307, 28);
            this.cbbIDdanhmuc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trạng thái";
            // 
            // txtTendm
            // 
            this.txtTendm.Location = new System.Drawing.Point(4, 200);
            this.txtTendm.Name = "txtTendm";
            this.txtTendm.Size = new System.Drawing.Size(307, 27);
            this.txtTendm.TabIndex = 3;
            // 
            // txtTendouong
            // 
            this.txtTendouong.Location = new System.Drawing.Point(4, 253);
            this.txtTendouong.Name = "txtTendouong";
            this.txtTendouong.Size = new System.Drawing.Size(307, 27);
            this.txtTendouong.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID đồ uống";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID danh mục";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 115);
            this.panel4.TabIndex = 18;
            // 
            // btnGiaapdung
            // 
            this.btnGiaapdung.Location = new System.Drawing.Point(4, 455);
            this.btnGiaapdung.Name = "btnGiaapdung";
            this.btnGiaapdung.Size = new System.Drawing.Size(307, 29);
            this.btnGiaapdung.TabIndex = 19;
            this.btnGiaapdung.Text = "Thiết lập giá áp dụng";
            this.btnGiaapdung.UseVisualStyleBackColor = true;
            // 
            // frmDouong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 598);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDouong";
            this.Text = "frmDouong";
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
        private System.Windows.Forms.TextBox txtTendm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhoadouong;
        private System.Windows.Forms.ComboBox cbbIDdanhmuc;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTendouong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDdotgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGiaapdung;
    }
}