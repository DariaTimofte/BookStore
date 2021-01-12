using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreApp.Migrations
{
    public partial class RelationsMigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_FidelityBonus_FidelityBonusId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FidelityBonusId",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients",
                column: "FidelityBonusId",
                unique: true,
                filter: "[FidelityBonusId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_FidelityBonus_FidelityBonusId",
                table: "Clients",
                column: "FidelityBonusId",
                principalTable: "FidelityBonus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_FidelityBonus_FidelityBonusId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Clients",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FidelityBonusId",
                table: "Clients",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients",
                column: "FidelityBonusId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_FidelityBonus_FidelityBonusId",
                table: "Clients",
                column: "FidelityBonusId",
                principalTable: "FidelityBonus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
