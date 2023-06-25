using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Versiyon1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.DepartmanID);
                });

            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    KisiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TcNo = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    Gorev = table.Column<int>(type: "int", nullable: false),
                    KisiTipi = table.Column<int>(type: "int", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Sifre = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DepartmanID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.KisiID);
                    table.ForeignKey(
                        name: "FK_Kisiler_Departmanlar_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "Departmanlar",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IletisimBilgileri",
                columns: table => new
                {
                    IletisimBilgisiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailAdresi = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    TelefonNo = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    KisiID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimBilgileri", x => x.IletisimBilgisiID);
                    table.ForeignKey(
                        name: "FK_IletisimBilgileri_Kisiler_KisiID",
                        column: x => x.KisiID,
                        principalTable: "Kisiler",
                        principalColumn: "KisiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departmanlar",
                columns: new[] { "DepartmanID", "CreationDate", "DepartmanAdi" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İnsan Kaynakları" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhasebe" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektronik Ar-Ge" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazılım Ar-Ge" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulaştırma" }
                });

            migrationBuilder.InsertData(
                table: "Kisiler",
                columns: new[] { "KisiID", "Ad", "AktifMi", "Cinsiyet", "CreationDate", "DepartmanID", "DogumTarihi", "Gorev", "KisiTipi", "Sifre", "Soyad", "TcNo" },
                values: new object[,]
                {
                    { 1, "Kadikoy", true, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1990, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "KD15kadikoy++", "Boost", "01234567890" },
                    { 2, "Burak", true, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "burakBFK95**", "Kilicaslan", "98765432100" }
                });

            migrationBuilder.InsertData(
                table: "Kisiler",
                columns: new[] { "KisiID", "Ad", "Cinsiyet", "CreationDate", "DepartmanID", "DogumTarihi", "Gorev", "KisiTipi", "Sifre", "Soyad", "TcNo" },
                values: new object[,]
                {
                    { 3, "Jane", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1990, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "johnDOE2023::", "Doe", "11111111111" },
                    { 4, "John", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "janeDOE2000::", "Doe", "22222222222" }
                });

            migrationBuilder.InsertData(
                table: "IletisimBilgileri",
                columns: new[] { "IletisimBilgisiID", "Adres", "CreationDate", "KisiID", "MailAdresi", "TelefonNo" },
                values: new object[] { 1, "Caferağa, Mühürdar Cd. No:76, 34710 Kadıköy/İstanbul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "boost@bilgeadam.com", "0216 347 21 21" });

            migrationBuilder.CreateIndex(
                name: "IX_IletisimBilgileri_KisiID",
                table: "IletisimBilgileri",
                column: "KisiID");

            migrationBuilder.CreateIndex(
                name: "IX_IletisimBilgileri_MailAdresi",
                table: "IletisimBilgileri",
                column: "MailAdresi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IletisimBilgileri_TelefonNo",
                table: "IletisimBilgileri",
                column: "TelefonNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kisiler_DepartmanID",
                table: "Kisiler",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Kisiler_TcNo",
                table: "Kisiler",
                column: "TcNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IletisimBilgileri");

            migrationBuilder.DropTable(
                name: "Kisiler");

            migrationBuilder.DropTable(
                name: "Departmanlar");
        }
    }
}
