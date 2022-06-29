using Microsoft.EntityFrameworkCore.Migrations;

namespace Miplazoleta.RepositorioEFcore.Migrations
{
    public partial class ChangeApiFluid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlatosMenus_Menus_MenuId",
                table: "PlatosMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_PlatosMenus_Platos_PlatoId",
                table: "PlatosMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlatosMenus",
                table: "PlatosMenus");

            migrationBuilder.DropIndex(
                name: "IX_PlatosMenus_MenuId",
                table: "PlatosMenus");

            migrationBuilder.RenameTable(
                name: "PlatosMenus",
                newName: "PlatoMenu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlatoMenu",
                table: "PlatoMenu",
                columns: new[] { "MenuId", "PlatoId" });

            migrationBuilder.CreateIndex(
                name: "IX_PlatoMenu_PlatoId",
                table: "PlatoMenu",
                column: "PlatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlatoMenu_Menus_MenuId",
                table: "PlatoMenu",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlatoMenu_Platos_PlatoId",
                table: "PlatoMenu",
                column: "PlatoId",
                principalTable: "Platos",
                principalColumn: "IdPlato",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlatoMenu_Menus_MenuId",
                table: "PlatoMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_PlatoMenu_Platos_PlatoId",
                table: "PlatoMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlatoMenu",
                table: "PlatoMenu");

            migrationBuilder.DropIndex(
                name: "IX_PlatoMenu_PlatoId",
                table: "PlatoMenu");

            migrationBuilder.RenameTable(
                name: "PlatoMenu",
                newName: "PlatosMenus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlatosMenus",
                table: "PlatosMenus",
                columns: new[] { "PlatoId", "MenuId" });

            migrationBuilder.CreateIndex(
                name: "IX_PlatosMenus_MenuId",
                table: "PlatosMenus",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlatosMenus_Menus_MenuId",
                table: "PlatosMenus",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "IdMenu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlatosMenus_Platos_PlatoId",
                table: "PlatosMenus",
                column: "PlatoId",
                principalTable: "Platos",
                principalColumn: "IdPlato",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
