using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class DepartmanCFG : IEntityTypeConfiguration<Departman>
    {
        public void Configure(EntityTypeBuilder<Departman> builder)
        {
            builder.HasKey(d => d.ID);

            builder.Property(d => d.ID)
                   .HasColumnName("DepartmanID");

            builder.Property(d => d.DepartmanAdi)
                   .HasColumnType("varchar")
                   .HasMaxLength(30);

            //Relations
            //1-M
            builder.HasMany(d => d.Kisiler)
                   .WithOne(d => d.Departman);

            builder.HasData(
                new Departman{ID = 1, DepartmanAdi = "İnsan Kaynakları"},
                new Departman{ID = 2, DepartmanAdi = "Muhasebe"},
                new Departman{ID = 3, DepartmanAdi = "Elektronik Ar-Ge"},
                new Departman{ID = 4, DepartmanAdi = "Yazılım Ar-Ge"},
                new Departman{ID = 5, DepartmanAdi = "Ulaştırma"}
                );
        }
    }
}
