using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocatorBackEnd.Migrations
{
    public partial class Loc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MotelName",
                table: "Location",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Location",
                newName: "MotelName");
        }
    }
}
