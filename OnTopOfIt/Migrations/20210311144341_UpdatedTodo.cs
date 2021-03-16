using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTopOfIt.Migrations
{
    public partial class UpdatedTodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OnTopOfItUserId",
                table: "TodoItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "completeBy",
                table: "TodoItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "OnTopOfItUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnTopOfItUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_OnTopOfItUserId",
                table: "TodoItems",
                column: "OnTopOfItUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_OnTopOfItUser_OnTopOfItUserId",
                table: "TodoItems",
                column: "OnTopOfItUserId",
                principalTable: "OnTopOfItUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_OnTopOfItUser_OnTopOfItUserId",
                table: "TodoItems");

            migrationBuilder.DropTable(
                name: "OnTopOfItUser");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_OnTopOfItUserId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "OnTopOfItUserId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "completeBy",
                table: "TodoItems");
        }
    }
}
