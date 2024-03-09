using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apoteka.Repozitorijumi.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bolest",
                table: "Lek",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kolicina",
                table: "Lek",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bolest",
                table: "Lek");

            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "Lek");
        }
    }
}
