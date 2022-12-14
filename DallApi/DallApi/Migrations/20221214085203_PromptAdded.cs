using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DallApi.Migrations
{
    public partial class PromptAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_DallUsers_UserId",
                table: "Requests");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Prompt",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_DallUsers_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "DallUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_DallUsers_UserId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Prompt",
                table: "Requests");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_DallUsers_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "DallUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
