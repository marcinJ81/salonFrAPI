using Microsoft.EntityFrameworkCore.Migrations;

namespace HairDresserApi.Migrations
{
    public partial class seedStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StatusTables",
                columns: new[] { "status_id", "status_name" },
                values: new object[,]
                {
                    { 1, "Rezerwacja" },
                    { 2, "W trakcie" },
                    { 3, "Zakończone" },
                    { 4, "Anulowane" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StatusTables",
                keyColumn: "status_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StatusTables",
                keyColumn: "status_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StatusTables",
                keyColumn: "status_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StatusTables",
                keyColumn: "status_id",
                keyValue: 4);
        }
    }
}
