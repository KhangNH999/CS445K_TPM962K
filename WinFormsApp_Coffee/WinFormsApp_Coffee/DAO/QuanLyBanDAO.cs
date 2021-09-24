using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class QuanLyBanDAO
    {
        //Thiết kế patern Singleton cho QuanLyBanDAO
        private static QuanLyBanDAO instance;
        public static QuanLyBanDAO Instance
        {
            get { if (instance == null) instance = new QuanLyBanDAO(); return QuanLyBanDAO.instance; }
            private set { QuanLyBanDAO.instance = value; }
        }
        private QuanLyBanDAO() { }
        //Phương thức lấy danh sách bàn từ DataTable
        /*
         Trước hết phải tạo thủ tục
         CREATE PROC USP_LayDanhSachBan
         AS
        SELECT maban, tenban, soghe, ngaybdsudung, 
        case trangthaiban 
        when 0 then N'Trống' 
        when 1 then N'Có người' end as trangthaiban FROM dbo.BAN       
         */
        public List<Ban> loadDanhSachBan()
        {
            List<Ban> danhSachBan = new List<Ban>();
            DataTable data = clsDB.Instance.execQuery("USP_LayDanhSachBan");//Lấy thủ tục từ SQL server
            foreach(DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                danhSachBan.Add(ban);
            }
            return danhSachBan;
        }
        //Phương thức thêm bàn vào cơ sở dữ liệu
        public bool themBan(int maban, string tenban, int soghe, DateTime ngaybd, int trangthai)
        {
            string query = string.Format("INSERT dbo.BAN (maban, tenban, soghe, ngaybdsudung, trangthaiban) VALUES ( {0} , N'{1}' , {2} , '{3}', {4})", maban, tenban, soghe, ngaybd, trangthai);
            int result = clsDB.Instance.execNonQuery(query);
            return result > 0;
        }
        //Phương thức kiểm tra bàn có tồn tại trong csdl hay ko?
        public bool kiemTraBanTonTai(int maban)
        {
            DataTable tb = clsDB.Instance.execQuery("select * from dbo.ban where maban=" + maban + "");
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Phương thức sửa thông tin bàn
        /*
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo thủ tục
            create proc USP_SuaThongTinBan
            @maban int,
            @tenban nvarchar(100),
            @soghe int,
            @ngaybd datetime,
            @trangthai int
            as 
                begin 
                    update dbo.BAN set tenban = @tenban , soghe = @soghe , ngaybdsudung = @ngaybd , trangthaiban = @trangthai where maban = @maban
                end          
         sau đó tạo phương thức xác nhận sửa thông tin bàn  
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec USP_SuaThongTinBan
         */
        public bool suaThongTinBan(int maban, string tenban, int soghe, DateTime ngaybd, int trangthai)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaThongTinBan @maban , @tenban , @soghe , @ngaybd , @trangthai", new object[] { maban, tenban, soghe, ngaybd, trangthai });
            return result > 0;
        }
        //Phương thức xóa bàn
        /*
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo
         create proc USP_Xoaban
         @maban int
         as 
            begin 
	            delete from dbo.ban where maban = @maban
         end
         sau đó tạo phương thức xác nhận xóa bàn USP_Xoaban
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec USP_Xoaban
         */
        public bool xoaBan(int maban)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_Xoaban @maban", new object[] { maban });
            return result > 0;
        }
    }
}
