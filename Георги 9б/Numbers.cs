using System;

namespace Numbers
{
    class Program
    {
        static void PrintSign(int number)
        {
            if (number > 0)
                Console.WriteLine("The number {0} is positive!", number);
            else if (number < 0)
                Console.WriteLine("The number {0} is negative!", number);
            else
                Console.WriteLine("The number {0} is zero!", number);
        }

        static void Main(string[] args)
        {
            int number;

            Console.Write("Write a number: ");
            number = int.Parse(Console.ReadLine());
            PrintSign(number);

            Console.ReadKey();
        }
    }
}
