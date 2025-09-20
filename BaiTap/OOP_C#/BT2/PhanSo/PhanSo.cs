using System;

namespace PhanSo
{
    public class PhanSo
    {
        private int ts;
        private int ms;

        public PhanSo()
        {
            ts = 0;
            ms = 1;
        }

        public PhanSo(int tu, int mau)
        {
            if (mau == 0)
                throw new ArgumentException("Mau so khong the bang 0");

            ts = tu;
            ms = mau;
            RutGon();
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            ts = int.Parse(Console.ReadLine());

            Console.Write("Nhap mau so: ");
            ms = int.Parse(Console.ReadLine());

            while (ms == 0)
            {
                Console.WriteLine("Mau so khong hop le. Nhap lai:");
                Console.Write("Nhap tu so: ");
                ts = int.Parse(Console.ReadLine());

                Console.Write("Nhap mau so: ");
                ms = int.Parse(Console.ReadLine());
            }

            RutGon();
        }

        public void Xuat()
        {
            if (ms == 1)
                Console.WriteLine($"{ts}");
            else
                Console.WriteLine($"{ts}/{ms}");
        }

        private void RutGon()
        {
            int ucln = UCLN(Math.Abs(ts), Math.Abs(ms));
            ts /= ucln;
            ms /= ucln;

            if (ms < 0)
            {
                ts = -ts;
                ms = -ms;
            }
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.ts * b.ms + b.ts * a.ms, a.ms * b.ms);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.ts * b.ms - b.ts * a.ms, a.ms * b.ms);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.ts * b.ts, a.ms * b.ms);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.ts == 0)
                throw new DivideByZeroException("Khong the chia cho phan so co tu so = 0");
            return new PhanSo(a.ts * b.ms, a.ms * b.ts);
        }
    }
}
