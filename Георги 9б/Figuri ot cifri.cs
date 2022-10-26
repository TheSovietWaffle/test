using System;

namespace triugulnik_ot_cifri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Въведете число: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            for (int m = 1; m <= n; m++)
            {
                for (int j = 1; j <= m; j++)
                Console.Write(j + " ");
                Console.WriteLine();
            }

            Console.WriteLine(" ");

            for (int i = 1; i <= n; i++)
            {
                for (int h = i; h < 2 * i; h++)
                Console.Write(h + " ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}