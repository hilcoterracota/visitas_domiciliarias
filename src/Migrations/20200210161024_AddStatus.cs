using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sivido.Migrations
{
    public partial class AddStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdStatus",
                table: "T_VISITA",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CAT_STATUS",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Clave = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAT_STATUS", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_VISITA_IdStatus",
                table: "T_VISITA",
                column: "IdStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_T_VISITA_CAT_STATUS_IdStatus",
                table: "T_VISITA",
                column: "IdStatus",
                principalTable: "CAT_STATUS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_VISITA_CAT_STATUS_IdStatus",
                table: "T_VISITA");

            migrationBuilder.DropTable(
                name: "CAT_STATUS");

            migrationBuilder.DropIndex(
                name: "IX_T_VISITA_IdStatus",
                table: "T_VISITA");

            migrationBuilder.DropColumn(
                name: "IdStatus",
                table: "T_VISITA");
        }
    }
}
