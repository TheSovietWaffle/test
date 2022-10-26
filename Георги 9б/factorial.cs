using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

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

            Console.ReadKey();
        }
    }
}
