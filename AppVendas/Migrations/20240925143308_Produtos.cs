using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppVendas.Migrations
{
    /// <inheritdoc />
    public partial class Produtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProdutoNome",
                table: "Produtos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "CadastroAtivo",
                table: "Produtos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProdutoNome",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<double>(
                name: "CadastroAtivo",
                table: "Produtos",
                type: "float",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
