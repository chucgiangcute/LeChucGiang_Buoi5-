using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeChucGiang_Buoi5_
{
    internal class SinhVien:Nguoi
    {
        string mSSV;
        string nganhHoc;
        double diemTB;

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string NganhHoc { get => nganhHoc; set => nganhHoc = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }

        public SinhVien():base()
        {

        }
        public SinhVien(string hoTen, string ngaySinh, string gioiTinh, string mSSV,string nganhHoc, double diemTB)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.MSSV = mSSV;
            this.NganhHoc=nganhHoc;
            this.DiemTB = diemTB;
            

        }
    }
}
