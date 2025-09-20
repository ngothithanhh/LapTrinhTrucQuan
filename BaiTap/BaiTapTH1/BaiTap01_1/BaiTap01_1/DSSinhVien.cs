using System;

namespace BaiTap01_1
{
    internal class DSSinhVien
    {
        private SinhVien[] sinhViens; // mảng sinh viên dùng chung
        private int n;

        public void nhapDS()
        {
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());

            sinhViens = new SinhVien[n]; // cấp phát bộ nhớ cho mảng

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}: ");
                sinhViens[i] = new SinhVien();
                sinhViens[i].nhap();
            }
        }

        public void xuatDS()
        {
            Console.WriteLine("\nDanh sach sinh vien:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Sinh vien {i + 1}:");
                sinhViens[i].xuat();
            }
        }

        public int countKLTN()
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (sinhViens[i].ktraKLTN())
                {
                    count++;
                }
            }
            return count;
        }

        public int countCDTN()
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (sinhViens[i].ktraCDTN())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
