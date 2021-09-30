using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = clsDB.Instance.execQuery("SELECT * FROM dbo.CHITIETHOADON WHERE mahoadon = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        /*
         create proc USP_InsertBillInfo
       @mahd int, @madu int, @sl int, @tlgiamgia float
        as
        begin 
        declare @isExistBillInfo int
        declare @foodCount int =1
        declare @price float
        select @price = c.giaban from dbo.DOUONG as b, dbo.GIATHEODOT as c 
        where  b.madouong=@madu and b.madotgia = c.madotgia 
        select @isExistBillInfo = mahoadon,@foodCount=b.soluong
        from dbo.CHITIETHOADON as b
        where mahoadon = @mahd and madouong = @madu
        if(@isExistBillInfo >0)
        begin
        declare @newcount int = @foodCount + @sl
        if(@newcount>0)
        update dbo.CHITIETHOADON set soluong = @foodCount +@sl, tongtien = @newcount*@price where madouong = @madu and mahoadon = @mahd
        end
        else
        begin
        insert dbo.CHITIETHOADON
        (mahoadon,madouong,soluong,giatien,tlgiamgia,tongtien)
        values(@mahd, @madu, @sl,@price,@tlgiamgia,@sl*@price) 
        end
        end
         */
        public void InsertBillInfo(int mahoadon, int madouong, int sl, double tlgiamgia)
        {
            clsDB.Instance.execQuery("exec USP_InsertBillInfo @mahd , @madu , @sl , @tlgiamgia", new object[] { mahoadon , madouong , sl , tlgiamgia});
        }
        /*
         create proc USP_DeleteFood
        @mahd int, @madu int, @sl int
        as
        begin 
        declare @isExistBillInfo int
        declare @foodCount int =1
        declare @price float
        select @price = c.giaban from dbo.DOUONG as b, dbo.GIATHEODOT as c 
        where  b.madouong=@madu and b.madotgia = c.madotgia 
        select @isExistBillInfo = mahoadon,@foodCount=b.soluong
        from dbo.CHITIETHOADON as b
        where mahoadon = @mahd and madouong = @madu
        if(@isExistBillInfo >0)
        begin
        declare @newcount int = @foodCount - @sl
        if(@newcount>0)
        update dbo.CHITIETHOADON set soluong = @foodCount - @sl, tongtien = @newcount * @price where madouong = @madu and mahoadon =@mahd
        else
        delete dbo.CHITIETHOADON where mahoadon = @mahd and madouong = @madu
        end
        end
        go
         */
        public void DeleteBillInfo(int mahoadon, int madouong, int sl)
        {
            clsDB.Instance.execQuery("exec USP_DeleteFood @mahd , @madu , @sl", new object[] { mahoadon, madouong, sl });
        }
    }
}
