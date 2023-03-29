using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DL.Migrations
{
    /// <inheritdoc />
    public partial class addReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_products_ProductId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "review");

            migrationBuilder.RenameIndex(
                name: "IX_Review_ProductId",
                table: "review",
                newName: "IX_review_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_review",
                table: "review",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_review_products_ProductId",
                table: "review",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_review_products_ProductId",
                table: "review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_review",
                table: "review");

            migrationBuilder.RenameTable(
                name: "review",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_review_ProductId",
                table: "Review",
                newName: "IX_Review_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_products_ProductId",
                table: "Review",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
