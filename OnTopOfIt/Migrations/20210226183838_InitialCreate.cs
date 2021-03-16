using Microsoft.EntityFrameworkCore.Migrations;

namespace OnTopOfIt.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    icon = table.Column<string>(nullable: false),
                    colour = table.Column<string>(nullable: false),
                    repeatMonday = table.Column<bool>(nullable: false),
                    repeatTuesday = table.Column<bool>(nullable: false),
                    repeatWednesday = table.Column<bool>(nullable: false),
                    repeatThursday = table.Column<bool>(nullable: false),
                    repeatFriday = table.Column<bool>(nullable: false),
                    repeatSaturday = table.Column<bool>(nullable: false),
                    repeatSunday = table.Column<bool>(nullable: false),
                    timeofDay = table.Column<string>(nullable: false),
                    taskComplete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems");
        }
    }
}
