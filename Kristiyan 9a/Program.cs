using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;

            // Perform an "infinite loop"

            while (true)

            {

                if (n <= 1)

                {

                    break;

                }

                factorial *= n;

                n--;

            }

            Console.WriteLine("n! = " + factorial);
        }
    }
}
