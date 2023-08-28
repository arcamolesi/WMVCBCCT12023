using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCBCCT12023.Migrations
{
    /// <inheritdoc />
    public partial class AlunosV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "aniversario",
                table: "Alunos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Alunos",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "periodo",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aniversario",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "periodo",
                table: "Alunos");
        }
    }
}
