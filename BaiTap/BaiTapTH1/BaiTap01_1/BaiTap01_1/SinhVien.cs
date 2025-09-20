using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01_1
{
    internal class SinhVien
    {
        private string hoTen, ngaySinh;
        private double lapTrinh, CSDL, tkWeb;

        public SinhVien() { }

        public SinhVien(string hoTen, string ngaySinh, double lapTrinh, double CSDL, double tkWeb)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.lapTrinh = lapTrinh;
            this.CSDL = CSDL;
            this.tkWeb = tkWeb;
        }

        public void nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            ngaySinh = Console.ReadLine();

            Console.Write("Nhap diem Lap trinh: ");
            lapTrinh = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem CSDL: ");
            CSDL = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Thiet ke Web: ");
            tkWeb = double.Parse(Console.ReadLine());

        }

        public void xuat()
        {
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Ngay sinh: {ngaySinh}");
            Console.WriteLine($"Diem Lap trinh: {lapTrinh}");
            Console.WriteLine($"Diem CSDL: {CSDL}");
            Console.WriteLine($"Diem Thiet ke Web: {tkWeb}");
            Console.WriteLine($"Diem trung binh: {tinhDiemTB()}");
        }

        public double tinhDiemTB()
        {
            return (lapTrinh + CSDL + tkWeb) / 3;
        }

        public bool ktraKLTN()
        {
            return lapTrinh >= 5 && CSDL >= 5 && tkWeb >= 5 && tinhDiemTB()>=8;
        }

        public bool ktraCDTN()
        {
            return lapTrinh >= 5 && CSDL >= 5 && tkWeb >= 5 && tinhDiemTB() < 8;
        }


    }
}
