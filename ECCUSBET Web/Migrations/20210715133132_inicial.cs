using Microsoft.EntityFrameworkCore.Migrations;

namespace ECCUSBET_Web.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tabela de Dimensionamento",
                columns: table => new
                {
                    IdDimensionamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolUtio = table.Column<double>(type: "float", nullable: false),
                    ProfundidadeM = table.Column<double>(type: "float", nullable: false),
                    TipodeOcupacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LarguradaBet = table.Column<double>(type: "float", nullable: false),
                    ComprimentoBet = table.Column<double>(type: "float", nullable: false),
                    IdOrcamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela de Dimensionamento", x => x.IdDimensionamento);
                });

            migrationBuilder.CreateTable(
                name: "Tabela de Orçamento",
                columns: table => new
                {
                    IdOrcamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Servico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CustoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdDimensionamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabela de Orçamento", x => x.IdOrcamento);
                    table.ForeignKey(
                        name: "FK_Tabela de Orçamento_Tabela de Dimensionamento_IdDimensionamento",
                        column: x => x.IdDimensionamento,
                        principalTable: "Tabela de Dimensionamento",
                        principalColumn: "IdDimensionamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tabela de Orçamento_IdDimensionamento",
                table: "Tabela de Orçamento",
                column: "IdDimensionamento",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tabela de Orçamento");

            migrationBuilder.DropTable(
                name: "Tabela de Dimensionamento");
        }
    }
}
