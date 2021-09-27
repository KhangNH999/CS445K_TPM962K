using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    class TaiKhoan
    {
        private int maTaiKhoan;
        private string tenDangNhap;
        private string matKhau;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string cMnd;
        private string email;
        private string sdt;
        private string trangThaiTK;
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CMND { get => cMnd; set => cMnd = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string TrangThaiTK { get => trangThaiTK; set => trangThaiTK = value; }
        public TaiKhoan( int mataikhoan, string tendangnhap, string matkhau, string tennv, DateTime ngaysinh, string gioitinh, string cmnd, string email, string sdt, string trangthaitk)
        {
            this.maTaiKhoan = mataikhoan;
            this.tenDangNhap = tendangnhap;
            this.matKhau = matkhau;
            this.tenNV = tennv;
            this.ngaySinh = ngaysinh;
            this.gioiTinh = gioitinh;
            this.cMnd = cmnd;
            this.email = email;
            this.sdt = sdt;
            this.trangThaiTK = trangthaitk;
        }
        public TaiKhoan(DataRow row)
        {
            this.MaTaiKhoan = (int)row["mataikhoan"];
            this.TenDangNhap = row["tendangnhap"].ToString();
            this.MatKhau = row["matkhau"].ToString();
            this.TenNV = row["tennv"].ToString();
            this.NgaySinh = (DateTime)row["ngaysinh"];
            this.GioiTinh = row["gioitinh"].ToString();
            this.CMND = row["cmnd"].ToString();
            this.Email = row["email"].ToString();
            this.SDT = row["sdt"].ToString();
            this.TrangThaiTK = row["trangthaitk"].ToString();
        }
        
    }
}
