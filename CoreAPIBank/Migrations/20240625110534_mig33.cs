using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreAPIBank.Migrations
{
    /// <inheritdoc />
    public partial class mig33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CardInfos",
                table: "CardInfos");

            migrationBuilder.RenameTable(
                name: "CardInfos",
                newName: "CardInfoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardInfoes",
                table: "CardInfoes",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "CardInfoes",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 14, 5, 32, 314, DateTimeKind.Local).AddTicks(2358));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CardInfoes",
                table: "CardInfoes");

            migrationBuilder.RenameTable(
                name: "CardInfoes",
                newName: "CardInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardInfos",
                table: "CardInfos",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "CardInfos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 56, 50, 441, DateTimeKind.Local).AddTicks(2738));
        }
    }
}
