using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class BuyerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buyer_Buyer_BuyerId",
                table: "Buyer");

            migrationBuilder.DropIndex(
                name: "IX_Buyer_BuyerId",
                table: "Buyer");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Buyer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyerId",
                table: "Buyer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buyer_BuyerId",
                table: "Buyer",
                column: "BuyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buyer_Buyer_BuyerId",
                table: "Buyer",
                column: "BuyerId",
                principalTable: "Buyer",
                principalColumn: "Id");
        }
    }
}
