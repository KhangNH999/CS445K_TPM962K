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
    public partial class frmMain : Form
    {
        private TaiKhoanLogin dntaikhoan;
        public TaiKhoanLogin DnTaiKhoan
        {
            get { return dntaikhoan; }
            set { dntaikhoan = value; PhanQuyen(dntaikhoan.MaLoaiTK); }
        }
        private double total;
        public frmMain(TaiKhoanLogin tk)
        {
            InitializeComponent();
            this.DnTaiKhoan = tk;
            LoadBan();
            LoadCategory();
            LoadComboboxTable(cbChuyenBan);
        }

        void PhanQuyen(int maloaitk)
        {
            adminToolStripMenuItem.Visible = maloaitk == 0;
        }

        private void quảnLýDanhMụcĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDmdouong f = new frmDmdouong();
            f.ShowDialog();
        }

        private void quảnLýĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDouong f = new frmDouong();
            f.ShowDialog();
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlyban f = new frmQuanlyban();
            f.ShowDialog();
        }

        private void quảnLýThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlythongke f = new frmQuanlythongke();
            f.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlytaikhoan f = new frmQuanlytaikhoan();
            f.ShowDialog();
        }

        private void quảnLýKhuyễnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlykhuyenmai f = new frmQuanlykhuyenmai();
            f.ShowDialog();
        }

        private void quảnLýTàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlytaikhoancanhan f = new frmQuanlytaikhoancanhan();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ban table = lvBill.Tag as Ban;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);
            if (idBill > 0)//có bill thì mới xuất hiện form thanh toán
            {
                frmThanhToan f = new frmThanhToan();
                f.Idban = table.MaBan;
                f.TotalPrice = total;
                f.ShowDialog();
            }
            nmgiamgia.Value = 0;
            LoadBan();
        }

        private void quảnLýHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanlyhoadon f = new frmQuanlyhoadon();
            f.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemhoadon f = new frmXemhoadon();
            f.ShowDialog();
        }
        //Load bàn 
        void LoadBan()
        {
            flpBan.Controls.Clear();
            List<Ban> tableList = BanDAO.Instance.LoadDanhSachBan();
            foreach (Ban item in tableList)
            {
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight };//Tạo ra các button 

                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai; //Gán dữ liệu vào các button
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua; //Tô màu 
                        break;
                    default:
                        btn.BackColor = Color.LightPink; //Tô màu
                        break;
                }
                flpBan.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int maBan = ((sender as Button).Tag as Ban).MaBan;
            string tenban = ((sender as Button).Tag as Ban).TenBan;
            lvBill.Tag = (sender as Button).Tag;
            textBox1.Text = tenban;
            ShowBill(maBan);
        }

        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<WinFormsApp_Coffee.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            double totalPrice = 0;
            foreach (WinFormsApp_Coffee.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Food.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("#,###"));
                lsvItem.SubItems.Add(item.Totalprice.ToString("#,###"));
                totalPrice += item.Totalprice;
                lvBill.Items.Add(lsvItem);
            }
            total = totalPrice;
        }
        void LoadCategory()
        {
            List<DMDoUong> listCategory = DanhmucdouongDAO.Instance.GetListCategory();
            cbDMDouong.DataSource = listCategory;
            cbDMDouong.DisplayMember = "tendanhmuc";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = DouongDAO.Instance.GetFoodByCategoryID(id);
            cbDouong.DataSource = listFood;
            cbDouong.DisplayMember = "tendouong";
        }

        private void cbDMDouong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            DMDoUong selected = cb.SelectedItem as DMDoUong;
            id = selected.MaDanhMuc;

            LoadFoodListByCategoryID(id);
        }

        private void btndatdouong_Click(object sender, EventArgs e)
        {
            Ban table = lvBill.Tag as Ban;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);
            int foodID = (cbDouong.SelectedItem as Food).Madouong;
            int count = (int)numupSL.Value;
            double tlgiamgia = (double)nmgiamgia.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.MaBan);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count, tlgiamgia);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count, tlgiamgia);
            }

            ShowBill(table.MaBan);
            LoadBan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ban table = lvBill.Tag as Ban;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.MaBan);
            int foodID = (cbDouong.SelectedItem as Food).Madouong;
            int count = (int)numupSL.Value;
            BillInfoDAO.Instance.DeleteBillInfo(idBill, foodID, count);
            ShowBill(table.MaBan);
            LoadBan();
        }
        //Load combobox table
        void LoadComboboxTable(ComboBox cb)
        {
            cbChuyenBan.DataSource = BanDAO.Instance.LoadDanhSachBan();
            cbChuyenBan.DisplayMember = "tenban";
        }
    }
}
