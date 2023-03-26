using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DL.Migrations
{
    /// <inheritdoc />
    public partial class updateProductsAddReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgeRange",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BabyAndKidsProduct_Material",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeautyProduct_Brand",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModelNumber",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkinType",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SportsAndOutdoorsProduct_Brand",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SportsAndOutdoorsProduct_Color",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SportsAndOutdoorsProduct_Size",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VolumeInMilliliters",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarrantyMonths",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductId",
                table: "Review",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropColumn(
                name: "AgeRange",
                table: "products");

            migrationBuilder.DropColumn(
                name: "BabyAndKidsProduct_Material",
                table: "products");

            migrationBuilder.DropColumn(
                name: "BeautyProduct_Brand",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ModelNumber",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "products");

            migrationBuilder.DropColumn(
                name: "SkinType",
                table: "products");

            migrationBuilder.DropColumn(
                name: "SportsAndOutdoorsProduct_Brand",
                table: "products");

            migrationBuilder.DropColumn(
                name: "SportsAndOutdoorsProduct_Color",
                table: "products");

            migrationBuilder.DropColumn(
                name: "SportsAndOutdoorsProduct_Size",
                table: "products");

            migrationBuilder.DropColumn(
                name: "VolumeInMilliliters",
                table: "products");

            migrationBuilder.DropColumn(
                name: "WarrantyMonths",
                table: "products");
        }
    }
}
