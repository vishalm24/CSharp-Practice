using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practicing_JWT.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Auth",
                table: "Auth");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Auth",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Auth",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auth",
                table: "Auth",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Auth",
                table: "Auth");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Auth");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Auth",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auth",
                table: "Auth",
                column: "Email");
        }
    }
}
