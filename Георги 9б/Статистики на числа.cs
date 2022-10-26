using System;

namespace Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой на числата: ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете поредно число: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            int min = nums[0];
            for (int m = 0; m < nums.Length; m++)
            {
                if (nums[m] < min)
                {        
                        min = nums[m];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Най-малкото число е: " + min);

            int max = nums[0];
            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] > max)
                {
                    max = nums[x];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Най-голямото число е: " + max);

            int sum = 0;
            double average1 = 0;

            for (int b = 0; b < nums.Length; b++)
            {
                sum += nums[b];
                average1 = (double)sum / n;
            }

            Console.WriteLine();
            Console.WriteLine("Сумата от числата е: " + sum);
            Console.WriteLine();
            Console.WriteLine("Средното аритметично на числата е: " + average1);


            Console.ReadKey();
        }
    }
}
