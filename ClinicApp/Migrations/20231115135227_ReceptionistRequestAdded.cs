using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class ReceptionistRequestAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceptionistRequestId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReceptionistRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionistRequests", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ReceptionistRequestId",
                table: "Requests",
                column: "ReceptionistRequestId",
                unique: true,
                filter: "[ReceptionistRequestId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_ReceptionistRequests_ReceptionistRequestId",
                table: "Requests",
                column: "ReceptionistRequestId",
                principalTable: "ReceptionistRequests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_ReceptionistRequests_ReceptionistRequestId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "ReceptionistRequests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_ReceptionistRequestId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "ReceptionistRequestId",
                table: "Requests");
        }
    }
}
