using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class requestStateAsEntityInsteadOfEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestState",
                table: "Requests",
                newName: "RequestStateId");

            migrationBuilder.CreateTable(
                name: "RequestStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStates", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestStateId",
                table: "Requests",
                column: "RequestStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_RequestStates_RequestStateId",
                table: "Requests",
                column: "RequestStateId",
                principalTable: "RequestStates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_RequestStates_RequestStateId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "RequestStates");

            migrationBuilder.DropIndex(
                name: "IX_Requests_RequestStateId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "RequestStateId",
                table: "Requests",
                newName: "RequestState");
        }
    }
}
