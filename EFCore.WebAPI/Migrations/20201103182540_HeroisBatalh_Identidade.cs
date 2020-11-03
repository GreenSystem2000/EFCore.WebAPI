using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.WebAPI.Migrations
{
    public partial class HeroisBatalh_Identidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herois_Batalhas_BatalhaId",
                table: "Herois");

            migrationBuilder.DropIndex(
                name: "IX_Herois_BatalhaId",
                table: "Herois");

            migrationBuilder.DropColumn(
                name: "BatalhaId",
                table: "Herois");

            migrationBuilder.CreateTable(
                name: "HeroisBatalhas",
                columns: table => new
                {
                    HeroId = table.Column<int>(nullable: false),
                    BatalhaId = table.Column<int>(nullable: false),
                    HeroiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroisBatalhas", x => new { x.BatalhaId, x.HeroId });
                    table.ForeignKey(
                        name: "FK_HeroisBatalhas_Batalhas_BatalhaId",
                        column: x => x.BatalhaId,
                        principalTable: "Batalhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroisBatalhas_Herois_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "Herois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentidadesSecretas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeReal = table.Column<int>(nullable: false),
                    HeroiId = table.Column<int>(nullable: false),
                    IdentidadeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentidadesSecretas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentidadesSecretas_Herois_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "Herois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentidadesSecretas_IdentidadesSecretas_IdentidadeId",
                        column: x => x.IdentidadeId,
                        principalTable: "IdentidadesSecretas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroisBatalhas_HeroiId",
                table: "HeroisBatalhas",
                column: "HeroiId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentidadesSecretas_HeroiId",
                table: "IdentidadesSecretas",
                column: "HeroiId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentidadesSecretas_IdentidadeId",
                table: "IdentidadesSecretas",
                column: "IdentidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroisBatalhas");

            migrationBuilder.DropTable(
                name: "IdentidadesSecretas");

            migrationBuilder.AddColumn<int>(
                name: "BatalhaId",
                table: "Herois",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Herois_BatalhaId",
                table: "Herois",
                column: "BatalhaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Herois_Batalhas_BatalhaId",
                table: "Herois",
                column: "BatalhaId",
                principalTable: "Batalhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
