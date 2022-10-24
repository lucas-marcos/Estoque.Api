using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estoque.Api.Migrations
{
    /// <inheritdoc />
    public partial class CriadoQuantidadeNoProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produto");
        }
    }
}
