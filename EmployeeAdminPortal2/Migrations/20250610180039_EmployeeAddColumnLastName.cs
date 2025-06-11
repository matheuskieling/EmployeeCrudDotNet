using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAdminPortal2.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeAddColumnLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");
        }
    }
}
