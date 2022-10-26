using System;

namespace Stripes_Loop
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
                Console.WriteLine();
                for (int j = 1; j <= n; j++)
                {
                    if (j == i - 4 || j == i + 4 )
                        Console.Write("&" + " ");
                    else
                        Console.Write("*" + " ");
                }           
            }

            Console.ReadKey();
        }
    }
}
