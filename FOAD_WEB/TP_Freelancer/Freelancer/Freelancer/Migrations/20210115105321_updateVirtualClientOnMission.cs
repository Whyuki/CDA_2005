using Microsoft.EntityFrameworkCore.Migrations;

namespace Freelancer.Migrations
{
    public partial class updateVirtualClientOnMission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Missions_ClientId",
                table: "Missions",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Clients_ClientId",
                table: "Missions",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "client_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Clients_ClientId",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_ClientId",
                table: "Missions");
        }
    }
}
