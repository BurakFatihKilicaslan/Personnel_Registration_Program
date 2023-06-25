using DAL.Configurations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class PersonelDb : DbContext
    {
        public DbSet<Kisi>Kisiler { get; set; }
        public DbSet<IletisimBilgisi>IletisimBilgileri { get; set; }
        public DbSet<Departman>Departmanlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PersonelDbContext;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new KisiCFG());
            modelBuilder.ApplyConfiguration(new IletisimBilgisiCFG());
            modelBuilder.ApplyConfiguration(new DepartmanCFG());
        }
    }
}
