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
    public partial class frmQuanlyban : Form
    {
        public frmQuanlyban()
        {
            InitializeComponent();
            loadTable();
        }
        //Hiển thị danh sách bàn
        void loadTable()
        {
            dgvQuanlyban.DataSource = TableManagerDAO.Instance.loadTableList();      
        }
        //Tạo sự kiện thêm bàn
        //Exception: dùng để bắt lỗi nhập sai dữ liệu
        private void btnThemban_Click(object sender, EventArgs e)
        {
            if (txttenban.Text == "" || txtTang.Text == "" || txttenban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }               
            try
            {
                string tenban = txttenban.Text;
                int tang = Int32.Parse(txtTang.Text);
                string trangthai = cbtrangthai.Text;
                if (TableManagerDAO.Instance.checkExistTable(tenban)) //Kiểm tra bàn tồn tại
                {
                    MessageBox.Show("" + tenban + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AddTable(tenban, trangthai, tang);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Phương thức xử lý thêm bàn
        void AddTable(string tenban, string trangthai, int tang)
        {
            if (TableManagerDAO.Instance.InsertTable(tenban, trangthai, tang))
            {
                MessageBox.Show("Thêm bàn thành công");
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }
            loadTable();
        }
        //Phương thức xử lý khi kích chuột vào datagridview tự động dữ liệu sẽ hiện lên textbox
        private void dgvQuanlyban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtId.Text = dgvQuanlyban.Rows[e.RowIndex].Cells[0].Value + "";
            txttenban.Text = dgvQuanlyban.Rows[e.RowIndex].Cells[1].Value + "";
            txtTang.Text = dgvQuanlyban.Rows[e.RowIndex].Cells[3].Value + "";
            cbtrangthai.SelectedItem = dgvQuanlyban.Rows[e.RowIndex].Cells[2].Value + "";
        }
        //Tạo sự kiện sửa thông tin bàn
        private void btnSuaban_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txttenban.Text == "" || txtTang.Text == "" || txttenban.Text == "")
            {
                MessageBox.Show("Vui lòng click chuột vào bàn bạn muốn sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TableManagerDAO.Instance.checkExistTable(txttenban.Text)) //Kiểm tra bàn tồn tại
            {
                MessageBox.Show("" + txttenban.Text + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (TableManagerDAO.Instance.editTable(Int32.Parse(txtId.Text), txttenban.Text, Int32.Parse(txtTang.Text), this.cbtrangthai.SelectedItem.ToString()))
                {
                    MessageBox.Show("Sửa thông tin bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTable();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Tạo sự kiện xóa bàn
        private void btnXoaban_Click(object sender, EventArgs e)
        {
            //Nếu chưa nhập thông tin trong textbox thì sẽ hiển thị thông báo và return
            if (txtId.Text == "" || txttenban.Text == "" || txtTang.Text == "" || txttenban.Text == "")
            {
                MessageBox.Show("Vui lòng click chuột vào bàn bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Hiển thị form xác nhận có xóa bàn hay không
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes) 
            {
                return;
            }
            else
            {
                if (TableManagerDAO.Instance.deleteTable(Int32.Parse(txtId.Text)))
                {
                    MessageBox.Show("Xóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTable();
                }
                else
                {
                    MessageBox.Show("Xóa bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
