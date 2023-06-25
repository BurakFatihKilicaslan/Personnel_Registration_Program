using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Versiyon2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 3,
                column: "Ad",
                value: "John");

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 4,
                column: "Ad",
                value: "Jane");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 3,
                column: "Ad",
                value: "Jane");

            migrationBuilder.UpdateData(
                table: "Kisiler",
                keyColumn: "KisiID",
                keyValue: 4,
                column: "Ad",
                value: "John");
        }
    }
}
