using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.DL.Migrations
{
    /// <inheritdoc />
    public partial class addApprovedInOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "orders");
        }
    }
}
