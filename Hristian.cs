using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter number y: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Enter true for * or false for -: ");
                string temp = Console.ReadLine().ToLower().Trim();
                bool b = temp == "t" || temp == "true" ? true : false;

                Console.WriteLine(Ex1(x, y, b));
                Console.ReadKey();
                Console.Clear();
            }
        }
        static double Ex1(double x, double y, bool b)
        {
            if (b)
            {
                return x * y;
            }
            else
            {
                return x - y;
            }
        }
    }
 }
