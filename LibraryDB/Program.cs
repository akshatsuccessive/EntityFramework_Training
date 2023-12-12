using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (LibraryContext context = new LibraryContext())
            {
                //var newBook = new Book() { BookId = 2, Title = "Sapiens", BookAuthor = newAuthor };
                //context.Books.Add(newBook);
                //context.SaveChanges();

                Console.WriteLine("Database Created Successfully");
                Console.ReadKey();
            }  
        }
    }
}
