using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SoczewkiChorzow.Model
{
    public class DateBaseContext:DbContext
    {
        public DateBaseContext():base("Data Source =.\\SQLEXPRESS ; Initial Catalog = Soczewki; User ID = sa; Password=PGM@210439")
        { 

        }
        public DbSet<User> User { get; set; }
        public DbSet<Lens> Lens { get; set; }
        public DbSet<Address>  Addresses { get; set; }
    }
}
