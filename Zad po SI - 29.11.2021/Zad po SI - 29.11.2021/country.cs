using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_po_SI___29._11._2021
{
    public class country : city
    {
        string country_name;
        public void Strana()
        {
            Console.Write("Wuwedi stara: ");
            country_name = Console.ReadLine();
            Console.WriteLine("****************************");
        }
    }
}
