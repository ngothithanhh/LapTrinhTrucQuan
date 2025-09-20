using System;

namespace Diem
{
    public class Diem
    {
        private double x;
        private double y;

        public Diem()
        {
            x = 0;
            y = 0;
        }

        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Nhap()
        {
            Console.Write("Nhap hoanh do x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Nhap tung do y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"({x}, {y})");
        }

        public double KhoangCach(Diem d)
        {
            double dx = x - d.x;
            double dy = y - d.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
