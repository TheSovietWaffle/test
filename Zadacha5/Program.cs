using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
5. Да се позволи въвеждане на числа докато не се въведат 3 положителни. 

 */
namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стартирай въвеждане на числа, за край на въвеждането - три положителни");
            Console.Write("Въведи поредно число:");
            int x = int.Parse(Console.ReadLine());

            int brPos = 0;
            if (x > 0) brPos++;
            int br = 1;

            while (brPos < 3)
            {                
                Console.Write("Въведи поредно число:");
                x = int.Parse(Console.ReadLine());
                if (x > 0) brPos++;
                br++;
            }

            Console.WriteLine("Въведохте {0} числа",br);
            Console.ReadKey();
        }           
        
    }
}
