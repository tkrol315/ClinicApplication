using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class TimeOfDayAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "Schedules",
                newName: "Date");

            migrationBuilder.AddColumn<int>(
                name: "TimeOfDay",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeOfDay",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Schedules",
                newName: "To");

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
