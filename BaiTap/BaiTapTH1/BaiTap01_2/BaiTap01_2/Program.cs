//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using BaiTap01_2;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap so xe da cho thue: ");
        int n = int.Parse(Console.ReadLine());

        Xe[] dsXe = new Xe[n];
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin xe thu {i + 1}:");
            Console.Write("Nhap loai xe (1: Xe Tai, 2: Xe Du Lich): ");
            int loaiXe = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten nguoi thue: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap so gio thue: ");
            int soGioThue = int.Parse(Console.ReadLine());
            if (loaiXe == 1)
            {
                dsXe[i] = new XeTai(hoTen, soGioThue);
            }
            else if (loaiXe == 2)
            {
                dsXe[i] = new XeDuLich(hoTen, soGioThue);
            }
        }

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Thong tin xe thu {i + 1}:");
            dsXe[i].xuat();
        }

    }
}
