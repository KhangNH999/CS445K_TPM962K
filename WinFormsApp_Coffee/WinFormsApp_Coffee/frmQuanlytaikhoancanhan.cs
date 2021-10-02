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
    public partial class frmQuanlytaikhoancanhan : Form
    {
        private TaiKhoanLogin dnTaiKhoan;

        public TaiKhoanLogin DnTaiKhoan
        {
            get { return dnTaiKhoan; }
            set { dnTaiKhoan = value; ChangeTaiKhoan(dnTaiKhoan); }
        }

        public frmQuanlytaikhoancanhan(TaiKhoanLogin tk)
        {

            InitializeComponent();
           
            this.DnTaiKhoan = tk;

        }

        void ChangeTaiKhoan(TaiKhoanLogin tk)
        {
            txtTendangnhap.Text = DnTaiKhoan.TenDangNhap;
            txtMatk.Text = DnTaiKhoan.MaTaiKhoan.ToString();
            txtTen.Text = DnTaiKhoan.TenNV;
            dtngaysinh.Value = DnTaiKhoan.NgaySinh;
            txtGioitinh.Text = DnTaiKhoan.GioiTinh;
            txtCmnd.Text = DnTaiKhoan.CMnd;
            txtEmail.Text = DnTaiKhoan.Email;
            txtSodienthoai.Text = DnTaiKhoan.Sdt;
        }
       

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            frmDoimatkhau f = new frmDoimatkhau();
            f.ShowDialog();
        }
        void capnhapthongtincanhan()
        {

            if (txtMatk.Text == "" || txtTen.Text == "" || txtGioitinh.Text == "" || txtCmnd.Text == "" || txtEmail.Text == "" || txtSodienthoai.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                int mataikhoan = Int32.Parse(txtMatk.Text);
                string tennv = txtTen.Text;
                DateTime ngaysinh = dtngaysinh.Value;
                string gioitinh = txtGioitinh.Text;
                string cmnd = txtCmnd.Text;
                string email = txtEmail.Text;
                string sdt = txtSodienthoai.Text;
               

                    if (CapNhapTaiKhoanDAO.Instance.capnhapthongtincanhan(mataikhoan, tennv, ngaysinh, gioitinh, cmnd, email, sdt))
                    {

                        MessageBox.Show("Cập nhập thành công");
                  
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại !");
                    }
                }
            

            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


            private void btnCapnhat_Click(object sender, EventArgs e)
            {
            capnhapthongtincanhan();
            
            }
        }
    }





