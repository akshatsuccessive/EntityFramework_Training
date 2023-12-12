using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exercise
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public virtual ICollection<Book> BooksIssued { get; set; }
    }
}
