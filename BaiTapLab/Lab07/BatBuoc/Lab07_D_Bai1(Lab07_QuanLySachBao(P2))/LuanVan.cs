﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai1_Lab07_QuanLySachBao_P2__
{
    public class LuanVan : TaiLieu
    {
        private new string _tacGia;

        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }

        public override bool LaCongTrinhCua(string tenTacGia)
        {
            return _tacGia.Equals(tenTacGia);
        }

        public LuanVan()
        {
            _maSo = "";
            _nhanDe = "";
            _namXb = 0;
            _tacGia = "";
        }

        public LuanVan(string maso, string tuade, int namxb, string tacGia)
        {
            _maSo = maso;
            _nhanDe = tuade;
            _namXb = namxb;
            _tacGia = tacGia;
        }

        public override string ToString()
        {
            return $"Ma so: {_maSo}, Tua de: {_nhanDe}, Nam xuat ban: {_namXb}, Tác giả: {_tacGia}";
        }
    }
}
