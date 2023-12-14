using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P04_RelationDB.Migrations
{
    /// <inheritdoc />
    public partial class CategoryToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_TestId",
                table: "Products",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_TestId",
                table: "Products",
                column: "TestId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_TestId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TestId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Products");
        }
    }
}
