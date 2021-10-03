using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    class GiaApDungDAO
    {
        //Thiết kế patern Singleton cho GiaApDungDAO
        private static GiaApDungDAO instance;
        public static GiaApDungDAO Instance
        {
            get { if (instance == null) instance = new GiaApDungDAO(); return GiaApDungDAO.instance; }
            private set { GiaApDungDAO.instance = value; }
        }
        private GiaApDungDAO() { }
        //Phương thức lấy danh sách bàn từ DataTable
        /*
         Trước hết phải tạo thủ tục
         Create PROC [dbo].[USP_LayGiaApDung]
         AS
        SELECT madotgia, giaban, ngaybdban, 
        case trangthaigia
        when 0 then N'Chưa áp dụng' 
        when 1 then N'Đã áp dụng' end as trangthaigia FROM dbo.GIATHEODOT  
         */
        public List<GiaAD> loadGiaAD()
        {
            List<GiaAD> giaApDung = new List<GiaAD>();
            DataTable data = clsDB.Instance.execQuery("USP_LayGiaApDung");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                GiaAD gia = new GiaAD(item);
                giaApDung.Add(gia);
            }
            return giaApDung;
        }
        //Phương thức thêm bàn vào cơ sở dữ liệu
        /*
         Trước hết phải tạo thủ tục
        create PROC [dbo].[USP_ThemDotGia]
        @giaban float,
        @ngaybd datetime,
        @trangthai int
        AS
            BEGIN
                INSERT dbo.GIATHEODOT(giaban, ngaybdban, trangthaigia) VALUES ( @giaban , @ngaybd , @trangthai)
            END
        */
        public bool themgiaad(double giaban, DateTime ngaybd, int trangthai)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_ThemDotGia @giaban , @ngaybd , @trangthai", new object[] { giaban, ngaybd, trangthai });
            return result > 0;
        }
        public bool suaThongTinKhoa(int madotgia, double giaban, DateTime ngaybd, int trangthai)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaTTKhoa @@madotgia , @giaban , @ngaybd , @trangthai", new object[] { madotgia, giaban, ngaybd, trangthai });
            return result > 0;
        }
        //  Phương thức kiểm tra đợt giá có tồn tại trong csdl hay ko?
        public bool kiemTraGiaTonTai(int madotgia)
        {
            DataTable tb = clsDB.Instance.execQuery("select * from dbo.GIATHEODOT where madotgia=" + madotgia + "");
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
