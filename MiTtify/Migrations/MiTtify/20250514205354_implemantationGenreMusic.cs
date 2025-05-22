using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiTtify.Migrations.MiTtify
{
    /// <inheritdoc />
    public partial class implemantationGenreMusic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstGenre",
                table: "Canzone",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondGenre",
                table: "Canzone",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstGenre",
                table: "Canzone");

            migrationBuilder.DropColumn(
                name: "SecondGenre",
                table: "Canzone");
        }
    }
}
