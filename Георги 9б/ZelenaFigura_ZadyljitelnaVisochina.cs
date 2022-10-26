using System;

namespace ЗеленаПлощ
{
    class Program
    {

        static double Triangle(double a, double h = 4)
        {
            double S = Math.Round((a * h) / 2, 2);
            return S;
        }

        static double LittleRectangle(double a1, double b1)
        {
            double S1 = Math.Round(a1 * b1, 2);
            return S1;
        }

        static double BigRectangle(double A, double B)
        {
            double S2 = Math.Round((A * B), 2);
            return S2;
        }


        static void Main(string[] args)
        {
            Console.Write("Въведете страната на вписния триъгълник: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Височината на триъгълника е 4");

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Въведете страната на вписания правоъгълик: ");
            double a1 = double.Parse(Console.ReadLine());

            Console.Write("Въведете другата страната на вписания правоъгълик: ");
            double b1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Въведете страната на големия правоъгълик: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Въведете другата страната на големия правоъгълик: ");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Лицето на вписания триъгълник е: " + Triangle(a));
            Console.WriteLine("Лицето на вписания правоъгълник е: " + LittleRectangle(a1, b1));
            Console.WriteLine("Лицето на големият правоъгълник е: " + BigRectangle(A, B));

            double S3 = (BigRectangle(A, B) - ((LittleRectangle(a1, b1)) + (Triangle(a))));
            Console.WriteLine("Лицето на зелената фигура е: " + S3);

            Console.ReadKey();
        }
    }
}