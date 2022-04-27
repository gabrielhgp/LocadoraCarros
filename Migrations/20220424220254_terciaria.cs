using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraCarros.Migrations
{
    public partial class terciaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clientes",
                newName: "Nome");

            migrationBuilder.AlterColumn<string>(
                name: "DataNascimento",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Clientes",
                newName: "Name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
