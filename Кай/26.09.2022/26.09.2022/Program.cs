using System;

namespace _26._09._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter r:");
            double r;
            r = Convert.ToDouble(Console.ReadLine());
            double PI = Math.PI;
            double S = PI * r * r;
            Console.WriteLine(S);
            Math.Round(S, 12);
        }
    }
}