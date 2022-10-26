using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_po_SI___29._11._2021
{
    public class student : predmet
    {
        string ime_na_uchenik;
        string klas;
        int nomer_w_klas;
        public void Uchenik()
        {
            Console.Write("Wuwedete ime na uchenika: ");
            ime_na_uchenik = Console.ReadLine();
            Console.Write("Wuwedete klas w uchilishte: ");
            klas = Console.ReadLine();
            Console.Write("Wuwedete nimer w klasa: ");
            nomer_w_klas = int.Parse(Console.ReadLine());
            Console.WriteLine("********************************");
        }
    }
}
