using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodPerDay = 0;
            int kgPerDay = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "Adopted")
            {
                foodPerDay += int.Parse(input);
                input = Console.ReadLine();
            }
            if (kgPerDay * 1000 >= foodPerDay)
            {
                Console.WriteLine($"Food is enough!Leftovers: { kgPerDay * 1000 - foodPerDay} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough.You need {Math.Abs(foodPerDay - kgPerDay * 1000)} grams more.");
            }
        }
    }
}
