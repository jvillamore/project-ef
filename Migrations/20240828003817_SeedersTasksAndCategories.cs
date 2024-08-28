using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project_ef.Migrations
{
    /// <inheritdoc />
    public partial class SeedersTasksAndCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                columns: new[] { "CreationAt", "Description", "UpdateAt" },
                values: new object[] { new DateTime(2024, 8, 28, 0, 38, 16, 982, DateTimeKind.Utc).AddTicks(9990), "Descripcion 002", new DateTime(2024, 8, 28, 0, 38, 16, 982, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"),
                columns: new[] { "CreationAt", "Description", "UpdateAt" },
                values: new object[] { new DateTime(2024, 8, 28, 0, 38, 16, 982, DateTimeKind.Utc).AddTicks(9981), "Descripcion 001", new DateTime(2024, 8, 28, 0, 38, 16, 982, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoryId", "CreationAt", "Description", "PrioridadTarea", "Titulo", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0003ffd7-67e4-48b2-b7c6-f5fcaf14c601"), new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"), new DateTime(2024, 8, 28, 0, 38, 16, 983, DateTimeKind.Utc).AddTicks(1662), "Tarea 001", 2, "Titulo 001", new DateTime(2024, 8, 28, 0, 38, 16, 983, DateTimeKind.Utc).AddTicks(1663) },
                    { new Guid("1003ffd7-67e4-48b2-b7c6-f5fcaf14c601"), new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"), new DateTime(2024, 8, 28, 0, 38, 16, 983, DateTimeKind.Utc).AddTicks(1668), "Tarea 002", 2, "Titulo 002", new DateTime(2024, 8, 28, 0, 38, 16, 983, DateTimeKind.Utc).AddTicks(1669) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("0003ffd7-67e4-48b2-b7c6-f5fcaf14c601"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("1003ffd7-67e4-48b2-b7c6-f5fcaf14c601"));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                columns: new[] { "CreationAt", "Description", "UpdateAt" },
                values: new object[] { new DateTime(2024, 8, 28, 0, 33, 52, 258, DateTimeKind.Utc).AddTicks(2523), "Descripcion inicial", new DateTime(2024, 8, 28, 0, 33, 52, 258, DateTimeKind.Utc).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"),
                columns: new[] { "CreationAt", "Description", "UpdateAt" },
                values: new object[] { new DateTime(2024, 8, 28, 0, 33, 52, 258, DateTimeKind.Utc).AddTicks(2514), "Descripcion inicial", new DateTime(2024, 8, 28, 0, 33, 52, 258, DateTimeKind.Utc).AddTicks(2515) });
        }
    }
}
