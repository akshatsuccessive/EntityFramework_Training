using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exercise
{
    internal class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
