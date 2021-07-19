using Microsoft.EntityFrameworkCore.Migrations;

namespace ECCUSBET_Web.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tabela de Dimensionamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Largura = table.Column<double>(type: "float", nullable: false),
                    Profundidade = table.Column<double>(type: "float", nullable: false),
                    Comprimento = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    CustoTotalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela de Dimensionamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabela de Orçamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Servico_Equipamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    PrecoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecoTotalporItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela de Orçamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tabela de Custo Total",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustoTotaldaBet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DimensionbamentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela de Custo Total", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabela de Custo Total_Tabela de Dimensionamento_DimensionbamentoID",
                        column: x => x.DimensionbamentoID,
                        principalTable: "Tabela de Dimensionamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tabela de Custo Total_DimensionbamentoID",
                table: "Tabela de Custo Total",
                column: "DimensionbamentoID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tabela de Custo Total");

            migrationBuilder.DropTable(
                name: "Tabela de Orçamento");

            migrationBuilder.DropTable(
                name: "Tabela de Dimensionamento");
        }
    }
}
