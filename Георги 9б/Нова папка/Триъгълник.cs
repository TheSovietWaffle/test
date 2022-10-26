using System;

namespace Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("а = ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            var b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            var c = int.Parse(Console.ReadLine());

            Console.Write("h = ");
            var h = int.Parse(Console.ReadLine());

            var tour = a + b + c;
            Console.Write("Обиколка на триъгълник = ");
            Console.WriteLine(tour);

            var area = (a * h) / 2;
            Console.Write("Лице на триъгълник = ");
            Console.WriteLine(area);
        }
    }
}
