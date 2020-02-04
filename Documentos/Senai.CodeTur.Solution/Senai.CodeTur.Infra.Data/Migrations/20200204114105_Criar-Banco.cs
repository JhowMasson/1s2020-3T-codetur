using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senai.CodeTur.Infra.Data.Migrations
{
    public partial class CriarBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(250)", nullable: false),
                    Pais = table.Column<string>(type: "varchar(60)", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    Imagem = table.Column<string>(type: "varchar(350)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(300)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(20)", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Nome", "Senha", "Tipo" },
                values: new object[] { 1, "admin@codetur.com", "Jonatas Masson", "Codetur@132", "Administrador" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
