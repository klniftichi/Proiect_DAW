using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectDAWIftichiCalin.Migrations
{
    /// <inheritdoc />
    public partial class AdaugareTabeleadaugareConstrangeri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Utilizatori",
                newName: "UtilizatorId");

            migrationBuilder.CreateTable(
                name: "Sedii",
                columns: table => new
                {
                    SediuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedii", x => x.SediuId);
                });

            migrationBuilder.CreateTable(
                name: "Companii",
                columns: table => new
                {
                    CompanieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numecompanie = table.Column<string>(name: "Nume_companie", type: "nvarchar(max)", nullable: false),
                    Descrierecompanie = table.Column<string>(name: "Descriere_companie", type: "nvarchar(max)", nullable: false),
                    SediuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParolaHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companii", x => x.CompanieId);
                    table.ForeignKey(
                        name: "FK_Companii_Sedii_SediuId",
                        column: x => x.SediuId,
                        principalTable: "Sedii",
                        principalColumn: "SediuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Joburi",
                columns: table => new
                {
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeJob = table.Column<string>(name: "Nume_Job", type: "nvarchar(max)", nullable: false),
                    Categoriejob = table.Column<string>(name: "Categorie_job", type: "nvarchar(max)", nullable: false),
                    Criterii = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrierejob = table.Column<string>(name: "Descriere_job", type: "nvarchar(max)", nullable: false),
                    CompanieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joburi", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Joburi_Companii_CompanieId",
                        column: x => x.CompanieId,
                        principalTable: "Companii",
                        principalColumn: "CompanieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatieUtilizatorJob",
                columns: table => new
                {
                    UtilizatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatieUtilizatorJob", x => new { x.UtilizatorId, x.JobId });
                    table.ForeignKey(
                        name: "FK_RelatieUtilizatorJob_Joburi_JobId",
                        column: x => x.JobId,
                        principalTable: "Joburi",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatieUtilizatorJob_Utilizatori_UtilizatorId",
                        column: x => x.UtilizatorId,
                        principalTable: "Utilizatori",
                        principalColumn: "UtilizatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companii_SediuId",
                table: "Companii",
                column: "SediuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Joburi_CompanieId",
                table: "Joburi",
                column: "CompanieId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatieUtilizatorJob_JobId",
                table: "RelatieUtilizatorJob",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelatieUtilizatorJob");

            migrationBuilder.DropTable(
                name: "Joburi");

            migrationBuilder.DropTable(
                name: "Companii");

            migrationBuilder.DropTable(
                name: "Sedii");

            migrationBuilder.RenameColumn(
                name: "UtilizatorId",
                table: "Utilizatori",
                newName: "Id");
        }
    }
}
