using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraCarros.Migrations
{
    public partial class quart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "Carros",
                newName: "Carro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carro",
                table: "Carro",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carro",
                table: "Carro");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "Carro",
                newName: "Carros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "Id");
        }
    }
}
