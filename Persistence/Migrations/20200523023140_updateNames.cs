using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class updateNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Debts",
                table: "Debts");

            migrationBuilder.RenameTable(
                name: "Debts",
                newName: "Comments");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IdColumn",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Quote",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "IdComment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IdColumn",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Quote",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Debts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Debts",
                table: "Debts",
                column: "IdComment");
        }
    }
}
