using System;

namespace Квадрат
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Лице на квадрат = ");
            Console.WriteLine(area);

            var tour = a + a + a + a;
            Console.Write("Обиколка на квадрат = ");
            Console.WriteLine(tour);
        }
    }
}
