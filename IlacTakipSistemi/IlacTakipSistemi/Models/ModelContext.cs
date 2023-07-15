using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlacTakipSistemi.Models
{
    public class ModelContext: DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Ilac> Ilaclar { get; set; }

        public DbSet<IlacTakip> IlacTakip { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = IlacTakipDB; Integrated Security = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kullanici>().ToTable("tblKullanici");
            modelBuilder.Entity<Ilac>().ToTable("tblIlac");
            modelBuilder.Entity<IlacTakip>().ToTable("tblIlacTakip");
            modelBuilder.Entity<Kullanici>().HasIndex(k => k.kullaniciID).IsUnique();
            modelBuilder.Entity<Ilac>().HasIndex(i => i.ilacID).IsUnique();
            modelBuilder.Entity<IlacTakip>().HasIndex(it => it.ilacTakipID).IsUnique();
        }
    }
}
