using Microsoft.EntityFrameworkCore.Migrations;

namespace Freelancer.Migrations
{
    public partial class updateVirtualMissionOnDevis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Devis_MissionId",
                table: "Devis",
                column: "MissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Missions_MissionId",
                table: "Devis",
                column: "MissionId",
                principalTable: "Missions",
                principalColumn: "mission_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Missions_MissionId",
                table: "Devis");

            migrationBuilder.DropIndex(
                name: "IX_Devis_MissionId",
                table: "Devis");
        }
    }
}
