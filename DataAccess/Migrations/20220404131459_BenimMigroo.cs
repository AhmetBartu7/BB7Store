using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class BenimMigroo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Role = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Disctrict = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FullAddress = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TempBaskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CookiesId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempBaskets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    CargoNumber = table.Column<long>(type: "bigint", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false),
                    OrderTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CargoPrice = table.Column<decimal>(type: "money", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "money", nullable: false),
                    DicountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    OrderType = table.Column<byte>(type: "tinyint", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "money", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagesName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsImages_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressType = table.Column<byte>(type: "tinyint", nullable: false),
                    City = table.Column<byte>(type: "tinyint", maxLength: 50, nullable: false),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FullAddress = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersAddress_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrdersId",
                table: "OrderDetails",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomersId",
                table: "Orders",
                column: "CustomersId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdersAddress_OrdersId",
                table: "OrdersAddress",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesId",
                table: "Products",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsImages_ProductsId",
                table: "ProductsImages",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrdersAddress");

            migrationBuilder.DropTable(
                name: "ProductsImages");

            migrationBuilder.DropTable(
                name: "TempBaskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
