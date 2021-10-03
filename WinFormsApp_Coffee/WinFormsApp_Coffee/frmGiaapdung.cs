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
    public partial class frmGiaapdung : Form
    {
        public frmGiaapdung()
        {
            InitializeComponent();
            loadGia();       
        }

        //phương thức load bàn lên datagridview
        void loadGia()
        {
            dgvGiaapdung.DataSource = GiaApDungDAO.Instance.loadGiaAD();
            cbtrangthai.SelectedIndex = 0;
        }
        //phương thức xóa dữ liệu có trong textbox, dataTimePicker, Combobox
        void xoaDuLieu()
        {
            txtMadotgia.Clear();
            txtGiaban.Clear();
            dateBD.Value = DateTime.Now;
            cbtrangthai.SelectedIndex = 0;
            txtMadotgia.Focus();
        }
        //Tạo sự kiện thêm dot gia
        private void btnThemdotgia_Click(object sender, EventArgs e)
        {
            if (txtGiaban.Text == "" || cbtrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                double giaban = double.Parse(txtGiaban.Text);
                DateTime ngay = dateBD.Value;
                int trangthai = cbtrangthai.SelectedIndex;
                    if (GiaApDungDAO.Instance.themgiaad(giaban, ngay, trangthai))//Gọi phương thức thêm bàn từ GiaApDungDAO
                    {
                        MessageBox.Show("Thêm giá thành công");
                        loadGia();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm giá thất bại");
                    }               
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Phương thức xử lý khi kích chuột vào datagridview tự động dữ liệu sẽ hiện lên textbox
        private void dgvGiaapdung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMadotgia.Text = dgvGiaapdung.Rows[e.RowIndex].Cells[0].Value + "";
            txtGiaban.Text = dgvGiaapdung.Rows[e.RowIndex].Cells[1].Value + "";
            dateBD.Value = Convert.ToDateTime(dgvGiaapdung.Rows[e.RowIndex].Cells[2].Value);
            cbtrangthai.SelectedItem = dgvGiaapdung.Rows[e.RowIndex].Cells[3].Value + "";
        }

        private void btnKhoadotgia_Click(object sender, EventArgs e)
        {
            if (txtMadotgia.Text == "" || txtGiaban.Text == "" || cbtrangthai.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào đợt muốn khóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try //try catch để bắt lỗi nếu nhập sai kiểu dữ liệu
            {
                int ma = Int32.Parse(txtMadotgia.Text);
                double giaban = double.Parse(txtGiaban.Text);
                DateTime ngay = dateBD.Value;
                int trangthai = cbtrangthai.SelectedIndex;
                if (GiaApDungDAO.Instance.suaThongTinKhoa(ma, giaban, ngay, trangthai))//Gọi phương thức sửa bàn từ QuanLyBanDAO
                {
                    MessageBox.Show("khóa thông tin đợt giá thành công");
                    loadGia();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("khóa thất bại");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
