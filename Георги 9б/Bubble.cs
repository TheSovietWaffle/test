using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на числата: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine();

            for (int l = 0; l < arr1.Length; l++)
            {
                Console.Write("Въведете поредно число: ");
                arr1[l] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Несортираните числа са: ");
            for (int k = 0; k < arr1.Length; k++)
                Console.Write(arr1[k] + " ");

            for (int j = 0; j < arr1.Length; j++)
            {
                for (int m = 0; m < arr1.Length - 1; m++)
                {
                    if (arr1[m] > arr1[m + 1])
                    {
                        int temp = arr1[m];
                        arr1[m] = arr1[m + 1];
                        arr1[m + 1] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Сортираните числа са: ");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[] arr2 = new int[5] { 3, 6, 9, 1, 8};

            Console.Write("Несортираните числа са: ");
            for (int c = 0; c < arr2.Length; c++)
                Console.Write(arr2[c] + " ");

            for (int a = 0; a < arr2.Length; a++)
            {
                for (int b = 0; b < arr2.Length - 1; b++)
                {
                    if (arr2[b] < arr2[b + 1])
                    {
                        int tmp = arr2[b];
                        arr2[b] = arr2[b + 1];
                        arr2[b + 1] = tmp; 
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Сортираните числа са: ");
            for (int d = 0; d < arr2.Length; d++)
                Console.Write(arr2[d] + " ");

            Console.ReadKey();
        }
    }
}
