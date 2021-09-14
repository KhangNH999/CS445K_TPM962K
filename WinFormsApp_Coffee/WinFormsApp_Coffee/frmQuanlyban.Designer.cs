
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyban)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKhoadouong
            // 
            this.btnKhoadouong.Location = new System.Drawing.Point(496, 5);
            this.btnKhoadouong.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhoadouong.Name = "btnKhoadouong";
            this.btnKhoadouong.Size = new System.Drawing.Size(156, 79);
            this.btnKhoadouong.TabIndex = 3;
            this.btnKhoadouong.Text = "Khóa bàn";
            this.btnKhoadouong.UseVisualStyleBackColor = true;
            // 
            // btnXoadouong
            // 
            this.btnXoadouong.Location = new System.Drawing.Point(332, 4);
            this.btnXoadouong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoadouong.Name = "btnXoadouong";
            this.btnXoadouong.Size = new System.Drawing.Size(156, 79);
            this.btnXoadouong.TabIndex = 2;
            this.btnXoadouong.Text = "Xóa bàn";
            this.btnXoadouong.UseVisualStyleBackColor = true;
            // 
            // btnSuadouong
            // 
            this.btnSuadouong.Location = new System.Drawing.Point(169, 5);
            this.btnSuadouong.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuadouong.Name = "btnSuadouong";
            this.btnSuadouong.Size = new System.Drawing.Size(156, 79);
            this.btnSuadouong.TabIndex = 1;
            this.btnSuadouong.Text = "Sửa bàn";
            this.btnSuadouong.UseVisualStyleBackColor = true;
            // 
            // btnThemdouong
            // 
            this.btnThemdouong.Location = new System.Drawing.Point(5, 4);
            this.btnThemdouong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemdouong.Name = "btnThemdouong";
            this.btnThemdouong.Size = new System.Drawing.Size(156, 79);
            this.btnThemdouong.TabIndex = 0;
            this.btnThemdouong.Text = "Thêm bàn";
            this.btnThemdouong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoadouong);
            this.panel1.Controls.Add(this.btnXoadouong);
            this.panel1.Controls.Add(this.btnSuadouong);
            this.panel1.Controls.Add(this.btnThemdouong);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 88);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvQuanlyban);
            this.panel2.Location = new System.Drawing.Point(12, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 618);
            this.panel2.TabIndex = 3;
            // 
            // dgvQuanlyban
            // 
            this.dgvQuanlyban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlyban.Location = new System.Drawing.Point(6, 3);
            this.dgvQuanlyban.Name = "dgvQuanlyban";
            this.dgvQuanlyban.RowHeadersWidth = 62;
            this.dgvQuanlyban.RowTemplate.Height = 33;
            this.dgvQuanlyban.Size = new System.Drawing.Size(665, 611);
            this.dgvQuanlyban.TabIndex = 0;
            // 
            // txtIDban
            // 
            this.txtIDban.Location = new System.Drawing.Point(5, 40);
            this.txtIDban.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDban.Name = "txtIDban";
            this.txtIDban.Size = new System.Drawing.Size(383, 31);
            this.txtIDban.TabIndex = 4;
            // 
            // txttenban
            // 
            this.txttenban.Location = new System.Drawing.Point(5, 126);
            this.txttenban.Margin = new System.Windows.Forms.Padding(4);
            this.txttenban.Name = "txttenban";
            this.txttenban.Size = new System.Drawing.Size(383, 31);
            this.txttenban.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbtrangthai);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtIDban);
            this.panel3.Controls.Add(this.txttenban);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(701, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 618);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Location = new System.Drawing.Point(5, 216);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(383, 33);
            this.cbtrangthai.TabIndex = 6;
            // 
            // frmQuanlyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 748);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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