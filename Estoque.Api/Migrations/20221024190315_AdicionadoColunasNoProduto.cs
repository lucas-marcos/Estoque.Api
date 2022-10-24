using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estoque.Api.Migrations
{
    /// <inheritdoc />
    public partial class AdicionadoColunasNoProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoDeBarra",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoDeBarra",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Produto");
        }
    }
}
