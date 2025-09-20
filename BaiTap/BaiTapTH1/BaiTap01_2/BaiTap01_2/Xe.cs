using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01_2
{
    abstract class Xe
    {
        public string hoTen;
        public int soGioThue;

        public Xe(string hoTen, int soGioThue)
        {
            this.hoTen = hoTen;
            this.soGioThue = soGioThue;
        }

        public abstract double TinhTien();

        public void xuat()
        {
            Console.WriteLine($"Ho ten: {hoTen}, So gio thue: {soGioThue}, Thanh tien: {TinhTien():N0}đ");
        }

    }
}
