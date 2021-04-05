using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Bağlanma şekli ya login olma yada bu şekilde Trusted_Connection=true
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; } // Database ile ilişkilendirme tablo ve classı ilişkilendirir
        public DbSet<Personel> Personels { get; set; }

        // Farklı isimde class oluşturduğumuz da veritabanı ile aynı olmayabilir. Örnek -> employees - Personel
        // Veritabanı ile ilişki kurabilmesini sağlamak için bu metod çağırılır ve tabloya bağlanır.
        //Buna da Custom mapping denir.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("admin");
            modelBuilder.Entity<Personel>().ToTable("Employees");

            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");

        }
    }
}
