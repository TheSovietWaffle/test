using System;
using System.Linq;

namespace Obrabotka_Na_Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дължината на масива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Въведете елемнтите в масива: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Масивът е: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Array.Sort(arr);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Масивът във възходящ ред е: ");
            Console.WriteLine(String.Join(" ", arr));

            int[] dis = arr.Distinct().ToArray();
 
            Console.WriteLine();
            Console.WriteLine("Mасивът без повтарящи се елементи е: ");
            Console.WriteLine(string.Join(" ", dis));

            Array.Reverse(dis);
            Console.WriteLine();
            Console.WriteLine("Обърнатият масив е: ");
            Console.WriteLine(string.Join(" ", dis));

            Console.WriteLine();
            Console.WriteLine("Въведете число, с което да се замени елемент в масива: ");

            int[] change = new int[1];
            for (int i = 0; i < change.Length; i++)
            {
                change[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Въведете индекса на елемента, който искате да замените: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine();
            change.CopyTo(dis, m);

            Console.WriteLine("Промененият масив е: ");
            Console.WriteLine(string.Join(" ", dis));

            Console.ReadKey();
        }
    }
}
