
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
            this.btnKhoadouong = new System.Windows.Forms.Button();
            this.btnXoadouong = new System.Windows.Forms.Button();
            this.btnSuadouong = new System.Windows.Forms.Button();
            this.btnThemdouong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvQuanlyban = new System.Windows.Forms.DataGridView();
            this.txtIDban = new System.Windows.Forms.TextBox();
            this.txttenban = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyban)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKhoadouong
            // 
            this.btnKhoadouong.Location = new System.Drawing.Point(397, 4);
            this.btnKhoadouong.Name = "btnKhoadouong";
            this.btnKhoadouong.Size = new System.Drawing.Size(125, 63);
            this.btnKhoadouong.TabIndex = 3;
            this.btnKhoadouong.Text = "Khóa bàn";
            this.btnKhoadouong.UseVisualStyleBackColor = true;
            this.btnKhoadouong.Click += new System.EventHandler(this.btnKhoadouong_Click);
            // 
            // btnXoadouong
            // 
            this.btnXoadouong.Location = new System.Drawing.Point(266, 3);
            this.btnXoadouong.Name = "btnXoadouong";
            this.btnXoadouong.Size = new System.Drawing.Size(125, 63);
            this.btnXoadouong.TabIndex = 2;
            this.btnXoadouong.Text = "Xóa bàn";
            this.btnXoadouong.UseVisualStyleBackColor = true;
            this.btnXoadouong.Click += new System.EventHandler(this.btnXoadouong_Click);
            // 
            // btnSuadouong
            // 
            this.btnSuadouong.Location = new System.Drawing.Point(135, 4);
            this.btnSuadouong.Name = "btnSuadouong";
            this.btnSuadouong.Size = new System.Drawing.Size(125, 63);
            this.btnSuadouong.TabIndex = 1;
            this.btnSuadouong.Text = "Sửa bàn";
            this.btnSuadouong.UseVisualStyleBackColor = true;
            this.btnSuadouong.Click += new System.EventHandler(this.btnSuadouong_Click);
            // 
            // btnThemdouong
            // 
            this.btnThemdouong.Location = new System.Drawing.Point(4, 3);
            this.btnThemdouong.Name = "btnThemdouong";
            this.btnThemdouong.Size = new System.Drawing.Size(125, 63);
            this.btnThemdouong.TabIndex = 0;
            this.btnThemdouong.Text = "Thêm bàn";
            this.btnThemdouong.UseVisualStyleBackColor = true;
            this.btnThemdouong.Click += new System.EventHandler(this.btnThemdouong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoadouong);
            this.panel1.Controls.Add(this.btnXoadouong);
            this.panel1.Controls.Add(this.btnSuadouong);
            this.panel1.Controls.Add(this.btnThemdouong);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 70);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlyban);
            this.panel2.Location = new System.Drawing.Point(10, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 494);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvQuanlyban
            // 
            this.dgvQuanlyban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlyban.Location = new System.Drawing.Point(5, 2);
            this.dgvQuanlyban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQuanlyban.Name = "dgvQuanlyban";
            this.dgvQuanlyban.RowHeadersWidth = 62;
            this.dgvQuanlyban.RowTemplate.Height = 33;
            this.dgvQuanlyban.Size = new System.Drawing.Size(532, 489);
            this.dgvQuanlyban.TabIndex = 0;
            this.dgvQuanlyban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlyban_CellContentClick);
            // 
            // txtIDban
            // 
            this.txtIDban.Location = new System.Drawing.Point(4, 32);
            this.txtIDban.Name = "txtIDban";
            this.txtIDban.Size = new System.Drawing.Size(307, 27);
            this.txtIDban.TabIndex = 4;
            this.txtIDban.TextChanged += new System.EventHandler(this.txtIDban_TextChanged);
            // 
            // txttenban
            // 
            this.txttenban.Location = new System.Drawing.Point(4, 101);
            this.txttenban.Name = "txttenban";
            this.txttenban.Size = new System.Drawing.Size(307, 27);
            this.txttenban.TabIndex = 3;
            this.txttenban.TextChanged += new System.EventHandler(this.txttenban_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbtrangthai);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtIDban);
            this.panel3.Controls.Add(this.txttenban);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(561, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 494);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Location = new System.Drawing.Point(4, 173);
            this.cbtrangthai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(307, 28);
            this.cbtrangthai.TabIndex = 6;
            this.cbtrangthai.SelectedIndexChanged += new System.EventHandler(this.cbtrangthai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trạng thái";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên bàn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmQuanlyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 598);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanlyban";
            this.Text = "Quản lý bàn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyban)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKhoadouong;
        private System.Windows.Forms.Button btnXoadouong;
        private System.Windows.Forms.Button btnSuadouong;
        private System.Windows.Forms.Button btnThemdouong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvQuanlyban;
        private System.Windows.Forms.TextBox txtIDban;
        private System.Windows.Forms.TextBox txttenban;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtrangthai;
    }
}