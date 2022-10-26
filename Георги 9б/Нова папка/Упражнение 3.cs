using System;

namespace uprajnenie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 задача
            Console.Write("Вашите килограми на Земята = ");
            var ek = Convert.ToDouble(Console.ReadLine());
            var math = ek * 0.17;
            Console.Write("Вашите килограми на Луната = ");
            Console.WriteLine(math);

            // 2 задача
            Console.Write("Разстояние между градовете в километри = ");
            var dc = Convert.ToDouble(Console.ReadLine());
            var dk = dc * 0.6214;
            Console.Write("Разстояние между градовете в мили = ");
            Console.WriteLine(dk);

            // 3 задача
            Console.Write("Брой земни дни = ");
            var ed = Convert.ToDouble(Console.ReadLine());
            var jy = (ed / 365.25) / 12;
            Console.Write("Години на Юпитер = ");
            Console.WriteLine(jy);

            // 4 задача
            Console.WriteLine("Дължина на правоъгълник = 543мм.");
            Console.WriteLine("Ширина на правоъгълник = 130мм.");
            Console.WriteLine("Страна на квадрат = 130мм.");
            var a = 543;
            var b = 130;
            var c = 130;
            var resault = (a * b) / (c * c);
            Console.Write("Брой квадрати, които могат да се отрежат = ");
            Console.WriteLine(resault);

            // 5 задача
            Console.Write("a на призмата = ");
            var m = Convert.ToDouble(Console.ReadLine());
            Console.Write("b на призмата = ");
            var n = Convert.ToDouble(Console.ReadLine());
            Console.Write("h на призмата = ");
            var h = Convert.ToDouble(Console.ReadLine());

            var capacity = m * n * h;
            Console.Write("Обем на призмата =");
            Console.WriteLine(capacity);
            
            var tour = h * 2 * (m + n + m * n);
            Console.Write("Лице на призмата = ");
            Console.WriteLine(tour);

            double lcapacity = Convert.ToDouble (m / 2) * (n / 2) * (h / 2);
            Console.Write("Обем на призма с два пъти по-малки размери = ");
            Console.WriteLine(lcapacity);

            double ltour = Convert.ToDouble (h / 2) * 2 * ((m / 2) + (n / 2) + (m / 2) * (n / 2));
            Console.Write("Лице на призма с два пъти по-малки размери = ");
            Console.WriteLine(ltour);
        }
    }
}
