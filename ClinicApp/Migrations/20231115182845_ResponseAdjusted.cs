using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class ResponseAdjusted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_DayOffTypes_DayOffTypeId",
                table: "Responses");

            migrationBuilder.AlterColumn<int>(
                name: "DayOffTypeId",
                table: "Responses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_DayOffTypes_DayOffTypeId",
                table: "Responses",
                column: "DayOffTypeId",
                principalTable: "DayOffTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_DayOffTypes_DayOffTypeId",
                table: "Responses");

            migrationBuilder.AlterColumn<int>(
                name: "DayOffTypeId",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_DayOffTypes_DayOffTypeId",
                table: "Responses",
                column: "DayOffTypeId",
                principalTable: "DayOffTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
