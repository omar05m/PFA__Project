using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PFA__Project.Migrations
{
    /// <inheritdoc />
    public partial class deux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artisans_categories_CategorieId",
                table: "Artisans");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Artisans",
                newName: "categorieId");

            migrationBuilder.RenameIndex(
                name: "IX_Artisans_CategorieId",
                table: "Artisans",
                newName: "IX_Artisans_categorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artisans_categories_categorieId",
                table: "Artisans",
                column: "categorieId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artisans_categories_categorieId",
                table: "Artisans");

            migrationBuilder.RenameColumn(
                name: "categorieId",
                table: "Artisans",
                newName: "CategorieId");

            migrationBuilder.RenameIndex(
                name: "IX_Artisans_categorieId",
                table: "Artisans",
                newName: "IX_Artisans_CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artisans_categories_CategorieId",
                table: "Artisans",
                column: "CategorieId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
