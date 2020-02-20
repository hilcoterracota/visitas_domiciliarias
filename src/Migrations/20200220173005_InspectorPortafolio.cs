using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sivido.Migrations
{
    public partial class InspectorPortafolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prueba",
                table: "T_VISITA",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BRE_INSPECTOR_PORTAFORLIO",
                columns: table => new
                {
                    IdInspector = table.Column<string>(nullable: false),
                    Idportafolio = table.Column<string>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRE_INSPECTOR_PORTAFORLIO", x => new { x.IdInspector, x.Idportafolio });
                    table.ForeignKey(
                        name: "FK_BRE_INSPECTOR_PORTAFORLIO_T_INSPECTOR_IdInspector",
                        column: x => x.IdInspector,
                        principalTable: "T_INSPECTOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BRE_INSPECTOR_PORTAFORLIO_T_PORTAFOLIO_Idportafolio",
                        column: x => x.Idportafolio,
                        principalTable: "T_PORTAFOLIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BRE_INSPECTOR_PORTAFORLIO_Idportafolio",
                table: "BRE_INSPECTOR_PORTAFORLIO",
                column: "Idportafolio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BRE_INSPECTOR_PORTAFORLIO");

            migrationBuilder.DropColumn(
                name: "Prueba",
                table: "T_VISITA");
        }
    }
}
