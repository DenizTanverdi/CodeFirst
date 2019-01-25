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
        /*public CodeFirsDbContext() : base("name=StokDB")
        {

        }*/
        public DbSet<Kisiler> Kisiler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Kategori> Kategori { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kisiler>().ToTable("Kisiler");
            modelBuilder.Entity<Firma>().ToTable("Firma");
            modelBuilder.Entity<Kategori>().ToTable("Kategori");
        }
        


}
}
