using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_po_SI___29._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            country strana = new country();
            strana.Strana();
            city grad = new city();
            grad.Grad();
            school uchilishte = new school();
            uchilishte.Uchilichte();
            student uchenik = new student();
            uchenik.Uchenik();
            prepodawatel uchitel = new prepodawatel();
            uchitel.Prepodawatel();
            predmet Predmet = new predmet();
            Predmet.Predmet1();
            Predmet.method();
            Console.ReadKey();
        }
    }
}
