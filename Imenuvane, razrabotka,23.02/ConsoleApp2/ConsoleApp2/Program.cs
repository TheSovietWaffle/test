using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class GFG
        {
            public static List<int> Union(List<int> firstList, List<int> secondList)
            {
                List<int> result = new List<int>();
                result = (List<int>)firstList.Union(secondList);
                return result;
            }
            public static List<int> Intersect(List<int> firstList, List<int> secondList)
            {
                List<int> result = new List<int>();
                result = (List<int>)firstList.Intersect(secondList);
                return result;
            }
            public static void Main(string[] args)
            {
                // Напишете програма, която позволява на потребителя да въведе стойности
                //в два списъка. Обединете ги и намерете сечението им.
                // Разделете задачите на статични методи, а защо не използвате клас ListUnion
                // за да решите задачата с обектно ориентиран подход ?
                List<int> firstList = new List<int>();
                firstList.Add(1); firstList.Add(2); firstList.Add(3); firstList.Add(4); firstList.Add(5); Console.Write("firstList=");

                foreach (var el in firstList)
                {
                    Console.WriteLine(el);
                }

                List<int> secondList = new List<int>();
                secondList.Add(2);
                secondList.Add(4);
                secondList.Add(6);
                Console.Write("secondList = ");
                foreach (var el in secondList)
                {
                    Console.WriteLine(el);
                }
                List<int> unionList = Union(firstList, secondList);
                Console.Write("union = ");

                // Използване на метода union
                IEnumerable<int> union = firstList.Union(secondList);

                foreach (int num in union)
                {
                    if (!unionList.Contains(num))
                    {
                        unionList.Add(num);
                    }
                }

                ///<list>
                ///Izvejdane na elementie
                /// </list>

                foreach (var el in unionList)
                {
                    Console.WriteLine(el);
                }
               // List<int> intersectList = Intersect(firstList, secondList);
               // Console.Write("intersect = ");


                //foreach (var el in intersectList)
                {
                    Console.WriteLine(el);
                }

            }
        }
    }
}
    

