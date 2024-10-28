using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAVILANESJOHAO_EXA.Migrations
{
    /// <inheritdoc />
    public partial class Miprimeramigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    IdCelular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreModelo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    año = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<float>(type: "real", maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.IdCelular);
                });

            migrationBuilder.CreateTable(
                name: "EGavilanes",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cedula = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<float>(type: "real", maxLength: 50, nullable: false),
                    NacionalEcuatoriano = table.Column<bool>(type: "bit", nullable: false),
                    IdCelular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGavilanes", x => x.Nombre);
                    table.ForeignKey(
                        name: "FK_EGavilanes_Celular_IdCelular",
                        column: x => x.IdCelular,
                        principalTable: "Celular",
                        principalColumn: "IdCelular",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EGavilanes_IdCelular",
                table: "EGavilanes",
                column: "IdCelular");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EGavilanes");

            migrationBuilder.DropTable(
                name: "Celular");
        }
    }
}
