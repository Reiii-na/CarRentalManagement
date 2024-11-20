using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 23, 29, 190, DateTimeKind.Local).AddTicks(9842), new DateTime(2024, 11, 20, 11, 23, 29, 190, DateTimeKind.Local).AddTicks(9855), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 23, 29, 190, DateTimeKind.Local).AddTicks(9858), new DateTime(2024, 11, 20, 11, 23, 29, 190, DateTimeKind.Local).AddTicks(9859), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(76), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(79), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(171), new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(171), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(174), new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(175), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(177), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(179), new DateTime(2024, 11, 20, 11, 23, 29, 191, DateTimeKind.Local).AddTicks(179), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
