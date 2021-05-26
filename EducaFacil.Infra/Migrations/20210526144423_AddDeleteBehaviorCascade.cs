using Microsoft.EntityFrameworkCore.Migrations;

namespace EducaFacil.Infra.Migrations
{
    public partial class AddDeleteBehaviorCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlunoCursos_Alunos_AlunoId",
                table: "AlunoCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_AlunoCursos_Cursos_CursoId",
                table: "AlunoCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Assinaturas_Alunos_AlunoId",
                table: "Assinaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Aulas_Modulos_ModuloId",
                table: "Aulas");

            migrationBuilder.DropForeignKey(
                name: "FK_Modulos_Cursos_CursoId",
                table: "Modulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Assinaturas_AssinaturaId",
                table: "Pagamentos");

            migrationBuilder.AddForeignKey(
                name: "FK_AlunoCursos_Alunos_AlunoId",
                table: "AlunoCursos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlunoCursos_Cursos_CursoId",
                table: "AlunoCursos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assinaturas_Alunos_AlunoId",
                table: "Assinaturas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aulas_Modulos_ModuloId",
                table: "Aulas",
                column: "ModuloId",
                principalTable: "Modulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Modulos_Cursos_CursoId",
                table: "Modulos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Assinaturas_AssinaturaId",
                table: "Pagamentos",
                column: "AssinaturaId",
                principalTable: "Assinaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlunoCursos_Alunos_AlunoId",
                table: "AlunoCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_AlunoCursos_Cursos_CursoId",
                table: "AlunoCursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Assinaturas_Alunos_AlunoId",
                table: "Assinaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Aulas_Modulos_ModuloId",
                table: "Aulas");

            migrationBuilder.DropForeignKey(
                name: "FK_Modulos_Cursos_CursoId",
                table: "Modulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamentos_Assinaturas_AssinaturaId",
                table: "Pagamentos");

            migrationBuilder.AddForeignKey(
                name: "FK_AlunoCursos_Alunos_AlunoId",
                table: "AlunoCursos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlunoCursos_Cursos_CursoId",
                table: "AlunoCursos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assinaturas_Alunos_AlunoId",
                table: "Assinaturas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Aulas_Modulos_ModuloId",
                table: "Aulas",
                column: "ModuloId",
                principalTable: "Modulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modulos_Cursos_CursoId",
                table: "Modulos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamentos_Assinaturas_AssinaturaId",
                table: "Pagamentos",
                column: "AssinaturaId",
                principalTable: "Assinaturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
