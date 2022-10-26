using System;

namespace figuri__Loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Въведете число: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(" * ");    
                }

                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
