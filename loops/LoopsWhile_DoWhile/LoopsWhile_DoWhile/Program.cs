using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Да се позволи въвеждане на числа до въвеждане на 0 и 
   да се отпечата сумата им
2. Да се позволи въвеждане на числа до въвеждане на 0 и 
   да се отпечата произведението им
3. Да се позволи въвеждане на числа до въвеждане на 0 и
   да се отпечата броят им
4. Да се позволи въвеждане на числа до въвеждане на 0 и 
   да се отпечата най-малкото и най-голямото от тях
*/
namespace LoopsWhile_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
                    //init s-сума; p-произведение; br-брой; min, max:
            int s = 0, p = 1, br = 0, min, max;
            Console.WriteLine("Стартирай въвеждане, за край на въвеждането - 0");
            Console.Write("Въведи поредно число:");
                    //init x-число, което се въвежда многократно (упр. пром):
            int x = int.Parse(Console.ReadLine());
                    //init min и max:
            min = max = x;
            while (x!=0)
            {
                br++;
                s += x;
                p *= x;
                if (x < min) min = x;
                if (x > max) max = x;
                Console.Write("Въведи поредно число:");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Броят на въведените числа е: {0}",br);
            Console.WriteLine("Сумата на въведените числа е: {0}",s);
            Console.WriteLine("Произведението на въведените числа е: {0}",p);
            Console.WriteLine("Най-малко от на въведените числа е: {0}",min);
            Console.WriteLine("Най-голямо от на въведените числа е: {0}",max);

            Console.ReadKey();
        }
    }
}
