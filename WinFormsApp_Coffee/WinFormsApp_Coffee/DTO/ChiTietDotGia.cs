using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class ChiTietDotGia
    {
        private int maDoUong;
        private int maDotGia;
        private double giaBan;
        public int MaDoUong { get => maDoUong; set => maDoUong = value; }
        public int MaDotGia { get => maDotGia; set => maDotGia = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }

        public ChiTietDotGia(int madouong, int madotgia, float giaban)
        {
            this.MaDotGia = madotgia;
            this.MaDoUong = madouong;  
            this.GiaBan = giaban;
        }
        public ChiTietDotGia(DataRow row)
        {
            this.MaDotGia = (int)row["madotgia"];
            this.MaDoUong = (int)row["madouong"];
            this.GiaBan = (double)row["giaban"];
        }
    }
}
