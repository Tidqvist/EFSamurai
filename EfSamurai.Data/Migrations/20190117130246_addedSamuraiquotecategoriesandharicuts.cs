using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class addedSamuraiquotecategoriesandharicuts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HaircutId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Quotes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Haircuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haircuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuoteCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_HaircutId",
                table: "Samurais",
                column: "HaircutId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_CategoryId",
                table: "Quotes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_QuoteCategories_CategoryId",
                table: "Quotes",
                column: "CategoryId",
                principalTable: "QuoteCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_Haircuts_HaircutId",
                table: "Samurais",
                column: "HaircutId",
                principalTable: "Haircuts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_QuoteCategories_CategoryId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_Haircuts_HaircutId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "Haircuts");

            migrationBuilder.DropTable(
                name: "QuoteCategories");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_HaircutId",
                table: "Samurais");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_CategoryId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "HaircutId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Quotes");
        }
    }
}
