using System;

namespace Rectangle
{
    class Program
    {
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(
          new string('-', 4 * n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < (2 * n); i++)
                Console.Write("\\/");
            Console.WriteLine('-');
        }
        static void Main()
        {
            int n = 6;
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
                PrintMiddleRow(n);
            PrintHeaderRow(n);

            Console.ReadKey();
        }
    }
}
