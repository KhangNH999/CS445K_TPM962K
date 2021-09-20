
namespace WinFormsApp_Coffee
{
    partial class frmGiaapdung
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKhoadotgia = new System.Windows.Forms.Button();
            this.btnThemdotgia = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTrangthaigia = new System.Windows.Forms.TextBox();
            this.txtNgaybdapdung = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtMadotgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvGiaapdung = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaapdung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnKhoadotgia);
            this.panel4.Controls.Add(this.btnThemdotgia);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 61);
            this.panel4.TabIndex = 2;
            // 
            // btnKhoadotgia
            // 
            this.btnKhoadotgia.Location = new System.Drawing.Point(135, 4);
            this.btnKhoadotgia.Name = "btnKhoadotgia";
            this.btnKhoadotgia.Size = new System.Drawing.Size(125, 54);
            this.btnKhoadotgia.TabIndex = 1;
            this.btnKhoadotgia.Text = "Khóa đợt giá";
            this.btnKhoadotgia.UseVisualStyleBackColor = true;
            // 
            // btnThemdotgia
            // 
            this.btnThemdotgia.Location = new System.Drawing.Point(4, 4);
            this.btnThemdotgia.Name = "btnThemdotgia";
            this.btnThemdotgia.Size = new System.Drawing.Size(125, 54);
            this.btnThemdotgia.TabIndex = 0;
            this.btnThemdotgia.Text = "Thêm đợt giá";
            this.btnThemdotgia.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTrangthaigia);
            this.panel3.Controls.Add(this.txtNgaybdapdung);
            this.panel3.Controls.Add(this.txtGiaban);
            this.panel3.Controls.Add(this.txtMadotgia);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(464, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 351);
            this.panel3.TabIndex = 1;
            // 
            // txtTrangthaigia
            // 
            this.txtTrangthaigia.Location = new System.Drawing.Point(112, 162);
            this.txtTrangthaigia.Name = "txtTrangthaigia";
            this.txtTrangthaigia.Size = new System.Drawing.Size(193, 27);
            this.txtTrangthaigia.TabIndex = 7;
            // 
            // txtNgaybdapdung
            // 
            this.txtNgaybdapdung.Location = new System.Drawing.Point(112, 109);
            this.txtNgaybdapdung.Name = "txtNgaybdapdung";
            this.txtNgaybdapdung.Size = new System.Drawing.Size(193, 27);
            this.txtNgaybdapdung.TabIndex = 6;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(112, 59);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(193, 27);
            this.txtGiaban.TabIndex = 5;
            // 
            // txtMadotgia
            // 
            this.txtMadotgia.Location = new System.Drawing.Point(112, 11);
            this.txtMadotgia.Name = "txtMadotgia";
            this.txtMadotgia.Size = new System.Drawing.Size(193, 27);
            this.txtMadotgia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá bán:";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvGiaapdung);
            this.panel2.Location = new System.Drawing.Point(4, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 351);
            this.panel2.TabIndex = 0;
            // 
            // dgvGiaapdung
            // 
            this.dgvGiaapdung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaapdung.Location = new System.Drawing.Point(4, 4);
            this.dgvGiaapdung.Name = "dgvGiaapdung";
            this.dgvGiaapdung.RowHeadersWidth = 51;
            this.dgvGiaapdung.RowTemplate.Height = 29;
            this.dgvGiaapdung.Size = new System.Drawing.Size(446, 344);
            this.dgvGiaapdung.TabIndex = 0;
            // 
            // frmGiaapdung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmGiaapdung";
            this.Text = "Giá áp dụng";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaapdung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKhoadotgia;
        private System.Windows.Forms.Button btnThemdotgia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTrangthaigia;
        private System.Windows.Forms.TextBox txtNgaybdapdung;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtMadotgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvGiaapdung;
    }
}