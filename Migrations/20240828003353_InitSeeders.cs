using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project_ef.Migrations
{
    /// <inheritdoc />
    public partial class InitSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CreationAt", "Description", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"), new DateTime(2024, 8, 28, 0, 33, 52, 258, DateTimeKind.Utc).AddTicks(2523), "Descripcion inicial", "Category 001", new DateTime(2024, 8, 28, 0, 33, 52, 258, DateTimeKind.Utc).AddTicks(2523) },
                    { new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"), new DateTime(2024, 8, 28, 0, 33, 52, 258, DateTimeKind.Utc).AddTicks(2514), "Descripcion inicial", "Category 001", new DateTime(2024, 8, 28, 0, 33, 52, 258, DateTimeKind.Utc).AddTicks(2515) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"));
        }
    }
}
