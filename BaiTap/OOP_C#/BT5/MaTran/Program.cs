namespace MaTran
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap so dong: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int n = int.Parse(Console.ReadLine());

            MaTran A = new MaTran(m, n);
            Console.WriteLine("Nhap ma tran:");
            A.Nhap();

            Console.WriteLine("Ma tran:");
            A.In();

            Console.WriteLine("Ma tran chuyen vi:");
            A.ChuyenVi().In();

            Console.WriteLine($"A {(A.LaMaTranVuong() ? "la" : "khong la")} ma tran vuong");

            Console.WriteLine("\nNhap ma tran thu 2:");
            Console.Write("Nhap so dong: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int n1 = int.Parse(Console.ReadLine());

            MaTran B = new MaTran(m1, n1);
            Console.WriteLine("Nhap ma tran:");
            B.Nhap();

            Console.WriteLine("A + B:");
            A.Cong(B).In();

            Console.WriteLine("A - B:");
            A.Hieu(B).In();
        }
    }

}