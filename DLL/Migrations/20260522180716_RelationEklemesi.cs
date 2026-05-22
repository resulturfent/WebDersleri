using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DLL.Migrations
{
    /// <inheritdoc />
    public partial class RelationEklemesi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategorilerId",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategorilerId",
                table: "Urunler",
                column: "KategorilerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Kategoriler_KategorilerId",
                table: "Urunler",
                column: "KategorilerId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Kategoriler_KategorilerId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_KategorilerId",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "KategorilerId",
                table: "Urunler");
        }
    }
}
