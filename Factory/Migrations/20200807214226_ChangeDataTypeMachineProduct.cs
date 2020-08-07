using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class ChangeDataTypeMachineProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MachineProduct",
                table: "Machines",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MachineProduct",
                table: "Machines",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
