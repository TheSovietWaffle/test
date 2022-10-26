using System;

namespace Домашна_работа__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X1 = ");
            double X1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("X2 = ");
            double X2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Y1 = ");
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Y2 = ");
            double Y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2)) = ");
            Console.WriteLine(Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2)));
        }
    }
}
