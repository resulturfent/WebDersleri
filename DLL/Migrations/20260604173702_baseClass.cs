using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DLL.Migrations
{
    /// <inheritdoc />
    public partial class baseClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EklemeTarihi",
                table: "Urunler",
                newName: "EklenmeTarihi");

            migrationBuilder.AddColumn<int>(
                name: "EkleyenId",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kategoriler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EkleyenId",
                table: "Kategoriler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EkleyenId",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "EklenmeTarihi",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "EkleyenId",
                table: "Kategoriler");

            migrationBuilder.RenameColumn(
                name: "EklenmeTarihi",
                table: "Urunler",
                newName: "EklemeTarihi");
        }
    }
}
