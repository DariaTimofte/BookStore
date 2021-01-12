using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreApp.Migrations
{
    public partial class RelationsMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients",
                column: "FidelityBonusId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients",
                column: "FidelityBonusId");
        }
    }
}
