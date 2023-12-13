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
                //var authors = context.Authors.ToList();
                //foreach (var item in authors)
                //{
                //    Console.WriteLine("{0}\t{1}", item.AuthorId, item.AuthorName);
                //}

                var myBooks = context.Books.ToList();
                foreach (var book in myBooks)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}", book.BookId, book.Title, book.AuthorId, book.PersonId);
                }

                //Console.WriteLine("Database Created Successfully");
                Console.ReadKey();
            }
        }
    }
}
