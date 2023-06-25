﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(PersonelDb))]
    [Migration("20230604150649_Versiyon1")]
    partial class Versiyon1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Departman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DepartmanID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmanAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Departmanlar");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanAdi = "İnsan Kaynakları"
                        },
                        new
                        {
                            ID = 2,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanAdi = "Muhasebe"
                        },
                        new
                        {
                            ID = 3,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanAdi = "Elektronik Ar-Ge"
                        },
                        new
                        {
                            ID = 4,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanAdi = "Yazılım Ar-Ge"
                        },
                        new
                        {
                            ID = 5,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanAdi = "Ulaştırma"
                        });
                });

            modelBuilder.Entity("Entities.Models.IletisimBilgisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IletisimBilgisiID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KisiID")
                        .HasColumnType("int");

                    b.Property<string>("MailAdresi")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("ID");

                    b.HasIndex("KisiID");

                    b.HasIndex("MailAdresi")
                        .IsUnique();

                    b.HasIndex("TelefonNo")
                        .IsUnique();

                    b.ToTable("IletisimBilgileri");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Adres = "Caferağa, Mühürdar Cd. No:76, 34710 Kadıköy/İstanbul",
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KisiID = 1,
                            MailAdresi = "boost@bilgeadam.com",
                            TelefonNo = "0216 347 21 21"
                        });
                });

            modelBuilder.Entity("Entities.Models.Kisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KisiID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("AktifMi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmanID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gorev")
                        .HasColumnType("int");

                    b.Property<int>("KisiTipi")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmanID");

                    b.HasIndex("TcNo")
                        .IsUnique();

                    b.ToTable("Kisiler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Ad = "Kadikoy",
                            AktifMi = true,
                            Cinsiyet = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanID = 1,
                            DogumTarihi = new DateTime(1990, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gorev = 1,
                            KisiTipi = 1,
                            Sifre = "KD15kadikoy++",
                            Soyad = "Boost",
                            TcNo = "01234567890"
                        },
                        new
                        {
                            ID = 2,
                            Ad = "Burak",
                            AktifMi = true,
                            Cinsiyet = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanID = 2,
                            DogumTarihi = new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gorev = 1,
                            KisiTipi = 2,
                            Sifre = "burakBFK95**",
                            Soyad = "Kilicaslan",
                            TcNo = "98765432100"
                        },
                        new
                        {
                            ID = 3,
                            Ad = "Jane",
                            AktifMi = false,
                            Cinsiyet = 2,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanID = 3,
                            DogumTarihi = new DateTime(1990, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gorev = 1,
                            KisiTipi = 2,
                            Sifre = "johnDOE2023::",
                            Soyad = "Doe",
                            TcNo = "11111111111"
                        },
                        new
                        {
                            ID = 4,
                            Ad = "John",
                            AktifMi = false,
                            Cinsiyet = 1,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmanID = 4,
                            DogumTarihi = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gorev = 2,
                            KisiTipi = 2,
                            Sifre = "janeDOE2000::",
                            Soyad = "Doe",
                            TcNo = "22222222222"
                        });
                });

            modelBuilder.Entity("Entities.Models.IletisimBilgisi", b =>
                {
                    b.HasOne("Entities.Models.Kisi", "Kisi")
                        .WithMany("IletisimBilgileri")
                        .HasForeignKey("KisiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kisi");
                });

            modelBuilder.Entity("Entities.Models.Kisi", b =>
                {
                    b.HasOne("Entities.Models.Departman", "Departman")
                        .WithMany("Kisiler")
                        .HasForeignKey("DepartmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("Entities.Models.Departman", b =>
                {
                    b.Navigation("Kisiler");
                });

            modelBuilder.Entity("Entities.Models.Kisi", b =>
                {
                    b.Navigation("IletisimBilgileri");
                });
#pragma warning restore 612, 618
        }
    }
}
