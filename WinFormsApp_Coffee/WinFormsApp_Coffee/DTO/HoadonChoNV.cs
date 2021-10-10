using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class HoadonChoNV
    {
        private int maHD;
        private string tentk;
        private DateTime ngaylap;
        private string tenban;
        private string trangthaihoadon;
        private double tongTien;

        public int MaHD { get => maHD; set => maHD = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthaihoadon { get => trangthaihoadon; set => trangthaihoadon = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }

        public HoadonChoNV(int mahd, string tentk, DateTime ngay, string tenban, string trangthai, double tong)
        {
            this.MaHD = mahd;
            this.Tentk = tentk;
            this.Ngaylap = ngay;
            this.Tenban = tenban;
            this.Trangthaihoadon = trangthai;
            this.TongTien = tong;
        }
        public HoadonChoNV(DataRow row)
        {
            this.MaHD = (int)row["mahoadon"];
            this.Tentk = row["tennv"].ToString();
            this.Ngaylap = (DateTime)row["giolap"];
            this.Tenban = row["tenban"].ToString();
            this.Trangthaihoadon = row["trangthaihoadon"].ToString();
            this.TongTien = (double)row["Tongtien"];
        }
    }
}
