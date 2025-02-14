using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API__Employee_Management_.Migrations
{
    /// <inheritdoc />
    public partial class AddDesignation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "EmployeeReg",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Designation",
                table: "EmployeeReg");
        }
    }
}
