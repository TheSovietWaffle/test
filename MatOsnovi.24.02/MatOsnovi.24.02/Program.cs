using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatOsnovi._24._02
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class Emoloyees
    {
        public int EmployeeID { get; set; }
        public string NameName { get; set; }
        public string JobTitle { get; set; }
        public int AdressesID { get; set; }
    }
    public class Adress
    {
        public int AdressID { get; set; }
        public string StudentName { get; set; }
        public string TownName { get; set; }
    }
   
    class AdressComparer : IEqualityComparer<Adress>
{
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID & amp; &amp; x.StudentName.ToLower() ==
              y.StudentName.ToLower())
              {
return true;
            return false;
            }
              
        }

        public bool Equals(Adress x, Adress y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }

        public int GetHashCode(Adress obj)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
