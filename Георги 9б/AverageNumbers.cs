using System;

namespace AverageNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число между 2 и 10: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double count = 0;

            if (n <= 2 || n >= 10)
                Console.WriteLine("Грешно въведено число!");

            else
            {
                double[] nums = new double[n];
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] = int.Parse(Console.ReadLine());

                        if (nums[i] > 0)
                        {
                            sum += nums[i];
                            count++;
                        }

                    }
                    Console.WriteLine("Средно аритметичното на положителните числа е: {0}", sum / count);
                }
            }
            Console.ReadKey();
        }
    }
}
