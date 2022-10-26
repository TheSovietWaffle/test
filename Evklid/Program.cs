using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * от по-голямото се вади по-малкото, докато се изравнят
 */

namespace Evklid
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Въведи първото число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Въведи второто число: ");
            b= int.Parse(Console.ReadLine());
            int a1 = a, b1 = b;

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine("НОД на {0} и {1} е {2}", a1, b1, a);            
            

        }
    }
    
}
