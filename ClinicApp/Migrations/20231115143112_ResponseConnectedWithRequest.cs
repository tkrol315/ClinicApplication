using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class ResponseConnectedWithRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Users_UserId",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_UserId",
                table: "Responses");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Responses",
                newName: "RequestId");

            migrationBuilder.AddColumn<int>(
                name: "RequestState",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Responses_RequestId",
                table: "Responses",
                column: "RequestId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Requests_RequestId",
                table: "Responses",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Requests_RequestId",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_RequestId",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "RequestState",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "RequestId",
                table: "Responses",
                newName: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_UserId",
                table: "Responses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Users_UserId",
                table: "Responses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
