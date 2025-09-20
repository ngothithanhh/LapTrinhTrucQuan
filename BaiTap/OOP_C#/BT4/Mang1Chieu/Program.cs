namespace Mang1Chieu
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so phgan tu: ");
            int n = int.Parse(Console.ReadLine());

            Mang1Chieu mang = new Mang1Chieu(n);
            mang.Nhap();
            mang.Xuat();

            int sx;
            Console.Write("Nhan 0 de sap xep tang dan\nNhan 1 de sap xep giam dan\nChon: ");
            sx = int.Parse(Console.ReadLine());
            mang.SapXep(sx);
            mang.Xuat();

            Console.Write("Nhap so can tim ");
            int m = int.Parse(Console.ReadLine());
            int pos = mang.TimKiem(m);

            if (pos == -1)
                Console.WriteLine("Khong tim thay");
            else
                Console.WriteLine($"{m} tai vi tri {pos}");
        }
    }

}