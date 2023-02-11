using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jololoverservices.Migrations
{
    /// <inheritdoc />
    public partial class AddedSelectedWalletProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SelectedWalletId",
                table: "Users",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedWalletId",
                table: "Users");
        }
    }
}
