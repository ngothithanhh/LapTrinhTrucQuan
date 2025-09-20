using Diem;
using System;

namespace Diem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap toa do diem A:");
            Diem A = new Diem();
            A.Nhap();

            Console.WriteLine("Nhap toa do diem B:");
            Diem B = new Diem();
            B.Nhap();

            Console.WriteLine("\n===== TOA DO =====");
            Console.Write("Diem A: ");
            A.Xuat();
            Console.Write("Diem B: ");
            B.Xuat();

            double kc = A.KhoangCach(B);
            Console.WriteLine($"\nKhoang cach giua A va B: {kc:0.00}");

            Console.ReadKey();
        }
    }
}
