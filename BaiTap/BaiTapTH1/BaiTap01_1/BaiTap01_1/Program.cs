// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#nullable disable

namespace BaiTap01_1;
public static class Program
{
    public static void Main(string[] args)
    {
        DSSinhVien dsSinhVien = new DSSinhVien();
        dsSinhVien.nhapDS();
        Console.WriteLine("So sinh vien duoc lam khoa luan tot nghiep: " + dsSinhVien.countKLTN());
        Console.WriteLine("So sinh vien duoc lam chuyen de tot nghiep: " + dsSinhVien.countCDTN());
    }
}