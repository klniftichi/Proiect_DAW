using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectDAWIftichiCalin.Migrations
{
    /// <inheritdoc />
    public partial class CorectareNumetabelManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelatieUtilizatorJob");

            migrationBuilder.CreateTable(
                name: "Aplicatie",
                columns: table => new
                {
                    UtilizatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aplicatie", x => new { x.UtilizatorId, x.JobId });
                    table.ForeignKey(
                        name: "FK_Aplicatie_Joburi_JobId",
                        column: x => x.JobId,
                        principalTable: "Joburi",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aplicatie_Utilizatori_UtilizatorId",
                        column: x => x.UtilizatorId,
                        principalTable: "Utilizatori",
                        principalColumn: "UtilizatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aplicatie_JobId",
                table: "Aplicatie",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aplicatie");

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
                name: "IX_RelatieUtilizatorJob_JobId",
                table: "RelatieUtilizatorJob",
                column: "JobId");
        }
    }
}
