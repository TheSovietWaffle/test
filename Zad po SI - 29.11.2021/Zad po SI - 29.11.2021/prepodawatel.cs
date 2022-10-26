using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_po_SI___29._11._2021
{
    public class prepodawatel : predmet
    {
        string ime_na_prepodawatel;
        public void Prepodawatel()
        {
            Console.Write("Wuwedete ime na prepodawatel: ");
            ime_na_prepodawatel = Console.ReadLine();
            Console.WriteLine("****************************");
        }
    }
}
