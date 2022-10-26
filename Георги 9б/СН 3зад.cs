using System;

namespace Simvolni_Nizove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете символен низ: ");
            string str = Console.ReadLine();

            Console.Write("Обърнатият низ е: ");

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

            

            Console.ReadKey();
        }
    }
}
