using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberStore.Migrations.ApplicationRepositoryMigrations
{
    /// <inheritdoc />
    public partial class Application2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Images",
                table: "Products",
                newName: "Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "Images");
        }
    }
}
