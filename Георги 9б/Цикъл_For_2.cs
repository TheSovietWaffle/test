using System;

namespace Cycle_for_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a;

            Console.Write("Въведете степента на израза (n > 0): ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Въведете реално число: ");
            a = double.Parse(Console.ReadLine());
            double p = a;

            for (int i = 1; i < n; i++)
            {
                p *= a;
            }

            Console.Write("Числото " + (a) + " на степен " + (n) + " е равно на: " + (p) );
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
