using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFirsDbContext dc = new CodeFirsDbContext();
            dc.Database.Delete();
             dc.Database.Create();
            Kisiler k = new Kisiler();
            k.Adi = "Deniz";
            k.Soyadi = "Tanrıverdi";
            k.Cinsiyet = 1;
            k.DogumTarihi = DateTime.UtcNow;
            k.Email = "dnztanverdi@gmail.com";
            k.TcKimlik = "3856946346";
            k.Telefon = "465344636";
         
            dc.Kisiler.Add(k);
            dc.SaveChanges();

            Console.ReadLine();
        }
    }
}
