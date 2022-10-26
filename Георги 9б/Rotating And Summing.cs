using System;
using System.Linq;

namespace RotatingAndSumming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числа като ги отделяте с разстояние: ");
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();
            Console.Write("Въведете броя завъртания: ");
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];

            Console.WriteLine();
            Console.WriteLine("Завъртяните числа изглеждат така: ");
                for (int l = 0; l < k; l++)
                {
                    int o = nums[nums.Length - 1];

                    for (int j = nums.Length - 1; j > 0; j--)
                    {
                        nums[j] = nums[j - 1];
                        sum[j] += nums[j];
                    }
                    nums[0] = 0;
                    sum[0] += nums[0];
                    Console.WriteLine(String.Join(", ", nums));
                }

            Console.WriteLine();
            Console.WriteLine("Сумата от завъртяните числа е: "); ;
            Console.WriteLine(String.Join(", ", sum));

            Console.ReadKey();
        }
    }
}
