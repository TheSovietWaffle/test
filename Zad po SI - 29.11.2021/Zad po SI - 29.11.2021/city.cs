using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_po_SI___29._11._2021
{
    public class city : school
    {
        string city_name;
        string city_kwartal;
        public void Grad()
        {
            Console.Write("Wuwedi ime na grad ot stranata: ");
            city_name = Console.ReadLine();
            Console.Write("wuwedi ime na kwartal ot grada: ");
            city_kwartal = Console.ReadLine();
            Console.WriteLine("**************************************");
        }
    }
}
