using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftDrinkDataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CORE_SOFT_DRINK_PERSON",
                columns: new[] { "ID", "NAME" },
                values: new object[] { 1, "Toti" });

            migrationBuilder.InsertData(
                table: "CORE_SOFT_DRINK_PERSON",
                columns: new[] { "ID", "NAME" },
                values: new object[] { 2, "Leo" });

            migrationBuilder.InsertData(
                table: "CORE_SOFT_DRINK_PERSON",
                columns: new[] { "ID", "NAME" },
                values: new object[] { 3, "Zerroni" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CORE_SOFT_DRINK_PERSON",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CORE_SOFT_DRINK_PERSON",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CORE_SOFT_DRINK_PERSON",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
