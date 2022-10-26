using System;

namespace WholeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = -100;
            byte num2 = 128;
            short num3 = -3540;
            ushort num4 = 64876;
            uint num5 = 2147483648;
            int num6 = -1141583228;
            long num7 = -1223372036854775808;

            Console.Write("First number - {0}, second number - {1}, third number - {2}" +
                " fourth number - {3}, fifth number - {4}, sixht number - {5}, seventh number - {6}",
                num1, num2, num3, num4, num5, num6, num7);

            Console.ReadKey();
        }
    }
}