
using System;

namespace Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(3, 21);
            int[] arr1 = new int[n];

            for (int i = 0; i < arr1.Length; i++)
            {
                Random Ran = new Random();
                int r = Ran.Next(-200, 201); 
                arr1[i] = r; 
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int negative = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < 0)
                    negative++;
            }

            Console.Write("Отрицателните числа са: " + negative);

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();

            //2 zad
            bool flag = false;

            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if (arr1[i] == arr1[i + 1])
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Има повтарящи се, последователни числа! ");

            else
                Console.WriteLine("Няма повтарящи се, последователни числа! ");

            Console.WriteLine();
            
            Console.ReadKey();

            //3 zad
            int nulls = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == 0)
                    nulls++;
            }

            if (nulls > 0)
                Console.WriteLine("Има {0} нулеви елементи! ", nulls);

            else
                Console.WriteLine("Няма нулеви елементи! ");

            Console.WriteLine();
            
            Console.ReadKey();

            //4 zad
            int positive = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                    positive++;
            }

            Console.WriteLine("Положителните числа са: " + positive);
            Console.WriteLine();

            
            int differece = 0;

            if (negative > positive)
            {
                differece = negative - positive;
                Console.WriteLine("Отрицателните числа са с {0} повече! ", differece);
            }
            
            else if (negative < positive)
            {
                differece = positive - negative;
                Console.WriteLine("Положителните числа са с {0} повече! ", differece);
            }

            else
            {
                Console.WriteLine("Пoложителните и отрицателните числа имат равен брой: " + negative);
            }

            Console.WriteLine();
            Console.ReadKey();

            // 5 zad
            bool flag1 = true;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                if (arr1[i] > arr1[i + 1])
                {
                    flag1 = false;
                    break;
                }
            }

            if (flag1)
                Console.WriteLine("Елементите са подредени във възходящ ред! ");

            else
                Console.WriteLine("Елементите не са подредени във възходящ ред! ");

            Console.WriteLine();
            Console.ReadKey();

            //6 zad
            int sum = 0;
            foreach (int i in arr1)
            {
                sum += i;
            }

            Console.WriteLine("Сборът на числата е: " + sum);

            Console.WriteLine();
            Console.ReadKey();

            //7 zad
            int zerohundret = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] >= 0 && arr1[i] <= 100)
                    zerohundret++;
            }

            Console.WriteLine("Числата в интервала от 0 до 100 са; " + zerohundret);

            Console.WriteLine();
            Console.ReadKey();

            //10 zad
            int avg = sum / n;

            Console.WriteLine("Средноариметичното на елементите в масива е: " + avg);
            Console.WriteLine();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == avg)
                {
                    Console.WriteLine("Има число, равно на средноаритметичното на масива! ");
                    break;
                }

                else
                {
                    Console.WriteLine("Няма число, равно на средноаритметичното на масива! ");
                    break;
                }
            }

            Console.WriteLine();
            Console.ReadKey();

            //11 zad

            Console.Write("Въведете число: ");
            int x = int.Parse(Console.ReadLine());
            int brX = 0;

            Console.WriteLine();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == x)
                    brX++;
            }

            if (brX == 0)
                Console.WriteLine("В масива няма елемнт, равен на Вашето число! ");

            else if (brX == 1)
                Console.WriteLine("Вашето число се среща {0} път! ", brX) ;

            else
                Console.WriteLine("Вашето число се среща {0} пъти! ", brX);

            Console.WriteLine();
            Console.ReadKey();

            //12 zad

            int brAvg = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > avg)
                    brAvg++;
            }

            if (brAvg > 0)
                Console.WriteLine("Елементите, по-големи от средноаритметичното на масива са: " + brAvg);

            else
                Console.WriteLine("Няма елементи по-големи от средноаритметичното на масива! ");

            Console.WriteLine();
            Console.ReadKey();

            //13 zad

            int max = arr1[0];
            int brMax = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (max < arr1[i])
                    max = arr1[i];
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (max == arr1[i])
                    brMax++;
            }

            if (brMax == 1)
            Console.WriteLine("Най-големият елемент се среща {0} път! ", brMax);

            else if (brMax > 1)
                Console.WriteLine("Най-големият елемент се среща {0} пъти! ", brMax);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
