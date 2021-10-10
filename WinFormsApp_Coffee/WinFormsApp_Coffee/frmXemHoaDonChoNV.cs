using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp_Coffee.DAO;

namespace WinFormsApp_Coffee
{
    public partial class frmXemHoaDonChoNV : Form
    {
        private int matk;

        public int Matk { get => matk; set => matk = value; }

        public frmXemHoaDonChoNV()
        {
            InitializeComponent();
        }
        void loadHD()
        {
            dgvQlhoadon.DataSource = QuanLyHoaDonDAO.Instance.loadDanhSachHDTheoNV(matk);
        }

        private void dgvQlhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMaHD.Text = dgvQlhoadon.Rows[e.RowIndex].Cells[0].Value + "";
            txtNV.Text = dgvQlhoadon.Rows[e.RowIndex].Cells[1].Value + "";
            txtNgay.Text = dgvQlhoadon.Rows[e.RowIndex].Cells[2].Value + "";
            txtTenban.Text = dgvQlhoadon.Rows[e.RowIndex].Cells[3].Value + "";
        }

        private void frmXemHoaDonChoNV_Load(object sender, EventArgs e)
        {
            loadHD();
        }

        private void btnXemhoadon_Click(object sender, EventArgs e)
        {
            frmXemhoadon f = new frmXemhoadon();
            if (txtMaHD.Text == "" || txtTenban.Text == "" || txtNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            f.Mahoadon = Int32.Parse(txtMaHD.Text);
            f.Ngay = Convert.ToDateTime(txtNgay.Text);
            f.Tennv = txtNV.Text;
            f.Tenban = txtTenban.Text;
            f.ShowDialog();
        }

        private void btnTHongke_Click(object sender, EventArgs e)
        {
            DateTime ngay1 = dtNgay.Value;
            DateTime ngay2 = dtngay1.Value;
            dgvQlhoadon.DataSource = QuanLyHoaDonDAO.Instance.loadDanhSachHDTheoNgay(matk, ngay1, ngay2);
        }
    }
}
