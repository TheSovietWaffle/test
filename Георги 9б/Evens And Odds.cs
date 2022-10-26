using System;

namespace EvenTimesOdd
{
    class Program
    {
        static int Even(int n)
        {
            int SumEven = 0;
            while(n > 0)
            {
                if (n % 10 % 2 == 0)
                    SumEven += n % 10;

                n /= 10;
            }
            return SumEven;
        }

        static int Odd(int n)
        {
            int SumOdd = 0;
            while(n > 0)
            {
                if (n % 10 % 2 != 0)
                    SumOdd += n % 10;

                n /= 10;
            }
            return SumOdd;
        }

        static int Both(int n)
        {
            int SumE = Even(n);
            int SumO = Odd(n);
            return SumE * SumO;
        }
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(Both(n));

            Console.ReadKey();
        }
    }
}
