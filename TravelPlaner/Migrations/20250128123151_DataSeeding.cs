using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelPlaner.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "European Adventure", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Road Trip USA", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TripSegment",
                columns: new[] { "Id", "Name", "TripId" },
                values: new object[,]
                {
                    { 1, "Paris Stay", 1 },
                    { 2, "Berlin Visit", 1 },
                    { 3, "New York Experience", 2 }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "Address", "City", "Country", "Description", "Discriminator", "Name", "TripSegmentId" },
                values: new object[,]
                {
                    { 1, "Champ de Mars, Paris", null, null, "Iconic iron structure", "Landmark", "Eiffel Tower", 1 },
                    { 2, "Berlin, Germany", null, null, "Historical landmark", "Landmark", "Brandenburg Gate", 2 }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "RestingPoint_Address", "City", "ContactInfo", "Country", "Discriminator", "RestingPoint_Name", "NightsSpentThere", "TripSegmentId", "Type" },
                values: new object[,]
                {
                    { 3, "123 Champs-Élysées", null, "hotelparis@example.com", null, "RestingPoint", "Hotel Paris", 3, 1, 0 },
                    { 4, "42 Alexanderplatz", null, "berlinhostel@example.com", null, "RestingPoint", "Berlin Hostel", 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Name", "TripSegmentId", "Value" },
                values: new object[,]
                {
                    { 1, "Flight to Paris", 1, 500.0 },
                    { 2, "Hotel Stay in Berlin", 2, 300.0 }
                });

            migrationBuilder.InsertData(
                table: "TripMemory",
                columns: new[] { "Id", "Name", "Note", "Photo", "SongURL", "TripSegmentId" },
                values: new object[,]
                {
                    { 1, "Eiffel Tower Selfie", "Amazing view!", "photo_base64_string_here", "https://example.com/song.mp3", 1 },
                    { 2, "Brandenburg Gate Visit", "Historical moment", "photo_base64_string_here", "https://example.com/song.mp3", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripMemory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TripMemory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripSegment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TripSegment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TripSegment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
