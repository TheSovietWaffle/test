using System;

namespace From10To16AndTo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете Десетично число:");
            int n = int.Parse(Console.ReadLine());
            string s = Convert.ToString(n, 16);
            string b = Convert.ToString(n, 2);

            Console.WriteLine("Шеснайсетичното число е: " + s);
            Console.WriteLine("Двуичното число е: " + b);

            Console.ReadKey();
        }
    }
}
