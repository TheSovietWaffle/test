
using System;

namespace SwitchPlaces
{
    class Program
    {
        static void chisla(int a, int b)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }

        static void Main(string[] args)
        {
            Console.Write("въведете а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("въведете b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Преди:");
            
            chisla(a, b);

            Console.WriteLine();
            Console.WriteLine("След:");

            chisla(b, a);

            Console.ReadKey();
        }
    }
}
