using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectDAWIftichiCalin.Migrations
{
    /// <inheritdoc />
    public partial class actualizaredatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Utilizatori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Utilizatori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Roluri",
                table: "Utilizatori",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Utilizatori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Roluri",
                table: "Companii",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Utilizatori");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Utilizatori");

            migrationBuilder.DropColumn(
                name: "Roluri",
                table: "Utilizatori");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Utilizatori");

            migrationBuilder.DropColumn(
                name: "Roluri",
                table: "Companii");
        }
    }
}
