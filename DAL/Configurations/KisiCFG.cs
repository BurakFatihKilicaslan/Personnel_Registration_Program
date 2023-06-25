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
    internal class KisiCFG : IEntityTypeConfiguration<Kisi>
    {
        public void Configure(EntityTypeBuilder<Kisi> builder)
        {
            builder.HasKey(k => k.ID);

            builder.Property(k => k.ID)
                   .HasColumnName("KisiID");

            builder.Property(k => k.Ad)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(k => k.Soyad)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(k => k.TcNo)
                   .HasColumnType("varchar")
                   .HasMaxLength(11);

            builder.HasIndex(k => k.TcNo)
                   .IsUnique();

            builder.Property(k => k.DogumTarihi)
                   .HasColumnType("datetime2");

            builder.Property(k => k.Cinsiyet)
                   .HasColumnType("int");

            builder.Property(k => k.Gorev)
                   .HasColumnType("int");

            builder.Property(k => k.KisiTipi)  
                   .HasColumnType("int");

            builder.Property(k => k.AktifMi)
                   .HasColumnType("bit")
                   .HasDefaultValue(false);

            builder.Property(k => k.Sifre)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(64);

            //Relations
            //1-M
            builder.HasMany(k => k.IletisimBilgileri)
                   .WithOne(k => k.Kisi)
                   .OnDelete(DeleteBehavior.Cascade);
            //1-M
            builder.HasOne(k => k.Departman)
                   .WithMany(k => k.Kisiler)
                   .HasForeignKey(k => k.DepartmanID);

            builder.HasData(
                new Kisi 
                {
                    ID = 1,
                    Ad = "Kadikoy",
                    Soyad = "Boost",
                    Sifre = "KD15kadikoy++",
                    TcNo = "01234567890",
                    DogumTarihi = new DateTime(1990, 12, 31),
                    Cinsiyet = Entities.Enums.Cinsiyet.Erkek,
                    Gorev = Entities.Enums.Gorev.Yetkili,
                    KisiTipi = Entities.Enums.KisiTipi.Admin,
                    AktifMi = true,
                    DepartmanID = 1,
                },
                new Kisi
                {
                    ID = 2,
                    Ad = "Burak",
                    Soyad = "Kilicaslan",
                    Sifre = "burakBFK95**",
                    TcNo = "98765432100",
                    DogumTarihi = new DateTime(1995, 4, 2),
                    Cinsiyet = Entities.Enums.Cinsiyet.Erkek,
                    Gorev = Entities.Enums.Gorev.Yetkili,
                    KisiTipi = Entities.Enums.KisiTipi.Calisan,
                    AktifMi = true,
                    DepartmanID = 2,
                },
                new Kisi
                {
                    ID = 3,
                    Ad = "John",
                    Soyad = "Doe",
                    Sifre = "johnDOE2023::",
                    TcNo = "11111111111",
                    DogumTarihi = new DateTime(1990, 2, 28),
                    Cinsiyet = Entities.Enums.Cinsiyet.Kadın,
                    Gorev = Entities.Enums.Gorev.Yetkili,
                    KisiTipi = Entities.Enums.KisiTipi.Calisan,
                    AktifMi = false,
                    DepartmanID = 3,
                },
                new Kisi
                {
                    ID = 4,
                    Ad = "Jane",
                    Soyad = "Doe",
                    Sifre = "janeDOE2000::",
                    TcNo = "22222222222",
                    DogumTarihi = new DateTime(1990, 1, 1),
                    Cinsiyet = Entities.Enums.Cinsiyet.Erkek,
                    Gorev = Entities.Enums.Gorev.Personel,
                    KisiTipi = Entities.Enums.KisiTipi.Calisan,
                    AktifMi = false,
                    DepartmanID = 4,
                });
        }
    }
}
