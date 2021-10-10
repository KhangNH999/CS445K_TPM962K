using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp_Coffee.DAO;
using WinFormsApp_Coffee.DTO;

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
            double tongcong = 0;
            dgvQlhoadon.DataSource = QuanLyHoaDonDAO.Instance.loadDanhSachHDTheoNV(matk);
            string SQL = "SELECT a.mahoadon, b.tennv, a.giolap, c.tenban, case trangthaihoadon when 0 then N'Chưa thanh toán' when 1 then N'Đã thanh toán' when 2 then N'Đã khóa' end as trangthaihoadon, SUM(d.tongtien)as Tongtien FROM dbo.HOADON as a, dbo.TAIKHOAN as b, dbo.BAN as c, dbo.CHITIETHOADON as d where a.mataikhoan = b.mataikhoan and a.maban = c.maban and a.mahoadon = d.mahoadon and a.mataikhoan = " + matk + " and a.trangthaihoadon = 1 group by a.mahoadon, b.tennv, a.giolap, c.tenban, trangthaihoadon";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            foreach (DataRow item in dt.Rows)
            {
                HoadonChoNV tk = new HoadonChoNV(item);
                tongcong += tk.TongTien;
            }
            txtTong.Text = tongcong.ToString("#,###");
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
            double tong = 0;
            DateTime ngay1 = dtNgay.Value;
            DateTime ngay2 = dtngay1.Value;
            dgvQlhoadon.DataSource = QuanLyHoaDonDAO.Instance.loadDanhSachHDTheoNgay(matk, ngay1, ngay2);
            string SQL = "SELECT a.mahoadon, b.tennv, a.giolap, c.tenban, case trangthaihoadon when 0 then N'Chưa thanh toán' when 1 then N'Đã thanh toán' when 2 then N'Đã khóa' end as trangthaihoadon, SUM(d.tongtien) as Tongtien FROM dbo.HOADON as a, dbo.TAIKHOAN as b, dbo.BAN as c, dbo.CHITIETHOADON as d where a.mataikhoan = b.mataikhoan and a.maban = c.maban and a.mahoadon = d.mahoadon and a.mataikhoan = " + matk + " and a.giolap >= '" + ngay1 + "' and a.giolap <= '" + ngay2 + "' and a.trangthaihoadon = 1 group by a.mahoadon, b.tennv, a.giolap, c.tenban, trangthaihoadon";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            foreach (DataRow item in dt.Rows)
            {
                HoadonChoNV tk = new HoadonChoNV(item);
                tong += tk.TongTien;
            }
            txtTong.Text = tong.ToString("#,###");
        }
    }
}
