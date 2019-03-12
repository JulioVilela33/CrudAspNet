using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Documento = table.Column<string>(maxLength: 15, nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    TelTipo = table.Column<int>(nullable: false),
                    Endereco = table.Column<string>(maxLength: 100, nullable: false),
                    EndeTipo = table.Column<int>(nullable: false),
                    TipoCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
