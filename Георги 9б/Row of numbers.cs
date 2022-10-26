using System;

namespace Triangle
{
    class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Въведете начално число: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Въведете крайно число: ");
            b = int.Parse(Console.ReadLine());

            PrintLine(a, b);

            Console.ReadKey();
        }
    }
}
