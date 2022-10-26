using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
6. Да се въведе число и да се отпечатат цифрите му в обратен ред 
7. Да се въведе число и да се отпечата сумата от цифрите му 
8. Да се въведе число и да се отпечата колко цифрено е 
9. Да се пресметне сумата между число и огледалното му число
*/
namespace Zadachi6_7_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи цяло число: ");
            int x=int.Parse(Console.ReadLine());

            int s = 0, br = 0;
            int cqlo, ostatyk, ogledalno=0;
            cqlo = x;
            Console.Write("Числото в обратен ред е: ");

            while (cqlo != 0)
            {
                ostatyk = cqlo % 10;    //ost=cqlo%10
                cqlo /= 10;             //cqlo=cqlo/10
                Console.Write(ostatyk);
                s += ostatyk;
                br++;
            }
            Console.WriteLine();
            Console.WriteLine("Брой цифри на числото: " + br);
            Console.WriteLine("Сумата от цифрите на числото е: " + s);

            cqlo = x;
            while (cqlo != 0)
            {                
                ostatyk = cqlo % 10;
                ogledalno += ostatyk;   //ogledalno = ogladalno + ostatyk
                ogledalno *= 10;        //ogledalno = ogladalno * 10
                cqlo /= 10;                
            }

            ogledalno /= 10;
            Console.WriteLine("Огледалното число е: " + ogledalno);
            Console.WriteLine($"Сумата на числото с огледалното му число е: {ogledalno + x}");
            Console.ReadKey();

        }
    }
}
