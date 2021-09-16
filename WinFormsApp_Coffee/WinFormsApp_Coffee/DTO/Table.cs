using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp_Coffee.DTO
{
    public class Table
    {
        private string tenBan;
        private string trangThai;
        private int tang;
        private DateTime ngayBatDauSD;
        private int iD;
        public Table(int id, string tenban, string trangthai, int tangban, DateTime ngaybd)
        {
            this.ID = id;
            this.TenBan = tenban;
            this.TrangThai = trangthai;
            this.Tang = tangban;
            this.NgayBatDauSD = ngaybd;
        }
        public Table(DataRow row)
        {
            this.ID = (int)row["idban"];
            this.TenBan = row["tenban"].ToString();
            this.TrangThai = row["trangthaiban"].ToString();
            this.Tang = (Int32)row["tang"];
            this.NgayBatDauSD = (DateTime)row["ngaybdsudung"];
        }
        public int ID { get => iD; set => iD = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int Tang { get => tang; set => tang = value; }
        public DateTime NgayBatDauSD { get => ngayBatDauSD; set => ngayBatDauSD = value; }
    }
}
