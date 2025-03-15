using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPrac.Migrations
{
    /// <inheritdoc />
    public partial class spGetCustomerByPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROC spGetCustomerByPage
                                "
            migrationBuilder.CreateTable(
                name: "tblAncillary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AncillaryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AncillaryCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblAncil__3214EC07A519FA4B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCountry",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblCount__10D1609F1CC01FF9", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "tblCustomer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CustomerCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerPhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CustomerSSN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CustomerReferenceId_fk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblCusto__A4AE64D856F1D5D9", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "tblGenuineCustomer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblProdu__B40CC6CDB144643D", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "tblProductBackup",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductCost = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblProdu__B40CC6CD23294279", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "tblArea",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CountryId_fk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblArea__70B82048BA7BB70C", x => x.AreaId);
                    table.ForeignKey(
                        name: "FK__tblArea__Country__398D8EEE",
                        column: x => x.CountryId_fk,
                        principalTable: "tblCountry",
                        principalColumn: "CountryId");
                });

            migrationBuilder.CreateTable(
                name: "tblModel",
                columns: table => new
                {
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModelBrand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ManufacturerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CountryId_fk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblModel__E8D7A12C8DC53E6B", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK__tblModel__Countr__3E52440B",
                        column: x => x.CountryId_fk,
                        principalTable: "tblCountry",
                        principalColumn: "CountryId");
                });

            migrationBuilder.CreateTable(
                name: "tblAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblAddre__091C2AFBDB2B92EE", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK__tblAddres__Custo__48CFD27E",
                        column: x => x.CustomerId,
                        principalTable: "tblCustomer",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "tblProductCustomer",
                columns: table => new
                {
                    ProductCustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerId_fk = table.Column<int>(type: "int", nullable: true),
                    ProductId_fk = table.Column<int>(type: "int", nullable: true),
                    ModelId_fk = table.Column<int>(type: "int", nullable: true),
                    AncillaryId_fk = table.Column<int>(type: "int", nullable: true),
                    SalesDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblProdu__5D863CB9AD20AB41", x => x.ProductCustomerId);
                    table.ForeignKey(
                        name: "FK__tblProduc__Ancil__4E88ABD4",
                        column: x => x.AncillaryId_fk,
                        principalTable: "tblAncillary",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__tblProduc__Custo__4BAC3F29",
                        column: x => x.CustomerId_fk,
                        principalTable: "tblCustomer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK__tblProduc__Model__4D94879B",
                        column: x => x.ModelId_fk,
                        principalTable: "tblModel",
                        principalColumn: "ModelId");
                    table.ForeignKey(
                        name: "FK__tblProduc__Prouc__4CA06362",
                        column: x => x.ProductId_fk,
                        principalTable: "tblProduct",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAddress_CustomerId",
                table: "tblAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblArea_CountryId_fk",
                table: "tblArea",
                column: "CountryId_fk");

            migrationBuilder.CreateIndex(
                name: "IX_tblModel_CountryId_fk",
                table: "tblModel",
                column: "CountryId_fk");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductCustomer_AncillaryId_fk",
                table: "tblProductCustomer",
                column: "AncillaryId_fk");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductCustomer_CustomerId_fk",
                table: "tblProductCustomer",
                column: "CustomerId_fk");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductCustomer_ModelId_fk",
                table: "tblProductCustomer",
                column: "ModelId_fk");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductCustomer_ProductId_fk",
                table: "tblProductCustomer",
                column: "ProductId_fk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAddress");

            migrationBuilder.DropTable(
                name: "tblArea");

            migrationBuilder.DropTable(
                name: "tblGenuineCustomer");

            migrationBuilder.DropTable(
                name: "tblProductBackup");

            migrationBuilder.DropTable(
                name: "tblProductCustomer");

            migrationBuilder.DropTable(
                name: "tblAncillary");

            migrationBuilder.DropTable(
                name: "tblCustomer");

            migrationBuilder.DropTable(
                name: "tblModel");

            migrationBuilder.DropTable(
                name: "tblProduct");

            migrationBuilder.DropTable(
                name: "tblCountry");
        }
    }
}
