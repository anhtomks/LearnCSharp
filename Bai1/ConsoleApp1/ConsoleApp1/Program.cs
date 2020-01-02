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
            /*
             * int tuoi = 5;
            string ten = "Ti";
            Console.WriteLine("Hello World"); //Line of Code(LOC)
            Console.Read();
            */
            Console.WriteLine("Nhap vao mot so: ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    Console.WriteLine("Thang Gieng");
                    break;
                case 2:
                    Console.WriteLine("Thang Hai");
                    break;
                case 3:
                    Console.WriteLine("Thang Ba");
                    break;

                case 4:
                    Console.WriteLine("Thang Tu");
                    break;
                case 5:
                    Console.WriteLine("Thang Nam");
                    break;
                case 6:
                    Console.WriteLine("Thang Sau");
                    break;
                case 7:
                    Console.WriteLine("Thang Bay");
                    break;
                case 8:
                    Console.WriteLine("Thang Tam");
                    break;
                case 9:
                    Console.WriteLine("Thang Chin");
                    break;
                case 10:
                    Console.WriteLine("Thang Muoi");
                    break;
                case 11:
                    Console.WriteLine("Thang Muoi Mot");
                    break;
                case 12:
                    Console.WriteLine("Thang Muoi Hai");
                    break;
                default :
                    Console.WriteLine("Day khong phai la mot thang");
                    break;
            }
            Console.ReadLine();
        }
    }
}
