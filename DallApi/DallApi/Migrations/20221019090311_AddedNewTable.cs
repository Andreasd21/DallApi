using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DallApi.Migrations
{
    public partial class AddedNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfHandling",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Requests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfRequest",
                table: "Requests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Paintings",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Paintings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Paintings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserPaintings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaintingId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Bought = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPaintings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPaintings_DallUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DallUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPaintings_Paintings_PaintingId",
                        column: x => x.PaintingId,
                        principalTable: "Paintings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaintings_PaintingId",
                table: "UserPaintings",
                column: "PaintingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaintings_UserId",
                table: "UserPaintings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_DallUsers_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "DallUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_DallUsers_UserId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "UserPaintings");

            migrationBuilder.DropIndex(
                name: "IX_Requests_UserId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Paintings");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfRequest",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "DateOfHandling",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfCreation",
                table: "Paintings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
