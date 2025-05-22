using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiTtify.Migrations.MiTtify
{
    /// <inheritdoc />
    public partial class immagineCanzone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Canzone",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Canzone");
        }
    }
}
