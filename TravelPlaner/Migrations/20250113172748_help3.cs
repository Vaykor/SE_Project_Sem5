using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlaner.Migrations
{
    /// <inheritdoc />
    public partial class help3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LengthOfStay",
                table: "Destination",
                newName: "NightsSpentThere");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NightsSpentThere",
                table: "Destination",
                newName: "LengthOfStay");
        }
    }
}
