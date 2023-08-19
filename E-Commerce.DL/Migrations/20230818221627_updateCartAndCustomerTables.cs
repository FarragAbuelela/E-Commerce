using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DL.Migrations
{
    /// <inheritdoc />
    public partial class updateCartAndCustomerTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_Carts_CartId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_CartId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_CartId",
                table: "products",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Carts_CartId",
                table: "products",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Carts_CartId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CartId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_orders_CartId",
                table: "orders",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Carts_CartId",
                table: "orders",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");
        }
    }
}
