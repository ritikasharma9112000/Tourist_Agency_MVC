using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tourist_Agency_MVC.Migrations
{
    public partial class Agency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity_Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity_Available_Season = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity_Special_Need = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity_Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agency_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agency_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agency_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agency_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agency_Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Package_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Activity_Id = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: true),
                    Agency_Id = table.Column<int>(type: "int", nullable: false),
                    AgencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packages_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Package_Id = table.Column<int>(type: "int", nullable: false),
                    packageId = table.Column<int>(type: "int", nullable: true),
                    Date_Of_Booking = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Packages_packageId",
                        column: x => x.packageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_packageId",
                table: "Booking",
                column: "packageId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ActivityId",
                table: "Packages",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_AgencyId",
                table: "Packages",
                column: "AgencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Agency");
        }
    }
}
