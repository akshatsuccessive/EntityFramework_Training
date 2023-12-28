using System;
using System.Collections.Generic;
using System.Data.Entity;
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

                //var authors = context.Authors.ToList();
                //foreach (var item in authors)
                //{
                //    Console.WriteLine("{0}\t{1}", item.AuthorId, item.AuthorName);
                //}

                //var myBooks = context.Books.ToList();
                //foreach (var book in myBooks)
                //{
                //    Console.WriteLine("{0} - {1} - {2} - {3}", book.BookId, book.Title, book.AuthorId, book.PersonId);
                //}

                bool endProcess = false;
                do
                {
                    Console.WriteLine("Welcome to my Library\n");
                    Console.WriteLine("Enter your option :");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Add Author");
                    Console.WriteLine("3. Add Person");
                    Console.WriteLine("4. View All Books");
                    Console.WriteLine("5. View All Authors");
                    Console.WriteLine("6. View All Person");
                    Console.WriteLine("7. Exit");
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
                            Console.WriteLine("\nAll Books :- \n");
                            var allBooks = context.Books.ToList();
                            foreach (var book in allBooks)
                            {
                                Console.WriteLine("{0}.\t {1}", book.BookId, book.Title);
                            }
                            Console.WriteLine("\n");
                            break;

                        case "5":
                            Console.WriteLine("\nAll Authors :- \n");
                            var allAuths = context.Authors.ToList();
                            foreach (var auth in allAuths)
                            {
                                Console.WriteLine("{0}.\t {1}", auth.AuthorId, auth.AuthorName);
                            }
                            Console.WriteLine("\n");
                            break;

                        case "6":
                            Console.WriteLine("\nAll Persons :- \n");
                            var allMembers = context.Persons.ToList();
                            foreach (var person in allMembers)
                            {
                                Console.WriteLine("{0}.\t {1}", person.PersonId, person.PersonName);
                            }
                            Console.WriteLine("\n");
                            break;

                        case "7":
                            endProcess = true;
                            break;

                        default:
                            Console.WriteLine("Invalid option please try again\n");
                            break;
                    }
                } while (!endProcess);


                //Console.WriteLine( "Database Created Successfully");
                Console.WriteLine("Thank you Visiting.............");
                Console.ReadKey();
            }
        }
    }
}
