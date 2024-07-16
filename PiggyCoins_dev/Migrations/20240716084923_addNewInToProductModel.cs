using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiggyCoins_dev.Migrations
{
    /// <inheritdoc />
    public partial class addNewInToProductModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NewIn",
                table: "Products",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewIn",
                table: "Products");
        }
    }
}
