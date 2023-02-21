using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionApi.Migrations.ConstructionDb
{
    /// <inheritdoc />
    public partial class updatedrequestmodelpaymentnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConstructionRequests_Payments_PaymentID",
                table: "ConstructionRequests");

            migrationBuilder.AlterColumn<long>(
                name: "PaymentID",
                table: "ConstructionRequests",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(994), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(2336), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(2587), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(3718), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "ConstructionRequests",
                keyColumn: "ConstructionRequestID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn", "EstimatedEndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(8728), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(8728), new DateTime(2025, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(9729), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn", "OrderID" },
                values: new object[] { new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(7245), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(7245), "c8a5130b-17c0-424f-908d-226be56ff193" });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(5331), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(7024), new DateTime(2023, 2, 20, 19, 19, 22, 669, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.AddForeignKey(
                name: "FK_ConstructionRequests_Payments_PaymentID",
                table: "ConstructionRequests",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "PaymentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConstructionRequests_Payments_PaymentID",
                table: "ConstructionRequests");

            migrationBuilder.AlterColumn<long>(
                name: "PaymentID",
                table: "ConstructionRequests",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(6852), new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(8556), new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(8824), new DateTime(2023, 2, 20, 18, 47, 17, 224, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "CompanyID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(219), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "ConstructionRequests",
                keyColumn: "ConstructionRequestID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn", "EstimatedEndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(5879), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(5880), new DateTime(2025, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(7117), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn", "OrderID" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(4388), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(4388), "24d8e199-b06a-4a68-acc7-bf7faf6a8212" });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 1L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(2034), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "projects",
                keyColumn: "ProjectID",
                keyValue: 2L,
                columns: new[] { "AddedOn", "ChangedOn" },
                values: new object[] { new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(4144), new DateTime(2023, 2, 20, 18, 47, 17, 225, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.AddForeignKey(
                name: "FK_ConstructionRequests_Payments_PaymentID",
                table: "ConstructionRequests",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "PaymentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
