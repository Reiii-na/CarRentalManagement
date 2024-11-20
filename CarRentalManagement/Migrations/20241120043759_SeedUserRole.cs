using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3478), new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3822), new DateTime(2024, 11, 20, 12, 37, 58, 516, DateTimeKind.Local).AddTicks(3823) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(1650), new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(1674), new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(1917), new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(1922), new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(2043), new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(2048), new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(2051), new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(2054), new DateTime(2024, 11, 20, 11, 56, 5, 111, DateTimeKind.Local).AddTicks(2055) });
        }
    }
}
