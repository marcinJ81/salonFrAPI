using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HairDresserApi.Migrations
{
    public partial class iit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    client_phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    client_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.client_id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    position_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    position_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.position_Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTables",
                columns: table => new
                {
                    service_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTables", x => x.service_id);
                });

            migrationBuilder.CreateTable(
                name: "StatusTables",
                columns: table => new
                {
                    status_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTables", x => x.status_id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    position_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.employee_id);
                    table.ForeignKey(
                        name: "FK_Employees_Position_position_id",
                        column: x => x.position_id,
                        principalTable: "Position",
                        principalColumn: "position_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    status_id = table.Column<int>(type: "int", nullable: false),
                    reservation_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.reservation_id);
                    table.ForeignKey(
                        name: "FK_Reservations_Clients_client_id",
                        column: x => x.client_id,
                        principalTable: "Clients",
                        principalColumn: "client_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_ServiceTables_service_id",
                        column: x => x.service_id,
                        principalTable: "ServiceTables",
                        principalColumn: "service_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_StatusTables_status_id",
                        column: x => x.status_id,
                        principalTable: "StatusTables",
                        principalColumn: "status_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_position_id",
                table: "Employees",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_client_id",
                table: "Reservations",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_employee_id",
                table: "Reservations",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_service_id",
                table: "Reservations",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_status_id",
                table: "Reservations",
                column: "status_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ServiceTables");

            migrationBuilder.DropTable(
                name: "StatusTables");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
