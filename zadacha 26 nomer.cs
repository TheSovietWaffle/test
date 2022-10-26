using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Addition(params int[] integers)
            {
                int result = 0;
                for (int i = 0; i < integers.Length; i++)
                {
                    result += integers[i];
                }
                Console.WriteLine(result);
            }

            static void Main(string[] args)
            {

                int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Addition(array);     //10
                
                Addition();    //0

                Console.ReadLine();
            }
    }
}
