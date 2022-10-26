using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiDo200
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1, b=2, c;
            Console.Write("{0}, {1}, ",a,b);
            c = a + b;
            while (c < 200)
            {               
                a = b;
                b = c;
                Console.Write("{0}, ",c);
                c = a + b;
            }            
            Console.ReadKey();
        }
    }
}
