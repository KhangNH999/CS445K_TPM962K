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
    public partial class frmChiTietDotGia : Form
    {
        public frmChiTietDotGia()
        {
            InitializeComponent();
            loadDS();
            
        }
        void xoaDuLieu()
        {
            txtMadotgia.Clear();
            txtGiaban.Clear();
            txtMadouong.Clear();
            txtMadotgia.Focus();
        }
        void loadDS()
        {
             dgvChitietdotgia.DataSource = ChiTietDotGiaDAO.Instance.loadChiTietDotGia();
        }
        private void btnThemdouong_Click(object sender, EventArgs e)
        {
            if (txtMadotgia.Text == "" || txtMadouong.Text == "" || txtGiaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int madotgia = Int32.Parse(txtMadotgia.Text);
                int madouong = Int32.Parse(txtMadouong.Text);
                double giaban = double.Parse(txtGiaban.Text);
                if (ChiTietDotGiaDAO.Instance.kiemTraMaDotGiaTonTai(madotgia) == false) //Kiểm tra bàn tồn tại
                {
                    MessageBox.Show("Đợt mã này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (ChiTietDotGiaDAO.Instance.themChiTietDoUong(madotgia, madouong, giaban))//Gọi phương thức thêm bàn từ QuanLyBanDAO
                    {
                        MessageBox.Show("Thêm đồ uống thành công");
                        //loadDouong();
                        loadDS();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm đồ uống thất bại");
                    }
                }
            }           
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự hoặc mã đồ uống không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //void loadDMDouong()
        //{
        //    cbMadouong.DataSource = QuanLyDoUongDAO.Instance.loadDMDouong();
        //    cbbMadanhmu.DisplayMember = "tendanhmuc";
        //    cbbMadanhmuc.ValueMember = "madanhmuc";
        //}

        private void dgvChitietdotgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMadotgia.Text = dgvChitietdotgia.Rows[e.RowIndex].Cells[1].Value + "";
            txtMadouong.Text = dgvChitietdotgia.Rows[e.RowIndex].Cells[0].Value + "";
            txtGiaban.Text = dgvChitietdotgia.Rows[e.RowIndex].Cells[2].Value + "";
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
        }

        private void btnSuadouong_Click(object sender, EventArgs e)
        {
            if (txtMadotgia.Text == "" || txtMadouong.Text == "" || txtGiaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào mã muốn sửa thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int madotgia = Int32.Parse(txtMadotgia.Text);
                int madouong = Int32.Parse(txtMadouong.Text);
                double giaban = double.Parse(txtGiaban.Text);
                if (giaban < 0)
                {
                    MessageBox.Show("Vui lòng nhập giá trị lớn hơn 0 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ChiTietDotGiaDAO.Instance.suaChiTietDoUong(madotgia, madouong, giaban))//Gọi phương thức sửa bàn từ QuanLyBanDAO
                {
                    MessageBox.Show("Sửa giá thành công");
                    loadDS();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Sửa giá thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoadouong_Click(object sender, EventArgs e)
        {
            if (txtMadotgia.Text == "" || txtMadouong.Text == "" || txtGiaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào mã muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa bàn ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                int madotgia = Int32.Parse(txtMadotgia.Text);
                int madouong = Int32.Parse(txtMadouong.Text);

                if (ChiTietDotGiaDAO.Instance.xoaChiTietDoUong(madotgia, madouong))//Gọi phương thức xóa bàn từ DAO
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDS();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
