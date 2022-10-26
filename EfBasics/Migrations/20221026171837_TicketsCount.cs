using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfBasics.Migrations
{
    public partial class TicketsCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketsCount",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketsCount",
                table: "Events");
        }
    }
}
