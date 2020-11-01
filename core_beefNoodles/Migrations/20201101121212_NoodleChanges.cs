using Microsoft.EntityFrameworkCore.Migrations;

namespace core_beefNoodles.Migrations
{
    public partial class NoodleChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInstock",
                table: "Noodles",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInstock",
                table: "Noodles");
        }
    }
}
