using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesApi.Migrations
{
    public partial class AtualizaNomeTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Endereco_EnderecoId",
                table: "Cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filme",
                table: "Filme");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Filme",
                newName: "Filmes");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoId",
                table: "Cinemas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoId",
                table: "Cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Filmes",
                newName: "Filme");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filme",
                table: "Filme",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Endereco_EnderecoId",
                table: "Cinemas",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
