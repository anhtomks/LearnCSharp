using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkL2
{
    class Program
    {
        static void Main(string[] args)
        {
            //dienTichHinhChuNhat();

            //dienTichHinhThang();

            /*double number = enterNumber("Nhap vao pham vi");
            demChanLe(number);*/

            gioiThieu();
            
            
            thoatChuongTrinh();
        }
        /// <summary>
        /// Nhap vao mot so kieu number
        /// </summary>
        /// <param name="mess"></param>
        /// <returns></returns>
        static double enterNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToDouble(Console.ReadLine());
        }
        static string enterString(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }
        static void dienTichHinhChuNhat()
        {
            double a = enterNumber("Nhap chieu dai hinh chu nhat: ");
            double b = enterNumber("Nhap chieu rong hinh chu nhat: ");
            Console.WriteLine($"Dien tich cua hinh chu nhat co chieu dai {a} va chieu rong {b} la: {a*b}");
        }

        static void dienTichHinhThang()
        {
            double a = enterNumber("Nhap vao day lon cua hinh thang: ");
            double b = enterNumber("Nhap vao day nho cua hinh thang: ");
            double h = enterNumber("Nhap vao chieu cao cua hinh thang: ");
            Console.WriteLine($"Dien tich hinh thang co day lon {a}, day nho {b} va chieu cao {h} la {(a+b)*h/2}");
        }

        static void demChanLe(double n)
        {
            int soChan = 0, soLe = 0;

            for(int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} ");
                if((i + 1) % 2 == 0)
                {
                    soChan++;
                }else
                {
                    soLe++;
                }
            }
            Console.WriteLine($"\n Trong pham vi tu 1 den {n} co {soChan} so chan va {soLe} so le");
        }

        static void gioiThieu()
        {
            string fullName = enterString("Nhap ho ten cua ban: ");
            double age = enterNumber("Nhap vao tuoi cua ban: ");
            string hocVan = enterString("Nhap vao trinh do hoc van cua ban");
            string gioiThieu = enterString("Gioi thieu ngan ve ban than ban: ");
            Console.WriteLine($"\n\nHo va ten: {fullName}\n" +
                $"Tuoi: {age}\n" +
                $"Trinh do hoc van: {hocVan}\n" +
                $"Gioi thieu ngan: {gioiThieu}\n\n");
        }

        static void thoatChuongTrinh()
        {
            Console.WriteLine("**** Nhan phim bat ky de thoat ****");
            Console.ReadLine();
        }
    }
}
