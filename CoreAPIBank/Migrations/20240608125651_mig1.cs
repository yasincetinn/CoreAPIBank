using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreAPIBank.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryYear = table.Column<int>(type: "int", nullable: false),
                    ExpiryMonth = table.Column<int>(type: "int", nullable: false),
                    CardLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardInfos", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "CardInfos",
                columns: new[] { "ID", "Balance", "CCV", "CardLimit", "CardNumber", "CardUserName", "CreatedDate", "DeletedDate", "ExpiryMonth", "ExpiryYear", "ModifiedDate", "Status" },
                values: new object[] { 1, 100000m, "333", 100000m, "2222 2222 2222 2222", "Test Data", new DateTime(2024, 6, 8, 15, 56, 50, 441, DateTimeKind.Local).AddTicks(2738), null, 12, 2030, null, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardInfos");
        }
    }
}
