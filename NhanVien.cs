using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeChucGiang_Buoi5_
{
    internal class NhanVien:Nguoi
    {
        string mSNV;
        string luong;
        string chucVu;

        public string MSNV { get => mSNV; set => mSNV = value; }
        public string Luong { get => luong; set => luong = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

        public NhanVien() : base()
        {

        }

        public NhanVien(string hoTen, string gioiTinh, string ngaySinh, string mSNV, string luong, string chucVu)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.MSNV = mSNV;
            this.Luong = luong;
            this.ChucVu = chucVu;
        }
    }
}
