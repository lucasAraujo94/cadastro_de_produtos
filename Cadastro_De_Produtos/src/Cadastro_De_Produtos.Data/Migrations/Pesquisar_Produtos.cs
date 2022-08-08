using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro_De_Produtos.Data.Migrations
{
    public partial class Pesquisar_Produto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pesquisar_Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Medida = table.Column<string>(type: "text", nullable: true),
                    Descriçao = table.Column<string>(type: "text", nullable: true),
                    Codigo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesquisar_Produto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pesquisar_Produto");
        }
    }
}
