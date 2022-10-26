using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write (true for yes or false for no)");

            string n = Console.ReadLine();
            bool m = Convert.ToBoolean(n);

            if (m == true)
                Console.WriteLine("Yes");

            else if (m == false)
                Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}
