using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class HinhHoc
    {
        public double chieuDai { get; set; }
        public double chieuRong { get; set; }
        public double banKinh { get; set; }

    }
    class HinhVuong: HinhHoc
    {
        public double chuVi()
        {
            return chieuDai * 4;
        }
        public double dienTich()
        {
            return chieuDai * chieuDai;
        }
    }
    class HinhChuNhat: HinhHoc
    {
        public double chuVi ()
        {
            return 2 * (chieuDai + chieuRong);
        }
        public double dienTich()
        {
            return chieuDai * chieuRong;
        }
    }
    class HinhTron: HinhHoc
    {
        private const double PI = 3.14;
       public double chuVi()
        {
            return 2 * PI * banKinh;
        }
        public double dienTich()
        {
            return PI * banKinh * banKinh;
        }
    }
}
