using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sivido.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAT_OPCION",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Value = table.Column<string>(maxLength: 30, nullable: false),
                    RequiereFotografia = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAT_OPCION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAT_TIPO_FORMULARIO",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Value = table.Column<string>(maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAT_TIPO_FORMULARIO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAT_TIPO_VISITA",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 30, nullable: false),
                    Clave = table.Column<string>(maxLength: 10, nullable: true),
                    Descripcion = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAT_TIPO_VISITA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_CLIENTE",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    RasonSocial = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CLIENTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_DIRECCION",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Calle = table.Column<string>(maxLength: 100, nullable: false),
                    NumeroExterior = table.Column<string>(maxLength: 10, nullable: false),
                    NumeroInterior = table.Column<string>(maxLength: 10, nullable: true),
                    CP = table.Column<string>(maxLength: 10, nullable: false),
                    Colonia = table.Column<string>(maxLength: 30, nullable: true),
                    Estado = table.Column<string>(maxLength: 20, nullable: true),
                    Pais = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DIRECCION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_INSPECTOR",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Usuario = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_INSPECTOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_PORTAFOLIO",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    RasonSocial = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PORTAFOLIO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAT_FORMULARIO",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    IdTipoFormulario = table.Column<string>(nullable: false),
                    Pregunta = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAT_FORMULARIO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAT_FORMULARIO_CAT_TIPO_FORMULARIO_IdTipoFormulario",
                        column: x => x.IdTipoFormulario,
                        principalTable: "CAT_TIPO_FORMULARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_VISITA",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    IdTipoVisita = table.Column<string>(nullable: false),
                    IdPortafolio = table.Column<string>(nullable: false),
                    IdCliente = table.Column<string>(nullable: false),
                    IdDreccion = table.Column<string>(nullable: false),
                    IdIsnpector = table.Column<string>(nullable: false),
                    FechaVisita = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_VISITA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_VISITA_T_CLIENTE_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "T_CLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_VISITA_T_DIRECCION_IdDreccion",
                        column: x => x.IdDreccion,
                        principalTable: "T_DIRECCION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_VISITA_T_INSPECTOR_IdIsnpector",
                        column: x => x.IdIsnpector,
                        principalTable: "T_INSPECTOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_VISITA_T_PORTAFOLIO_IdPortafolio",
                        column: x => x.IdPortafolio,
                        principalTable: "T_PORTAFOLIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_VISITA_CAT_TIPO_VISITA_IdTipoVisita",
                        column: x => x.IdTipoVisita,
                        principalTable: "CAT_TIPO_VISITA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BRE_FORMULARIO_OPCION",
                columns: table => new
                {
                    IdFormulario = table.Column<string>(nullable: false),
                    IdOpcion = table.Column<string>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRE_FORMULARIO_OPCION", x => new { x.IdFormulario, x.IdOpcion });
                    table.ForeignKey(
                        name: "FK_BRE_FORMULARIO_OPCION_CAT_FORMULARIO_IdFormulario",
                        column: x => x.IdFormulario,
                        principalTable: "CAT_FORMULARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BRE_FORMULARIO_OPCION_CAT_OPCION_IdOpcion",
                        column: x => x.IdOpcion,
                        principalTable: "CAT_OPCION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BRE_TIPO_VISITA_FORMULARIO",
                columns: table => new
                {
                    IdTipoVisita = table.Column<string>(nullable: false),
                    IdFormulario = table.Column<string>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRE_TIPO_VISITA_FORMULARIO", x => new { x.IdTipoVisita, x.IdFormulario });
                    table.ForeignKey(
                        name: "FK_BRE_TIPO_VISITA_FORMULARIO_CAT_FORMULARIO_IdFormulario",
                        column: x => x.IdFormulario,
                        principalTable: "CAT_FORMULARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BRE_TIPO_VISITA_FORMULARIO_CAT_TIPO_VISITA_IdTipoVisita",
                        column: x => x.IdTipoVisita,
                        principalTable: "CAT_TIPO_VISITA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BRE_VISITA_RESPUESTA",
                columns: table => new
                {
                    IdVisita = table.Column<string>(nullable: false),
                    IdFormulario = table.Column<string>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Respuesta = table.Column<string>(maxLength: 500, nullable: false),
                    Observaciones = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRE_VISITA_RESPUESTA", x => new { x.IdVisita, x.IdFormulario });
                    table.ForeignKey(
                        name: "FK_BRE_VISITA_RESPUESTA_CAT_FORMULARIO_IdFormulario",
                        column: x => x.IdFormulario,
                        principalTable: "CAT_FORMULARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BRE_VISITA_RESPUESTA_T_VISITA_IdVisita",
                        column: x => x.IdVisita,
                        principalTable: "T_VISITA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAT_FOTOGRAFIA",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    IdVisita = table.Column<string>(nullable: false),
                    ImgBase64 = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAT_FOTOGRAFIA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAT_FOTOGRAFIA_T_VISITA_IdVisita",
                        column: x => x.IdVisita,
                        principalTable: "T_VISITA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BRE_FORMULARIO_OPCION_IdOpcion",
                table: "BRE_FORMULARIO_OPCION",
                column: "IdOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_BRE_TIPO_VISITA_FORMULARIO_IdFormulario",
                table: "BRE_TIPO_VISITA_FORMULARIO",
                column: "IdFormulario");

            migrationBuilder.CreateIndex(
                name: "IX_BRE_VISITA_RESPUESTA_IdFormulario",
                table: "BRE_VISITA_RESPUESTA",
                column: "IdFormulario");

            migrationBuilder.CreateIndex(
                name: "IX_CAT_FORMULARIO_IdTipoFormulario",
                table: "CAT_FORMULARIO",
                column: "IdTipoFormulario");

            migrationBuilder.CreateIndex(
                name: "IX_CAT_FOTOGRAFIA_IdVisita",
                table: "CAT_FOTOGRAFIA",
                column: "IdVisita");

            migrationBuilder.CreateIndex(
                name: "IX_T_VISITA_IdCliente",
                table: "T_VISITA",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_T_VISITA_IdDreccion",
                table: "T_VISITA",
                column: "IdDreccion");

            migrationBuilder.CreateIndex(
                name: "IX_T_VISITA_IdIsnpector",
                table: "T_VISITA",
                column: "IdIsnpector");

            migrationBuilder.CreateIndex(
                name: "IX_T_VISITA_IdPortafolio",
                table: "T_VISITA",
                column: "IdPortafolio");

            migrationBuilder.CreateIndex(
                name: "IX_T_VISITA_IdTipoVisita",
                table: "T_VISITA",
                column: "IdTipoVisita");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BRE_FORMULARIO_OPCION");

            migrationBuilder.DropTable(
                name: "BRE_TIPO_VISITA_FORMULARIO");

            migrationBuilder.DropTable(
                name: "BRE_VISITA_RESPUESTA");

            migrationBuilder.DropTable(
                name: "CAT_FOTOGRAFIA");

            migrationBuilder.DropTable(
                name: "CAT_OPCION");

            migrationBuilder.DropTable(
                name: "CAT_FORMULARIO");

            migrationBuilder.DropTable(
                name: "T_VISITA");

            migrationBuilder.DropTable(
                name: "CAT_TIPO_FORMULARIO");

            migrationBuilder.DropTable(
                name: "T_CLIENTE");

            migrationBuilder.DropTable(
                name: "T_DIRECCION");

            migrationBuilder.DropTable(
                name: "T_INSPECTOR");

            migrationBuilder.DropTable(
                name: "T_PORTAFOLIO");

            migrationBuilder.DropTable(
                name: "CAT_TIPO_VISITA");
        }
    }
}
