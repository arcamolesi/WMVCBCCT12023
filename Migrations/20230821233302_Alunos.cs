using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCBCCT12023.Migrations
{
    /// <inheritdoc />
    public partial class Alunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "curso",
                table: "Alunos");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Alunos",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cursoID",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_cursoID",
                table: "Alunos",
                column: "cursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cursos_cursoID",
                table: "Alunos",
                column: "cursoID",
                principalTable: "Cursos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cursos_cursoID",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_cursoID",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "cursoID",
                table: "Alunos");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AddColumn<string>(
                name: "curso",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
