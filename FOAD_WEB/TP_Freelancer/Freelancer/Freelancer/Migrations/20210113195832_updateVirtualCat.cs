using Microsoft.EntityFrameworkCore.Migrations;

namespace Freelancer.Migrations
{
    public partial class updateVirtualCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Clients_CategorieClientId",
                table: "Clients",
                column: "CategorieClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_CategoriesClient_CategorieClientId",
                table: "Clients",
                column: "CategorieClientId",
                principalTable: "CategoriesClient",
                principalColumn: "categorie_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_CategoriesClient_CategorieClientId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CategorieClientId",
                table: "Clients");
        }
    }
}
