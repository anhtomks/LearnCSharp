using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.TestFunc();
            Console.ReadLine();
        }
        public void TestFunc()
        {
            try
            {
                Console.WriteLine("Mo file");
                double a = enterDoubleNumber("Nhap vao so thu nhat");
                double b = enterDoubleNumber("Nhap vao so thu hai");
                Console.WriteLine("{0}/{1}={2}", a, b, DoDivide(a, b));
                Console.WriteLine("Dong nay co the xuat hien hoac khong");
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Loi chia cho 0!");
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("So thu nhat bang khong!");
            }
            catch
            {
                Console.WriteLine("Co loi xay ra khi thuc hien phep chia");
            }
            finally
            {
                Console.WriteLine("Dong tep");
            }
        }
        public double DoDivide(double a, double b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            if (a == 0)
            {
                throw new System.ArithmeticException();
            }
            return a / b;
        }
        public double enterDoubleNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
