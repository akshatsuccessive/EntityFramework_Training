using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // adding a student
            using (EFCodeFirstContext context = new EFCodeFirstContext())
            {
                var stud = new Student() { FirstName = "Akshat", LastName = "Kumar" };
                context.Students.Add(stud);
                context.SaveChanges();
                Console.WriteLine("Student Added");
                Console.ReadKey();
            }
        }
    }
}
