﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeChucGiang_Buoi5_
{
    internal class Nguoi
    {
        string hoTen;
        string ngaySinh;
        string gioiTinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }


        public Nguoi () { }
        public Nguoi(string hoTen, string ngaySinh, string gioiTinh)
        {
            hoTen = HoTen;
            ngaySinh = NgaySinh;
            gioiTinh= GioiTinh;
        }
    }
}
