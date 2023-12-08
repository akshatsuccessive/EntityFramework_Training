using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeDemo
{
    internal class EFCodeFirstContext : DbContext
    {
        public EFCodeFirstContext() : base()
        {
        }
        //Adding Domain Classes as DbSet
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
