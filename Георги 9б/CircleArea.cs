using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a radius: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(Math.PI * r * r, 13));
            Console.WriteLine("{0:f13}", Math.PI * r * r);

            Console.ReadKey();
        }
    }
}
