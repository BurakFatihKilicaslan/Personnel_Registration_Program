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
    internal class IletisimBilgisiCFG : IEntityTypeConfiguration<IletisimBilgisi>
    {
        public void Configure(EntityTypeBuilder<IletisimBilgisi> builder)
        {
            builder.HasKey(i => i.ID);

            builder.Property(i => i.ID)
                   .HasColumnName("IletisimBilgisiID");

            builder.Property(i => i.MailAdresi)
                   .HasColumnType("varchar")
                   .HasMaxLength(128);

            builder.HasIndex(i => i.MailAdresi)
                   .IsUnique();

            builder.Property(i => i.TelefonNo)
                   .HasColumnType("varchar")
                   .HasMaxLength(15);

            builder.HasIndex(i => i.TelefonNo)
                   .IsUnique();

            builder.Property(i => i.Adres)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(256);

            //Relations

            builder.HasOne(i => i.Kisi)
                   .WithMany(i => i.IletisimBilgileri)
                   .HasForeignKey(i => i.KisiID);

            builder.HasData(
                new IletisimBilgisi
            {
                    ID = 1,
                    MailAdresi = "boost@bilgeadam.com",
                    TelefonNo = "0216 347 21 21",
                    Adres = "Caferağa, Mühürdar Cd. No:76, 34710 Kadıköy/İstanbul",
                    KisiID = 1
                });
        }
    }
}
