using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using WinFormsApp_Coffee.DAO;

namespace WinFormsApp_Coffee
{
    public partial class frmThanhToan : Form
    {
        private int idban;
        private double totalPrice;

        public frmThanhToan()
        {
            InitializeComponent();
        }
        //Lấy dữ liệu bên form chính
        public int Idban { get => idban; set => idban = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        //Load lên datagrid
        void load()
        {
            dgvThanhToan.DataSource = MenuDAO.Instance.GetListMenuByTable(idban);
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = totalPrice.ToString("c", culture);
        }
        //Tạo sự kiện thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(idban);

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn này không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill);
                    this.Hide();
                }
            }

        }
        private void frmThanhToan_Load_1(object sender, EventArgs e)
        {
            load();
        }
    }
}
