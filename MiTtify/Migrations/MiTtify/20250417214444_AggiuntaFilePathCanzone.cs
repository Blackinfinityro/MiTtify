using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiTtify.Migrations.MiTtify
{
    /// <inheritdoc />
    public partial class AggiuntaFilePathCanzone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Canzone",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Canzone");
        }
    }
}
