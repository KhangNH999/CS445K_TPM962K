using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class TableManagerDAO
    {
        //Thiết kế patern Singleton cho TableManagerDAO
        private static TableManagerDAO instance;
        public static TableManagerDAO Instance
        {
            get { if (instance == null) instance = new TableManagerDAO(); return TableManagerDAO.instance; }
            private set { TableManagerDAO.instance = value; }
        }
        private TableManagerDAO() { }
        //Phương thức lấy danh sách bàn từ DataTable
        public List<Table> loadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = clsDB.Instance.execQuery("USP_LayDanhSachBan");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        //Phương thức thêm bàn vào cơ sở dữ liệu
        public bool InsertTable(string tenban, string trangthai, int tang)
        {
            string query = string.Format("INSERT dbo.ban (tenban, trangthaiban, tang, ngaybdsudung) VALUES  ( N'{0}', N'{1}', {2}, GETDATE())", tenban, trangthai, tang);
            int result = clsDB.Instance.execNonQuery(query);
            return result > 0;
        }
        //Phương thức kiểm tra bàn có tồn tại hay ko?
        public bool checkExistTable(string tenban)
        {
            DataTable tb = clsDB.Instance.execQuery("select * from dbo.ban where tenban='" + tenban+"'");
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
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo 
            create proc PROC_EditTable
            @idban int,
            @ten nvarchar(100),
            @trangthai nvarchar(100),
            @tang int
            as 
                begin 
                    update dbo.ban set tenban = @ten , trangthaiban = @trangthai , tang = @tang where idban = @idban
            end      
         sau đó tạo phương thức xác nhận sửa thông tin bàn editTable 
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec PROC_EditTable với 4 tham số @idban , @ten , @trangthai , @tang
         */
        public bool editTable(int id, string tenban, int tang, string trangthai)
        {
            int result = clsDB.Instance.execNonQuery("exec PROC_EditTable @idban , @ten , @trangthai , @tang", new object[] { id, tenban, trangthai, tang });
            return result > 0; 
        }
        //Phương thức xóa bàn
        /*
         Cũng tương tự như editTable
         Muốn tạo phương thức này trước hết cần phải vào SQl Server tạo
         create proc PROC_DeleteTable
         @id int
            as 
            begin 
	            delete from dbo.ban where idban = @id
            end
         sau đó tạo phương thức xác nhận xóa bàn deleteTable 
         biến result dùng để trả số hàng khi thực thi câu lệnh truy vấn exec PROC_DeleteTable với 1 tham số @idban
         */
        public bool deleteTable(int id)
        {
            int result = clsDB.Instance.execNonQuery("exec PROC_DeleteTable @idban", new object[] {id});
            return result > 0;
        }
    }
}
