using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете векове: ");
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;

            int days = (int) (years * 365.2422);

            int hours = 24 * days;

            int minutes = 60 * hours;

            Console.WriteLine("{0} векa = {1} години = {2} дни = {3} часа = {4} минути", centuries, years, days, hours, minutes);

            Console.ReadKey();
        }
    }
}
