using Microsoft.EntityFrameworkCore.Migrations;

namespace Tourist_Agency_MVC.Migrations
{
    public partial class Tourist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Packages_packageId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Activities_ActivityId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Agency_AgencyId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Activity_Id",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Agency_Id",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Customer_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Package_Id",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "packageId",
                table: "Booking",
                newName: "PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_packageId",
                table: "Booking",
                newName: "IX_Booking_PackageId");

            migrationBuilder.AlterColumn<int>(
                name: "AgencyId",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackageId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Packages_PackageId",
                table: "Booking",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Activities_ActivityId",
                table: "Packages",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Agency_AgencyId",
                table: "Packages",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Packages_PackageId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Activities_ActivityId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Agency_AgencyId",
                table: "Packages");

            migrationBuilder.RenameColumn(
                name: "PackageId",
                table: "Booking",
                newName: "packageId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_PackageId",
                table: "Booking",
                newName: "IX_Booking_packageId");

            migrationBuilder.AlterColumn<int>(
                name: "AgencyId",
                table: "Packages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityId",
                table: "Packages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Activity_Id",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Agency_Id",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "packageId",
                table: "Booking",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Booking",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Customer_Id",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Package_Id",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Packages_packageId",
                table: "Booking",
                column: "packageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Activities_ActivityId",
                table: "Packages",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Agency_AgencyId",
                table: "Packages",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
