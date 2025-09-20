using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01_0
{
    internal class ThiSinh
    {
        private string sbd, ht;
        private double m1, m2, m3;

        public ThiSinh() { }

        public ThiSinh(string sbd, string ht, double m1, double m2, double m3)
        {
            this.sbd = sbd;
            this.ht = ht;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public void nhap()
        {
            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            ht = Console.ReadLine();
            Console.Write("Nhap diem mon 1: ");
            m1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon 2: ");
            m2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon 3: ");
            m3 = double.Parse(Console.ReadLine());

        }

        public void xuat()
        {
            Console.WriteLine($"SBD: {sbd}, Ho ten: {ht}, " +
                              $"M1: {m1}, M2: {m2}, M3: {m3}, Tong: {tongDiem()}");
        }

        public double tongDiem()
        {
            return m1 + m2 + m3;
        }
    }
}
