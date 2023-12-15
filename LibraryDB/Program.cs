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
                bool endProcess = false;
                do
                {
                    Console.WriteLine("Welcome to my Library\n");
                    Console.WriteLine("Enter your option :");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Add Author");
                    Console.WriteLine("3. Add Person");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter Your Choice : ");
                    string option = Console.ReadLine();

                    Console.WriteLine("\n");

                    switch (option)
                    {
                        case "1":
                            Console.Write("Enter Book Id : ");
                            var bookId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Book Name : ");
                            var bookName = Console.ReadLine();

                            Console.WriteLine("\n");
                            Console.WriteLine("Available Authors :- ");
                            Console.WriteLine("AuthorId \t AuthorName");
                            var allAuthors = context.Authors.ToList();
                            foreach (var item in allAuthors)
                            {
                                Console.WriteLine("{0}       \t {1}", item.AuthorId, item.AuthorName);
                            }
                            Console.Write("Enter the AuthorId : ");
                            var authorId = int.Parse(Console.ReadLine());

                            Console.WriteLine("\n");
                            Console.WriteLine("Available Persons :- ");
                            Console.WriteLine("PersonId \t PersonName");
                            var allPersons = context.Persons.ToList();
                            foreach (var item in allPersons)
                            {
                                Console.WriteLine("{0}       \t {1}", item.PersonId, item.PersonName);
                            }
                            Console.Write("Enter the PersonId : ");
                            var personId = int.Parse(Console.ReadLine());


                            var newBook = new Book() { BookId = bookId, Title = bookName, AuthorId = authorId, PersonId = personId };
                            context.Books.Add(newBook);
                            context.SaveChanges();
                            Console.WriteLine("Book Added Successfully\n");
                            break;

                        case "2":
                            Console.Write("Enter Author Id : ");
                            var autId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Author Name : ");
                            var authorName = Console.ReadLine();

                            var newAuthor = new Author() { AuthorId = autId, AuthorName = authorName };
                            context.Authors.Add(newAuthor);
                            context.SaveChanges();
                            Console.WriteLine("Author Added Successfully\n");
                            break;

                        case "3":
                            Console.Write("Enter Person Id : ");
                            var perId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Person Name : ");
                            var personName = Console.ReadLine();

                            var newPerson = new Person() { PersonId = perId, PersonName = personName };
                            context.Persons.Add(newPerson);
                            context.SaveChanges();
                            Console.WriteLine("Person Added Successfully\n");
                            break;

                        case "4":
                            endProcess = true;
                            break;

                        default:
                            Console.WriteLine("Invalid option please try again\n");
                            break;
                    }
                } while (!endProcess);

                Console.WriteLine("Thank you Visiting.............");
                Console.ReadKey();
            }
        }
    }
}
