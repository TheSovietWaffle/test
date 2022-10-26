using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6_s_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи цяло число: ");
            int x = int.Parse(Console.ReadLine());
            int cqlo, ostatyk, ogledalno = 0;
            cqlo = x;
            int s = 0, br = 0;
            

            Console.Write("Числото {0} в обратен ред е: ",x);
            do
            {
                ostatyk = cqlo % 10;   //ost = x % 10
                cqlo /= 10;            //x = x / 10

                Console.Write(ostatyk);
                s += ostatyk;
                br++;
            }
            while (cqlo != 0);
            Console.WriteLine();
            Console.WriteLine("Брой цифри на числото: " + br);
            Console.WriteLine("Сумата от цифрите на числото е: " + s);

            cqlo = x;
            do
            {
                ostatyk = cqlo % 10;    
                ogledalno += ostatyk;   //ogledalno=ogledalno+ostatyk
                ogledalno *= 10;        //ogledalno = ogledalno*10
                cqlo /= 10;             //cqlo=cqlo*10 
            }
            while (cqlo != 0);
            ogledalno /= 10;
            Console.WriteLine("Огледалното число е: " + ogledalno);
            Console.WriteLine($"Сумата на числото с огледалното му число е: {ogledalno+x}");

            Console.ReadKey();
        }
    }
}
