using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlaner.Migrations
{
    /// <inheritdoc />
    public partial class help2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Destination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactInfo",
                table: "Destination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Destination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Destination",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LengthOfStay",
                table: "Destination",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Destination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RestingPoint_Address",
                table: "Destination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RestingPoint_Name",
                table: "Destination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Destination",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "ContactInfo",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "LengthOfStay",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "RestingPoint_Address",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "RestingPoint_Name",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Destination");
        }
    }
}
