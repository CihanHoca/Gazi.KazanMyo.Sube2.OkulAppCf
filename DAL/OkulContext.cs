using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OkulContext:DbContext
    {
        public OkulContext():base("cstr")
        {

        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");

            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).IsRequired().HasMaxLength(85).HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Numara).IsRequired().HasMaxLength(15).HasColumnType("varchar");

            modelBuilder.Entity<Sinif>().ToTable("tblSiniflar");
            modelBuilder.Entity<Sinif>().Property(s => s.SinifAd).IsRequired().HasMaxLength(10).HasColumnType("varchar");
        }
    }
}//Migrations
// Fluent Api
