using Microsoft.EntityFrameworkCore.Migrations;

namespace HairDresserApi.Migrations
{
    public partial class step2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "service_price",
                table: "ServiceTables",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "service_price",
                table: "ServiceTables",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);
        }
    }
}
