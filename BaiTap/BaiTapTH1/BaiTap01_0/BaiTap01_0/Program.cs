//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using BaiTap01_0;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap so luong thi sinh: ");
        int n = int.Parse(Console.ReadLine());

        List<TuyenSinh> ds = new List<TuyenSinh>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhap thi sinh {i + 1} ---");  
            TuyenSinh ts = new TuyenSinh();
            ts.nhap();
            ds.Add(ts);
        }

        Console.Write("Nhap diem chuan: ");
        double diemChuan = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Danh sach thi sinh trung tuyen ---");
        for(int i = 0; i < ds.Count; i++)
        {
            if (ds[i].tongDiem() >= diemChuan)
            {
                ds[i].xuat();
            }
        }




    }
}