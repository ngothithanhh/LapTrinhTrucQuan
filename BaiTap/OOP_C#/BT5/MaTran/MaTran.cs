namespace MaTran
{
    using System;

    public class MaTran
    {
        int m;          
        int n;          
        int[,] a;       

        // Hàm tạo
        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
        }

        public void Nhap()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void In()
        {
            Console.WriteLine("Ma trận:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public MaTran Cong(MaTran b)
        {
            if (this.m != b.m || this.n != b.n)
                throw new ArgumentException("Hai ma tran khong cung kich thuoc!");

            MaTran kq = new MaTran(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kq.a[i, j] = this.a[i, j] + b.a[i, j];
                }
            }
            return kq;
        }

        public MaTran Hieu(MaTran b)
        {
            if (this.m != b.m || this.n != b.n)
                throw new ArgumentException("Hai ma tran khong cung kich thuoc!");

            MaTran kq = new MaTran(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kq.a[i, j] = this.a[i, j] - b.a[i, j];
                }
            }
            return kq;
        }

        public MaTran Tich(MaTran b)
        {
            if (this.n != b.m)
                throw new ArgumentException("So cot cua A khong bang so dong cua B!");

            MaTran kq = new MaTran(this.m, b.n);
            for (int i = 0; i < this.m; i++)
            {
                for (int j = 0; j < b.n; j++)
                {
                    kq.a[i, j] = 0;
                    for (int k = 0; k < this.n; k++)
                    {
                        kq.a[i, j] += this.a[i, k] * b.a[k, j];
                    }
                }
            }
            return kq;
        }

        public MaTran ChuyenVi()
        {
            MaTran kq = new MaTran(n, m);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kq.a[j, i] = this.a[i, j];
                }
            }
            return kq;
        }

        public bool LaMaTranVuong()
        {
            return m == n;
        }
    }

}
