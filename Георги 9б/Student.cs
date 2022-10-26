using System;

namespace Student
{
    class Program
    {
        static void PrintStudent(string name, int age, double grade)
        {
            Console.Write("Student: {0}, Age: {1}, Grade: {2}", name, age, grade); ;
        }


        static void Main(string[] args)
        {
            string name ="Georgi Davchev";
            int age = 15;
            double grade = 5.94;
            PrintStudent(name, age, grade);

            Console.ReadKey();
        }
    }
}
