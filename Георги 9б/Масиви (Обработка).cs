using System;
using System.Linq;

namespace Array__Obrabotka_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете думи: ");
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine();

            Console.WriteLine("Избирайте команди от - (Reverse, Sort, Replace, Distinct); за да приключите, въведете - (End) ");
            Console.WriteLine();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Въведете команда: ");
                string com = Console.ReadLine();

                if (com == "End")
                    break;

                switch (com)
                {
                    case "Reverse":
                        {
                            Array.Reverse(arr);
                            Console.WriteLine(string.Join(" ", arr));  break;
                        }

                    case "Sort":
                        {
                            Array.Sort(arr);
                            Console.WriteLine(string.Join(" ", arr)); break;
                        }

                    case "Replace":
                        {
                            Console.WriteLine("Въведете дума, с която да се замени елемент от масива: ");
                            string[] source = new string[1];
                            for (int l = 0; l < 1; l++)
                                source[l] = Console.ReadLine();

                            Console.WriteLine("Въведете позицията на елемента, който да се замени: ");
                            int n = int.Parse(Console.ReadLine());

                            if (n < 0 || n > arr.Length)
                            {
                                Console.WriteLine("Грешна позиция! "); break;
                            }

                            else
                            {
                                source.CopyTo(arr, n);
                                Console.WriteLine(string.Join(" ", arr)); break;
                            }
                        }

                    case "Distinct":
                        {
                            arr.Distinct();
                            Console.WriteLine(string.Join(" ", arr)); break;
                        }

                    default:
                        {
                            Console.WriteLine("Грешно зададена команда! "); break;
                        }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
