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
    public partial class frmXemhoadon : Form
    {
        private int mahoadon;
        private DateTime ngay;
        private string tennv;
        private string tenban;
        public frmXemhoadon()
        {
            InitializeComponent();
        }

        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Tenban { get => tenban; set => tenban = value; }

        void loadChiTietHD()
        {
            double tongcong = 0; 
            dgvChitiethoadon.DataSource = QuanLyHoaDonDAO.Instance.loadDanhSachChiTietHD(mahoadon);
            txtMHD.Text = mahoadon.ToString();
            txtngay.Text = ngay.ToString("dd/MM/yyyy");
            txtNhanVien.Text = tennv;
            txtTenBan.Text = tenban;
            string SQL = "select a.mahoadon, b.tendouong, a.soluong, a.giatien, a.tlgiamgia, a.tongtien from dbo.CHITIETHOADON as a, dbo.DOUONG as b where a.madouong = b.madouong and a.mahoadon = " + mahoadon + "";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            foreach (DataRow item in dt.Rows)
            {
                Chitiethoadon tk = new Chitiethoadon(item);
                tongcong += tk.Thanhtien;
            }
            txtTong.Text = tongcong.ToString("#,###");
        }

        private void frmXemhoadon_Load(object sender, EventArgs e)
        {
            loadChiTietHD();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
