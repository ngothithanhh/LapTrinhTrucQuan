using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01_0
{
    internal class TuyenSinh : ThiSinh
    {
        private int khuVuc;

        public TuyenSinh() : base() { }

        public TuyenSinh(string sbd, string ht, double m1, double m2, double m3, int khuVuc)
            : base(sbd, ht, m1, m2, m3)
        {
            this.khuVuc = khuVuc;
        }

        public void nhap()
        {
            base.nhap();
            Console.Write("Nhap khu vuc(1/2/3): ");
            khuVuc = int.Parse(Console.ReadLine());
        }

        public double tongDiem()
        {
            double diemKV = 0;
            if (khuVuc == 1) diemKV = 0;
            else if (khuVuc == 2) diemKV = 1;
            else if(khuVuc == 3) diemKV = 2;
           
            return base.tongDiem() + diemKV;
        }

        public void xuat()
        {
            Console.WriteLine($"--- Thi sinh ---");
            base.xuat();
            Console.WriteLine($"Khu vuc: {khuVuc}, Tong diem (cong KV): {tongDiem()}");
        }
    }
}
