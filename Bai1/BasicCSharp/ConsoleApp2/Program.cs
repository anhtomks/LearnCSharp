using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single-line Comment ==> Shortcut-Key: Ctrl K, Ctrl C; Uncomment ==> Ctrl K, Ctrl U
            // Move code : Alt + Up/Down
            /*
                Multi-line Comment ==> Shortcut-Key: Ctrl + Shift + /
                ReadLine() method always return string value, if wanna using as a number we have to convert to number.
            */
            /*
                =====Type Conversion Methods=====
                Convert.ToBoolean (=> bool)
                Convert.ToDouble (=> double)
                Convert.ToString (=> string)
                Convert.ToInt32 (=> int)
                Convert.ToInt64 (=> long)
            */
            /*Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age Is: " + age);
            Console.ReadLine();*/

            /*Console.WriteLine("Enter your fullname: ");
            string fullName = Console.ReadLine();
            //Console.WriteLine("Your Full Name is: " + fullName.ToUpper() + " includes: " + fullName.Length + " characters!"); //Normal way
            Console.WriteLine($"Your full name is: {fullName.ToUpper()} includes {fullName.Length} charaters!");//Interpolation way
            Console.WriteLine($"Your name is start with \"{fullName[0]}\" and end with \"{fullName[fullName.Length - 1]}\" !");
            
            Console.WriteLine($"{fullName.IndexOf("n")}");//If have multiple character "n" in fullName???

            Console.WriteLine($"{fullName.Substring(fullName.IndexOf("n"))}");
            */

            /*
            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            string checkMature = age >= 18 ? "Your are matured!" : "You are not matured!";
            Console.WriteLine(checkMature);
            */

            /*
            for(int i = 0; i <= 10; i++)
            {
                if(i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();*/
            /*
            string[] colours = { "Red", "Orange", "Yellow", "Green", "Blue","Indigo", "Violet" };
            foreach(string color in colours)
            {
                Console.WriteLine(color);
            }
            */


            /*
            Console.WriteLine("Enter number of elements for this array!");
            int lenArr = Convert.ToInt32(Console.ReadLine());
            int[] points = new int[lenArr]; 
            for(int i = 0; i <= lenArr - 1; i++) {
                Console.WriteLine($"Enter {i + 1} element\'s value: ");
                points[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Max elements\'s value: {points.Max()}\n" +
                $"Min elements\'s value: {points.Min()}\n" +
                $"Sum of all elements: {points.Sum()}");
            */


            /*int number = enterPostitiveNumber();
            Console.WriteLine($"Your number is: {number}");*/


            /* for(int i = 100; i >= 0; i--)
             {
                 if(i % 2 == 0)
                 {
                     Console.Write($"{i} ");
                 }
             }*/
            int n1 = enterNumber("Nhap vao so thu nhat: ");
            int n2 = enterNumber("Nhap vao so thu hai: ");
            //int sum = Sum(n1, n2);
            Console.WriteLine($"Tong cua hai so {n1} va {n2} la: {Sum(n1, n2)}");

            exitConsoleApp();
        }


        static void exitConsoleApp () {
            ///<summary>
            ///Phuong thuc thoat khoi ung dung console
            ///</summary>
            Console.WriteLine("\n\n**** Press any key to exit! ****");
            Console.ReadKey();
        }

        static int enterNumberIntPos(string mess) {
            Console.WriteLine(mess);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }


        static int enterPostitiveNumber()
        {
            int posNumber;
            do
            {
                Console.WriteLine("Enter a postitive number: ");
                posNumber = Convert.ToInt32(Console.ReadLine());
            } while (posNumber <= 0);
            return posNumber;
        }

        static string enterString(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }
        static int enterNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
