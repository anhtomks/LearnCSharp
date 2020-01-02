using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Common cm = new Common();
            /*GiaoVien gv = new GiaoVien();
            gv.Ten = cm.enterString("Nhap ten cua giao vien: ");
            gv.GioiTinh = cm.enterString("Nhap gioi tinh cua giao vien: ");
            gv.NamSinh = cm.enterIntNumber("Nhap nam sinh cua giao vien: ");
            gv.NamVaoTruong = cm.enterIntNumber("Nhap nam vao truong cua giao vien: ");
            Console.WriteLine($"So nam giang day cua giao vien {gv.Ten} la: {gv.soNamGiangDay(gv.NamVaoTruong, gv.thisYear)}");
            Console.WriteLine($"So nam con lai cho toi luc nghi huu cua giao vien {gv.Ten} la {gv.soNamConLai(gv.GioiTinh, gv.Tuoi)}");
*/
            /*int[] mangSn = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
            MangSoNguyen msn = new MangSoNguyen();
            msn.printArray(mangSn);
            Console.WriteLine($"\n\nTong cac phan tu cua mang tren la: {msn.sumOfArray(mangSn)}");*/

            HinhHoc hh = new HinhHoc();
            hh.BanKinh = cm.enterDbNumber("Nhap vao ban kinh hinh tron: ");
            Console.WriteLine($"Hinh tron voi ban kinh {hh.BanKinh} co chu vi la {hh.chuViHinhTron(hh.BanKinh)} va dien tich la {hh.dienTichHinhTron(hh.BanKinh)}");
            hh.soSanh(hh.chuViHinhTron(hh.BanKinh), hh.dienTichHinhTron(hh.BanKinh));
            
            
            
            cm.exitConsole();
        }
    }

    public class GiaoVien {
        public string Ten { get; set; }
        public int NamSinh { get; set; }

        public int Tuoi
        {
            get { return DateTime.Now.Year - NamSinh; }
        }
        public string GioiTinh { get; set; }
        public int NamVaoTruong { get; set; }

        public int thisYear = DateTime.Now.Year;

        public int soNamGiangDay(int a, int b)
        {
            return b - a;
        }
        public int soNamConLai(string gt, int tuoi)
        {
            int sncl = 0;
            if(gt == "Nam")
            {
                sncl =  65 - tuoi;
            }
            if(gt == "Nu")
            {
                sncl =  60 - tuoi;
            }
            return sncl;
        }
    }

    public class MangSoNguyen {
        public void printArray(int[] a)
        {
            Console.Write("Cac phan tu trong mang la: ");
            foreach(int ele in a)
            {
                Console.Write($"{ele} ");
            }
        }
        public int sumOfArray(int[] a)
        {
            int sum = 0;
            foreach (int ele in a) {
                sum += ele;
            }
            return sum;
        }
    }
    
    public class HinhHoc
    {
        public const double PI = 3.14;
        public double BanKinh { get; set; }
        public double chuViHinhTron(double bk)
        {
            return 2 * PI * bk;
        } 
        public double dienTichHinhTron(double bk)
        {
            return PI * bk * bk;
        }
        public void soSanh(double cv, double dt)
        {
            if(cv > dt)
            {
                Console.WriteLine($"Hinh tron voi ban kinh {BanKinh} co chu vi lon hon dien tich!");
            }else
            {
                Console.WriteLine($"Hinh tron voi ban kinh {BanKinh} co dien tich lon hon chu vi");
            }
        }
    }

    public class Common
    {
        public int enterIntNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToInt32(Console.ReadLine());
        }
        public double enterDbNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToDouble(Console.ReadLine());
        }
        public string enterString(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }
        public void exitConsole()
        {
            Console.WriteLine("\n\n**** Nhan phim bat ky de thoat chuong trinh ****");
            Console.ReadKey();
        }
    }
}
