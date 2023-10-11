using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, categoriaId) " +
                "Values ('Coca-Cola Diet', 'Refrigerante de Cola 350ml', 5.45, 'cocacola.jpg', 50, now(), 1)");

            migrationBuilder.Sql("Insert Into Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, categoriaId) " +
                "Values ('Coxinha', 'Coxinha de frango', 7.00, 'coxinha.jpg', 15, now(), 2)");

            migrationBuilder.Sql("Insert Into Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, categoriaId) " +
                "Values ('Pudin', 'Pudin de leite', 3.50, 'pudin.jpg', 31, now(), 3)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");

        }
    }
}
