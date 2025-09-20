namespace Mang1Chieu
{   
    public class Mang1Chieu
    {
        int n;     
        int[] a;   
        public Mang1Chieu(int n)
        {
            this.n = n;
            a = new int[n];
        }
        public void Nhap()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public void SapXep(int thutu)
        {
            Array.Sort(a); 
            if (thutu == 1) 
            {
                Array.Reverse(a);
            }
        }
        public int TimKiem(int m)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == m)
                {
                    return i;
                }
            }
            return -1;
        }
    }

}
