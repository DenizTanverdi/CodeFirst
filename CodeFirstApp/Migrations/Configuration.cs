namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstApp.CodeFirsDbContext>
    {
        public Configuration()
        {
            //1-- Enable Migration 2-- Update Database

            // false true yaptýk güncelleme yapabilmemiz için 
            AutomaticMigrationsEnabled = true;
            ContextKey = "CodeFirstApp.CodeFirsDbContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CodeFirstApp.CodeFirsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
