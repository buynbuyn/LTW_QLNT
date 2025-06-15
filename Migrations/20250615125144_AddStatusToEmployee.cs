using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNT.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                column: "Status",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employees");
        }
    }
}
