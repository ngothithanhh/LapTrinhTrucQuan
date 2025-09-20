namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            DanhSachSinhVien ds = new DanhSachSinhVien();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhap thong tin sinh vien thu {i + 1} ---");
                SinhVien sv = new SinhVien();
                sv.Nhap();
                ds.Them(sv);
            }

            Console.WriteLine("\n===== DANH SACH SINH VIEN =====");
            ds.XuatDanhSach();

            Console.WriteLine("\n===== KET QUA =====");
            Console.WriteLine("So luong sinh vien duoc lam khoa luan: " + ds.DemKhoaLuan());
            Console.WriteLine("So luong sinh vien duoc lam chuyen de: " + ds.DemChuyenDe());

            Console.ReadKey();
        }
    }
}
