using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EF_Exercise
{
    internal class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryContext") 
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LibraryContext>());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
