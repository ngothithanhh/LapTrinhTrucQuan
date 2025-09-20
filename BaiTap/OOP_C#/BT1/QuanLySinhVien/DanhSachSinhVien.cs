using System;
using System.Collections.Generic;

namespace QuanLySinhVien
{
    public class DanhSachSinhVien
    {
        private List<SinhVien> danhSach = new List<SinhVien>();

        public void Them(SinhVien sv)
        {
            danhSach.Add(sv);
        }

        public void XuatDanhSach()
        {
            foreach (var sv in danhSach)
            {
                sv.Xuat();
            }
        }

        public int DemKhoaLuan()
        {
            int cnt = 0;
            foreach (var sv in danhSach)
            {
                if (sv.DuocLamKhoaLuan())
                    cnt++;
            }
            return cnt;
        }

        public int DemChuyenDe()
        {
            int cnt = 0;
            foreach (var sv in danhSach)
            {
                if (sv.DuocLamChuyenDe())
                    cnt++;
            }
            return cnt;
        }
    }
}
