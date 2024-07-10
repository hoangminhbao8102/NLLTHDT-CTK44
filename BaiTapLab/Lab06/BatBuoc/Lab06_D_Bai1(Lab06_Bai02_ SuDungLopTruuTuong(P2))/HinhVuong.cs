﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai1_Lab06_Bai02__SuDungLopTruuTuong_P2__
{
    public class HinhVuong : HinhChuNhat
    {
        public HinhVuong(double canh) : base(canh, canh)
        {
        }

        public override void Xuat()
        {
            Console.WriteLine("Hinh vuong co canh {0}, " + "dien tich = {1}", canh, TinhDienTich());
        }
    }
}
