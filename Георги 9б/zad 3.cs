using System;

namespace From16To10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете шеснайсетично число: ");
            int n = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine("Десетичното число е " + n);
            
            Console.ReadKey();
        }
    }
}
