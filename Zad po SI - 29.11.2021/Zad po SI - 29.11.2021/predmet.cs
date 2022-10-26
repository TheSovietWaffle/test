using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_po_SI___29._11._2021
{
    public class predmet
    {
        string ime_na_predmeta;
        public void Predmet1()
        {
            Console.Write("Wuwedete ime na predmeta: ");
            ime_na_predmeta = Console.ReadLine();
        }
        double[] otsenki = new double[26];
        public void method()
        {
            Random rand = new Random();
            double sredno = 0;
            for (int i = 0; i < otsenki.Length; i++)
            {
                otsenki[i] = rand.Next(2, 6);
                sredno += otsenki[i];
            }
            sredno = sredno / otsenki.Length;
            Console.WriteLine("Srednata ochenka za predmeta e : {0}",sredno);
            Console.WriteLine("*********************************");
        }
    }
}
