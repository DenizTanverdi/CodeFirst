using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class CodeFirsDbContext:DbContext
    {

        public DbSet<Kisiler> Kisiler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
    }
}
