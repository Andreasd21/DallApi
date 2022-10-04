using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DallApi.Migrations
{
    public partial class UpdatedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "DallUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DallUsers",
                table: "DallUsers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DallUsers",
                table: "DallUsers");

            migrationBuilder.RenameTable(
                name: "DallUsers",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
