using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectDAWIftichiCalin.Migrations
{
    /// <inheritdoc />
    public partial class removecoloane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Utilizatori");

            migrationBuilder.DropColumn(
                name: "ParolaHash",
                table: "Utilizatori");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Utilizatori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParolaHash",
                table: "Utilizatori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
