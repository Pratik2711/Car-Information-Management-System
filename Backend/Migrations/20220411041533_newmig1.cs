using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class newmig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManufracturerId",
                table: "cars",
                newName: "ManufacturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "cars",
                newName: "ManufracturerId");
        }
    }
}
