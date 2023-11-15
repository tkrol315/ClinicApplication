using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class ReceptionistRequestRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Requests");

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
    }
}
