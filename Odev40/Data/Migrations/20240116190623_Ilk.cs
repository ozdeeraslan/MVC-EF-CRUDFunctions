using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Odev40.Data.Migrations
{
    /// <inheritdoc />
    public partial class Ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oyunlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TekPlatform = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyunlar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Oyunlar",
                columns: new[] { "Id", "Ad", "TekPlatform" },
                values: new object[,]
                {
                    { 1, "The Witcher 3: Wild Hunt", true },
                    { 2, "Red Dead Redemption 2", false },
                    { 3, "Cyberpunk 2077", true },
                    { 4, "Assassin's Creed Valhalla", false },
                    { 5, "FIFA 22", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oyunlar");
        }
    }
}
