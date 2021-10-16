﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class QuanLyHoaDonDAO
    {
        private static QuanLyHoaDonDAO instance;

        public static QuanLyHoaDonDAO Instance
        {
            get { if (instance == null) instance = new QuanLyHoaDonDAO(); return QuanLyHoaDonDAO.instance; }
            private set { QuanLyHoaDonDAO.instance = value; }
        }
        private QuanLyHoaDonDAO() { }
        /*CREATE PROC USP_LayDanhSachHoaDon
          AS
        SELECT a.mahoadon, b.tennv, a.giolap, c.tenban,
        case trangthaihoadon 
        when 0 then N'Chưa thanh toán' 
        when 1 then N'Đã thanh toán' 
        when 2 then N'Đã khóa'
        end as trangthaihoadon
        FROM dbo.HOADON as a, dbo.TAIKHOAN as b, dbo.BAN as c
        where a.mataikhoan = b.mataikhoan and a.maban = c.maban
        */
        public List<Hoadon> loadDanhSachHD()
        {
            List<Hoadon> danhSach = new List<Hoadon>();
            DataTable data = clsDB.Instance.execQuery("USP_LayDanhSachHoaDon");//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                Hoadon hd = new Hoadon(item);
                danhSach.Add(hd);
            }
            return danhSach;
        }
        /*
           CREATE PROC USP_ThemHoaDon
            @mahoadon int,
			@matk int,
			@ngay date,
			@maban int,
			@trangthai int
        AS
            BEGIN
                INSERT dbo.HOADON (mahoadon, mataikhoan, giolap, maban, trangthaihoadon) VALUES (@mahoadon, @matk, @ngay, @maban, @trangthai)
            END
         */
        public bool themHoaDon(int matk, DateTime ngay, int maban, int trangthai)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_ThemHoaDon @matk , @ngay , @maban , @trangthai ", new object[] { matk, ngay, maban, trangthai });
            return result > 0;
        }
        /*
         create proc USP_SuaHoaDon
			@mahd int,
            @matk int,
			@ngay date,
			@maban int,
			@trangthai int
            as 
                begin 
                    update dbo.HOADON set mataikhoan = @matk, giolap = @ngay, maban = @maban, trangthaihoadon = @trangthai where mahoadon = @mahd
                end     
         */
        public bool suaHoaDon(int mahd, int matk, DateTime ngay, int maban, int trangthai)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_SuaHoaDon @mahd , @matk , @ngay , @maban , @trangthai ", new object[] { mahd, matk, ngay, maban, trangthai });
            return result > 0;
        }
        /*
          create proc USP_XoaHoaDon
        @mahd int
         as 
         declare @isexistbill int = 0
            begin 
             select @isexistbill=COUNT(*) from dbo.CHITIETHOADON where mahoadon = @mahd
             if(@isexistbill>0)
             begin
             delete from dbo.CHITIETHOADON where mahoadon = @mahd
             end
	         delete from dbo.HOADON where mahoadon = @mahd
         end
         */
        public bool xoaHoaDon(int mahd)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_XoaHoaDon @mahd ", new object[] { mahd });
            return result > 0;
        }
        /*
           create proc USP_KhoaHoaDon
         @mahd int
         as 
            begin 
	            update dbo.HOADON set trangthaihoadon = 2 where mahoadon = @mahd
         end
         */
        public bool KhoaHoaDon(int mahd)
        {
            int result = clsDB.Instance.execNonQuery("exec USP_KhoaHoaDon @mahd ", new object[] { mahd });
            return result > 0;
        }
        public DataTable loadTenNV()
        {
            string SQL = "select * from dbo.TAIKHOAN";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        public DataTable loadTenBan()
        {
            string SQL = "select * from dbo.BAN";
            DataTable dt = clsDB.Instance.execQuery(SQL);
            return dt;
        }
        /*
         create proc USP_LaychitietHD
        @mahd int
        as
        select a.mahoadon, b.tendouong, a.soluong, a.giatien, a.tlgiamgia, a.tongtien
        from dbo.CHITIETHOADON as a, dbo.DOUONG as b
        where a.madouong = b.madouong and a.mahoadon = @mahd 
         */
        public List<Chitiethoadon> loadDanhSachChiTietHD(int mahd)
        {
            List<Chitiethoadon> danhSach = new List<Chitiethoadon>();
            DataTable data = clsDB.Instance.execQuery("USP_LaychitietHD @mahd ", new object[] { mahd });//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                Chitiethoadon hd = new Chitiethoadon(item);
                danhSach.Add(hd);
            }
            return danhSach;
        }
        /*
         CREATE PROC USP_LayHDTheoNV
        @matk int
          AS
        SELECT a.mahoadon, b.tennv, a.giolap, c.tenban,
        case trangthaihoadon 
        when 0 then N'Chưa thanh toán' 
        when 1 then N'Đã thanh toán' 
        when 2 then N'Đã khóa'
        end as trangthaihoadon, SUM(d.tongtien)as Tongtien
        FROM dbo.HOADON as a, dbo.TAIKHOAN as b, dbo.BAN as c, dbo.CHITIETHOADON as d
        where a.mataikhoan = b.mataikhoan and a.maban = c.maban and a.mahoadon = d.mahoadon and a.trangthaihoadon =1
        and a.mataikhoan = @matk
        group by a.mahoadon, b.tennv, a.giolap, c.tenban,
        trangthaihoadon
         */
        public List<HoadonChoNV> loadDanhSachHDTheoNV(int matk)
        {
            List<HoadonChoNV> danhSach = new List<HoadonChoNV>();
            DataTable data = clsDB.Instance.execQuery("USP_LayHDTheoNV @matk ", new object[] { matk });//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                HoadonChoNV hd = new HoadonChoNV(item);
                danhSach.Add(hd);
            }
            return danhSach;
        }
        /*
         create proc USP_LayHDTheoNgay
            @matk int,
            @ngay1 date,
            @ngay2 date
          AS
          SELECT a.mahoadon, b.tennv, a.giolap, c.tenban,
        case trangthaihoadon 
        when 0 then N'Chưa thanh toán' 
        when 1 then N'Đã thanh toán' 
        when 2 then N'Đã khóa'
        end as trangthaihoadon, SUM(d.tongtien)as Tongtien
        FROM dbo.HOADON as a, dbo.TAIKHOAN as b, dbo.BAN as c, dbo.CHITIETHOADON as d
        where a.mataikhoan = b.mataikhoan and a.maban = c.maban
        and a.mahoadon = d.mahoadon
        and a.mataikhoan = @matk and a.giolap >= @ngay1 and a.giolap<=@ngay2 and trangthaihoadon =1
        group by a.mahoadon, b.tennv, a.giolap, c.tenban, 
        trangthaihoadon      
         */
        public List<HoadonChoNV> loadDanhSachHDTheoNgay(int matk, DateTime ngay1, DateTime ngay2)
        {
            List<HoadonChoNV> danhSach = new List<HoadonChoNV>();
            DataTable data = clsDB.Instance.execQuery("USP_LayHDTheoNgay @matk , @ngay1 , @ngay2 ", new object[] { matk , ngay1 , ngay2 });//Lấy thủ tục từ SQL server
            foreach (DataRow item in data.Rows)
            {
                HoadonChoNV hd = new HoadonChoNV(item);
                danhSach.Add(hd);
            }
            return danhSach;
        }
    }
}
