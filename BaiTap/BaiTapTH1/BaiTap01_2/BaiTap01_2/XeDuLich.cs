using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01_2
{
    internal class XeDuLich : Xe
    {
        public XeDuLich(string hoTen, int soGioThue) : base(hoTen, soGioThue)
        {
           
        }

        public override double TinhTien()
        {
            if (soGioThue <= 0) return 0;

            double donGia = 0;

            if (soGioThue <= 1)
            {
                donGia = 250000;
            }
            else if(soGioThue > 1)
            {
                donGia = 250000 + (soGioThue - 1) * 70000;
            }
            return donGia;
        }

        
    }
}
