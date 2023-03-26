using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DL.Migrations
{
    /// <inheritdoc />
    public partial class updateOrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_orderItems_OrderItemId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_OrderItemId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "orderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_ProductId",
                table: "orderItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_products_ProductId",
                table: "orderItems",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_products_ProductId",
                table: "orderItems");

            migrationBuilder.DropIndex(
                name: "IX_orderItems_ProductId",
                table: "orderItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "orderItems");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_OrderItemId",
                table: "products",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_orderItems_OrderItemId",
                table: "products",
                column: "OrderItemId",
                principalTable: "orderItems",
                principalColumn: "Id");
        }
    }
}
