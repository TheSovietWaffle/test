using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_po_SI___29._11._2021
{
    public class school : student
    {
        string school_name;
        int broi_na_uchenicite_w_uchilichte;
        public void Uchilichte()
        {
            Console.Write("Wuwedeteime na uchilichteto: ");
            school_name = Console.ReadLine();
            Console.Write("Wuwedete broi na uchenicite w uchilishteto: ");
            broi_na_uchenicite_w_uchilichte = int.Parse(Console.ReadLine());
            Console.WriteLine("***********************************************");
        }
    }
}
