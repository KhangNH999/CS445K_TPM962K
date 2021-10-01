using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class TaiKhoanLogin
    {
        private int maTaiKhoan;
        private string tenDangNhap;
        private string matKhau;
        private int maLoaiTK;

        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int MaLoaiTK { get => maLoaiTK; set => maLoaiTK = value; }


        public TaiKhoanLogin(DataRow row)
        {
            this.MaTaiKhoan = (int)row["mataikhoan"];
            this.TenDangNhap = row["tendangnhap"].ToString();
            this.MatKhau = row["matkhau"].ToString();
            this.MaLoaiTK = (int)row["maloaitk"];

        }

        public TaiKhoanLogin(int maTaiKhoan, string tenDangNhap, string matKhau, int maLoaiTK)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.maLoaiTK = maLoaiTK;
        }
    }
}
