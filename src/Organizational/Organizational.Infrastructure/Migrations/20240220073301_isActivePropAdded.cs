using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Organizational.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class isActivePropAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UpdateEmployeeId",
                table: "Outcomes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Outcomes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateEmployeeId",
                table: "Incomes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Incomes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Contracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdateEmployeeId",
                table: "Contracts",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateEmployeeId",
                table: "Outcomes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Outcomes");

            migrationBuilder.DropColumn(
                name: "UpdateEmployeeId",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "UpdateEmployeeId",
                table: "Contracts");
        }
    }
}
