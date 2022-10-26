using System;

namespace RealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            decimal resault = 0;

            for (int i = 1; i <= k; i++)
            {
                resault += decimal.Parse(Console.ReadLine());
            }
            
            Console.Write(resault);

            Console.ReadKey();
        }
    }
}
