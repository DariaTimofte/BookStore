using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreApp.Migrations
{
    public partial class RelationsMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_FidelityBonus_BonusId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_BonusId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "BonusId",
                table: "Clients");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FidelityBonusId",
                table: "Clients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_FidelityBonusId",
                table: "Clients",
                column: "FidelityBonusId");

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

            migrationBuilder.DropColumn(
                name: "FidelityBonusId",
                table: "Clients");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BonusId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BonusId",
                table: "Clients",
                column: "BonusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_FidelityBonus_BonusId",
                table: "Clients",
                column: "BonusId",
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
    }
}
