using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DallApi.Migrations
{
    public partial class addedDallFoergeinkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DallUserId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DallUserId",
                table: "Requests");
        }
    }
}
