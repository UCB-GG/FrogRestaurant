using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaDataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CORE_PERSON",
                columns: new[] { "ID", "NAME" },
                values: new object[] { 1, "Цецо" });

            migrationBuilder.InsertData(
                table: "CORE_PERSON",
                columns: new[] { "ID", "NAME" },
                values: new object[] { 2, "Мишо" });

            migrationBuilder.InsertData(
                table: "CORE_PERSON",
                columns: new[] { "ID", "NAME" },
                values: new object[] { 3, "Стелиан" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CORE_PERSON",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CORE_PERSON",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CORE_PERSON",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
