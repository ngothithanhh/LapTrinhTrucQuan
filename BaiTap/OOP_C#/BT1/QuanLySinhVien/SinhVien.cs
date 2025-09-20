using System;

namespace QuanLySinhVien
{
    public class SinhVien
    {
        public string? HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DiemLT { get; set; }
        public double DiemCSDL { get; set; }
        public double DiemTKWeb { get; set; }

        public SinhVien() { }
        public SinhVien(string hoTen, DateTime ngaySinh, double diemLT, double diemCSDL, double diemWeb)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            this.DiemLT = diemLT;
            this.DiemCSDL = diemCSDL;
            DiemTKWeb = diemWeb;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap ngay sinh: ");
            DateTime ns;
            while (!DateTime.TryParse(Console.ReadLine(), out ns))
            {
                Console.Write("Sai dinh dang! Nhap lai: ");
            }
            NgaySinh = ns;

            Console.Write("Nhap diem Lap trinh: ");
            DiemLT = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Co so du lieu: ");
            DiemCSDL = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Thiet ke Web: ");
            DiemTKWeb = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"{HoTen,-20} | {NgaySinh.ToShortDateString(),-10} | " +
                              $"LT: {DiemLT,4} | CSDL: {DiemCSDL,4} | WEB: {DiemTKWeb,4} | TB: {DiemTB():0.00}");
        }

        public double DiemTB()
        {
            return (DiemLT + DiemCSDL + DiemTKWeb) / 3.0;
        }

        public bool DuocLamKhoaLuan()
        {
            return DiemTB() >= 8 && DiemLT >= 5 && DiemCSDL >= 5 && DiemTKWeb >= 5;
        }

        public bool DuocLamChuyenDe()
        {
            return DiemLT >= 5 && DiemCSDL >= 5 && DiemTKWeb >= 5;
        }
    }
}
