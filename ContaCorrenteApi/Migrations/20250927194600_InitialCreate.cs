using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContaCorrenteApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contaCorrentes",
                columns: table => new
                {
                    IdContaCorrente = table.Column<Guid>(type: "TEXT", nullable: false),
                    Numero = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contaCorrentes", x => x.IdContaCorrente);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contaCorrentes");
        }
    }
}
