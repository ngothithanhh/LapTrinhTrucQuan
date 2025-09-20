using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01_2
{
    internal class XeTai : Xe
    {
        public XeTai(string hoTen, int soGioThue) : base(hoTen, soGioThue)
        {
        }
        public override double TinhTien()
        {
            if (soGioThue <= 0) return 0;
            double donGia = 0;
            if (soGioThue <= 1)
            {
                donGia = 220000;
            }
            else if (soGioThue > 1)
            {
                donGia = 220000 + (soGioThue - 1) * 85000;
            }
            return donGia;
        }
        
    }
}
