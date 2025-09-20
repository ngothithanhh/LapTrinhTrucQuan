namespace PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();

            Console.WriteLine("Nhap phan so thu nhat:");
            ps1.Nhap();

            Console.WriteLine("Nhap phan so thu hai:");
            ps2.Nhap();

            Console.WriteLine("\nPhan so 1: ");
            ps1.Xuat();

            Console.WriteLine("Phan so 2: ");
            ps2.Xuat();

            Console.WriteLine("\n===== CAC PHEP TOAN =====");

            PhanSo tong = ps1 + ps2;
            Console.Write("Tong: ");
            tong.Xuat();

            PhanSo hieu = ps1 - ps2;
            Console.Write("Hieu: ");
            hieu.Xuat();

            PhanSo tich = ps1 * ps2;
            Console.Write("Tich: ");
            tich.Xuat();

            PhanSo thuong = ps1 / ps2;
            Console.Write("Thuong: ");
            thuong.Xuat();

            Console.ReadKey();
        }
    }
}
