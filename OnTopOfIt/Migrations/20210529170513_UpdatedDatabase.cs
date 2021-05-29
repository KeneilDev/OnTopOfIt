using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTopOfIt.Migrations
{
    public partial class UpdatedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "OnTopOfItUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "OnTopOfItUser",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "OnTopOfItUser");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "OnTopOfItUser");
        }
    }
}
