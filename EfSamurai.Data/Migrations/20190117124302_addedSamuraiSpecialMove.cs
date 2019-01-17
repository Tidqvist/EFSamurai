using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class addedSamuraiSpecialMove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Samurais",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialMoveId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Samurais",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SpecialMoves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialMoves", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_SpecialMoveId",
                table: "Samurais",
                column: "SpecialMoveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_SpecialMoves_SpecialMoveId",
                table: "Samurais",
                column: "SpecialMoveId",
                principalTable: "SpecialMoves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_SpecialMoves_SpecialMoveId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "SpecialMoves");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_SpecialMoveId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "SpecialMoveId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Samurais");
        }
    }
}
