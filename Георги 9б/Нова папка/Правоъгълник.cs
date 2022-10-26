using System;

namespace Правоъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            var b = int.Parse(Console.ReadLine());

            var tour = 2 * a + 2 * b;
            Console.Write("Обиколка на правоъгълник = ");
            Console.WriteLine(tour);

            var area = a * b;
            Console.Write("Лице на правоъълник = ");
            Console.WriteLine(area);
        }
    }
}
