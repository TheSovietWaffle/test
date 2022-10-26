using System;

namespace Cycle_for_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0, p = 1;
            
            
                Console.Write("Въведете число по-голямо от 0: ");
                n = int.Parse(Console.ReadLine());
            
            while (n <= 0);

            for (int i = 1; i <= n; i++)
            {
                s += i;
                p *= i;
            }
            Console.WriteLine("Сборът е = " + s + " , Произведението е = " + p);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
