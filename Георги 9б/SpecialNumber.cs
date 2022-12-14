using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете колко числа да бъдат записани: ");
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", num, special);
            }

            Console.ReadKey();
        }
    }
}
