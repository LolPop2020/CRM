using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsEmployeeContext1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Employees");
        }
    }
}
